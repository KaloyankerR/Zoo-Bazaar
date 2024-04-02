
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
    public partial class UserControlDays : UserControl
    {



        DateOnly date;

        Dashboard dashboard;
        DateTime date1;
        List<Shift> shifts1;
        EmployeeScheduleManager employeeScheduleManager;
        //static variable for day
        public static int staticDay;
        public UserControlDays()
        {
            InitializeComponent();


        }

        public UserControlDays(Dashboard dashboard, DateTime date, List<Shift> shifts, EmployeeScheduleManager employeeScheduleManager)
        {
            InitializeComponent();
            this.dashboard = dashboard;
            this.date1 = date;
            this.shifts1 = shifts;
            this.employeeScheduleManager = employeeScheduleManager;




        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            staticDay = Convert.ToInt32(lblDays.Text);

            string day = Schedule.staticYear + "-" + Schedule.staticMonth.ToString("00") + "-" + staticDay.ToString("00");
            date = DateOnly.ParseExact(day, "yyyy-MM-dd", null);

            DisplayReservationsCount();
        }

        public void days(int numDay)
        {
            lblDays.Text = numDay + "";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {

        }

        private void DisplayReservationsCount()
        {

        }

        private void lblReservations_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Redirect();
        }

        private void UserControlDays_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Redirect();
        }

        private void lblDays_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Redirect();
        }

        public void Redirect()
        {
            this.dashboard.OpenChildForm(new ScheduleDay(this.dashboard, shifts1, date1, employeeScheduleManager));
        }
    }
}
