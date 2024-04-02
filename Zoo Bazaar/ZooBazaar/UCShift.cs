using BusinessLogicManagerLayer;
using BusinessLogicObjectLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Application
{
    public partial class UCShift : UserControl
    {
        private Dashboard dashboard;
        private List<Shift> shifts;
        private DateTime date;
        private Shift shift;
        private EmployeeScheduleManager employeeScheduleManager;
        public UCShift(Shift shift, Dashboard dashboard, List<Shift> shifts, DateTime day, EmployeeScheduleManager employeeScheduleManager)
        {
            InitializeComponent();
            label1.Text = shift.Position.ToString();
            string mS = "";
            string mE = "";
            if (shift.ShiftStart.Minute < 10)
            {
                mS = "0" + shift.ShiftStart.Minute.ToString();
            }
            else
            {
                mS = shift.ShiftStart.Minute.ToString();
            }
            if (shift.ShiftEnd.Minute < 10)
            {
                mE = "0" + shift.ShiftEnd.Minute.ToString();
            }
            else
            {
                mE = shift.ShiftEnd.Minute.ToString();
            }
            label2.Text = shift.ShiftStart.Hour + ":" + mS + " - " + shift.ShiftEnd.Hour + ":" + mE;
            this.dashboard = dashboard;
            this.shift = shift;
            this.shifts = shifts;
            date = day;
            this.employeeScheduleManager = employeeScheduleManager;
            this.LCapacity.Text = shift.EmployeesAssigned.Count + " / " + shift.Capacity;
        }

        private void UCShift_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            dashboard.OpenChildForm(new ShiftDetails(shift, dashboard, date, shifts, employeeScheduleManager));
        }
    }
}
