
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




        public UserControWeek(DateTime date)
        {
            InitializeComponent();
            this.day = date;
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
    }
}
