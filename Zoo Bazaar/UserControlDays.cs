
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
        //static variable for day
        public static int staticDay;
        public UserControlDays()
        {
            InitializeComponent();
            

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
    }
}
