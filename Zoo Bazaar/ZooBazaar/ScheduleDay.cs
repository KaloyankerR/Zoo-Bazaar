using BusinessLogicLayer;
using BusinessLogicManagerLayer;
using BusinessLogicObjectLayer;
using Desktop_Application;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Application
{
    public partial class ScheduleDay : Form
    {
        Dashboard dashboard;
        DateTime day;
        List<Shift> shifts;
        EmployeeScheduleManager manager;
        public ScheduleDay(Dashboard dashboard, List<Shift> shifts, DateTime day, EmployeeScheduleManager employeeScheduleManager)
        {
            InitializeComponent();
            this.day = day;
            this.dashboard = dashboard;
            this.shifts = shifts;
            manager = employeeScheduleManager;
            label1.Text = day.Year + "/" + day.Month + "/" + day.Day;
            cbPosition.DataSource = Enum.GetValues(typeof(Position));
            this.RefreshPage();
        }

        public ScheduleDay(Dashboard dashboard, DateTime day, EmployeeScheduleManager employeeScheduleManager)
        {
            InitializeComponent();
            this.day = day;
            this.dashboard = dashboard;
            shifts = new List<Shift>();
            foreach (Shift shift in employeeScheduleManager.Shifts)
            {
                if (shift.ShiftStart.Day == day.Day)
                {
                    shifts.Add(shift);
                }
            }
            manager = employeeScheduleManager;
            label1.Text = day.Year + "/" + day.Month + "/" + day.Day;
            this.RefreshPage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dashboard.OpenChildForm(new Schedule(this.dashboard, manager));
        }

        private void BCreate_Click(object sender, EventArgs e)
        {
        }

        public void RefreshPage()
        {
            this.FLPShifts.Controls.Clear();
            foreach (Shift shift in shifts)
            {
                FLPShifts.Controls.Add(new UCShift(shift, dashboard, shifts, day, manager));
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime? startTime = DateTime.TryParseExact(tbStartTime.Text, "HH:mm", null, System.Globalization.DateTimeStyles.None, out DateTime parsedTime)
                    ? new DateTime(day.Year, day.Month, day.Day, parsedTime.Hour, parsedTime.Minute, 0)
                    : (DateTime?)null;

                DateTime? endTime = DateTime.TryParseExact(tbEndTime.Text, "HH:mm", null, System.Globalization.DateTimeStyles.None, out parsedTime)
                    ? new DateTime(day.Year, day.Month, day.Day, parsedTime.Hour, parsedTime.Minute, 0)
                    : (DateTime?)null;

                object position;

                if (cbPosition.SelectedItem != null)
                {
                    position = (Position)cbPosition.SelectedItem;
                }
                else
                {
                    position = null;
                }


                Dictionary<string, object?> filters = new()
                {
                    { "position",  position},
                    { "startTime", startTime},
                    { "endTime", endTime}
                };

                List<Shift> filteredShifts = manager.FilterShifts(shifts, filters);
                this.FLPShifts.Controls.Clear();

                foreach (Shift shift in filteredShifts)
                {
                    FLPShifts.Controls.Add(new UCShift(shift, dashboard, shifts, day, manager));
                }
            }
            catch
            {
                MessageBox.Show("There was an error! Please check the filtering options!");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cbPosition.SelectedItem = null;
            tbStartTime.Text = string.Empty;
            tbEndTime.Text = string.Empty;

            RefreshPage();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.dashboard.OpenChildForm(new CreateShift(this.dashboard, manager, day));

        }
    }

}
