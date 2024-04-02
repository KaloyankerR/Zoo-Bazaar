
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


namespace DesktopApplication
{
    public partial class UserControWeek : UserControl
    {
        DateTime day;

        List<Shift> shifts = new List<Shift>();


        Dashboard dashboard;
        Schedule schedule;
        EmployeeScheduleManager employeeScheduleManager;
        public UserControWeek(DateTime date)
        {
            InitializeComponent();
            this.day = date;
            shifts = new List<Shift>();
        }

        public UserControWeek(DateTime date, List<Shift> shifts, Schedule schedule, Dashboard dashboard, EmployeeScheduleManager employeeScheduleManager)
        {
            InitializeComponent();
            this.day = date;
            this.shifts = shifts;
            this.dashboard = dashboard;
            LCount.Text = shifts.Count.ToString();
            this.schedule = schedule;
            this.employeeScheduleManager = employeeScheduleManager;
        }

        private void UserControWeek_Load(object sender, EventArgs e)
        {
            lblDate.Text = day.ToString("dd MMMM");
            CheckReservations();
        }

        private void UserControWeek_Click(object sender, EventArgs e)
        {
            string dateString = day.ToString("yyyy-MM-dd"); // convert DateTime to string with only the date part
            DateOnly dateOnly = DateOnly.FromDateTime(DateTime.Parse(dateString)); // create a new DateOnly object from the string


        }

        public void CheckReservations()
        {
            string dateString = day.ToString("yyyy-MM-dd"); // convert DateTime to string with only the date part
            DateOnly dateOnly = DateOnly.FromDateTime(DateTime.Parse(dateString)); // create a new DateOnly object from the string




            TimeSpan cutoffTime = new TimeSpan(17, 0, 0);


        }

        private void UserControWeek_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //   this.schedule.scheduleManager.Shifts.Add(new Shift(0,BusinessLogicLayer.Position.ADMINISTRATOR,day,day,5,new List<BusinessLogicLayer.Employee>()));
            schedule.DisplayWeek();
            this.dashboard.OpenChildForm(new ScheduleDay(this.dashboard, shifts, day, employeeScheduleManager));
            // MessageBox.Show("Added");
        }
    }
}
