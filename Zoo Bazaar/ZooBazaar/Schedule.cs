using BusinessLogicManagerLayer;
using BusinessLogicObjectLayer;
using DesktopApplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Application
{
    public partial class Schedule : Form
    {

        int month;
        int year;

        Dashboard dashboard;

        int count = 0;

        bool monthActive = false;
        bool weekActive = false;

        //static variables to pass to other form
        public static int staticMonth, staticYear;

        public EmployeeScheduleManager scheduleManager; //= new EmployeeScheduleManager(new DataAccessLayer.ShiftsDAL());

        DateTime startOfWeek;
        DateTime endOfWeek;
        public Schedule(Dashboard dashboard)
        {
            InitializeComponent();
            this.dashboard = dashboard;
        }

        public Schedule(Dashboard dashboard, EmployeeScheduleManager employeeScheduleManager)
        {
            InitializeComponent();
            this.dashboard = dashboard;
            this.scheduleManager = employeeScheduleManager;
        }


        private void Calendar_Load(object sender, EventArgs e)
        {
            DisplayDays();
        }

        private void DisplayDays()
        {
            monthActive = true;
            weekActive = false;

            dayContainer.Controls.Clear();
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblDate.Text = monthName + " " + year;

            staticMonth = month;
            staticYear = year;

            //get first day of the month
            DateTime startOfTheMonth = new DateTime(year, month, 1);

            //get count of days of the month
            int days = DateTime.DaysInMonth(year, month);

            //convert the start of the month to integer
            int daysOfTheWeek = (int)startOfTheMonth.DayOfWeek;

            // adjust start day to Monday if currently Sunday
            if (daysOfTheWeek == 0)
            {
                daysOfTheWeek = 7;
            }

            //create a blank usercontrol for any days of the week that occur before the start of the month
            for (int i = 1; i < daysOfTheWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                dayContainer.Controls.Add(ucBlank);
            }

            //create usercontrol for days
            for (int i = 1; i <= days; i++)
            {
                List<Shift> shifts1 = new List<Shift>();

                DateTime date = new DateTime(year, month, i);
                foreach (Shift shift in scheduleManager.Shifts)
                {
                    if (shift.ShiftStart.DayOfYear == date.DayOfYear)
                    {
                        shifts1.Add(shift);
                        count++;
                    }
                }
                UserControlDays ucDays = new UserControlDays(this.dashboard,date,shifts1,scheduleManager);
                ucDays.days(i);
                dayContainer.Controls.Add(ucDays);
            }
        }








        public void DisplayWeek()
        {
            this.btnCopyWeek.Visible = false;
            count = 0;
            monthActive = false;
            weekActive = true;

            lblDate.Text = "";
            dayContainer.Controls.Clear();

            DateTime now = DateTime.Now;

            // calculate start of week as Monday
            startOfWeek = now.AddDays(-(int)now.DayOfWeek + (int)DayOfWeek.Monday);
            endOfWeek = startOfWeek.AddDays(6);

            String startOfWeekString = startOfWeek.ToString("MMMM dd");
            String endOfWeekString = endOfWeek.ToString("MMMM dd");

            List<Shift> shifts = scheduleManager.NeededShifts(startOfWeek.AddDays(-1), endOfWeek);
            lblDate.Text = $"{startOfWeekString} - {endOfWeekString}";

            //create a blank usercontrol for any days of the week that occur before the start of the week (Monday)
            //needed?
            for (int i = 1; i < (int)startOfWeek.DayOfWeek; i++)
            {
                UserControlBlankWeek ucBlank = new UserControlBlankWeek();
                dayContainer.Controls.Add(ucBlank);
            }

            //create usercontrol for days of the week
            for (int i = 0; i < 7; i++)
            {
                List<Shift> shifts1 = new List<Shift>();
                DateTime day = startOfWeek.AddDays(i);
                foreach (Shift shift in shifts)
                {
                    if (shift.ShiftStart.DayOfYear == day.DayOfYear)
                    {
                        shifts1.Add(shift);
                        count++;
                    }
                }
                UserControWeek ucWeek = new UserControWeek(day, shifts1, this, dashboard, scheduleManager);
                dayContainer.Controls.Add(ucWeek);
            }
            if(count > 0)
            {
                this.btnCopyWeek.Visible = true;
            }


        }

        private void NextWeek()
        {
            this.btnCopyWeek.Visible = false;
            count = 0;
            // update startOfWeek and endOfWeek to the next week
            startOfWeek = startOfWeek.AddDays(7);
            endOfWeek = endOfWeek.AddDays(7);

            lblDate.Text = $"{startOfWeek.ToString("MMMM dd")} - {endOfWeek.ToString("MMMM dd")}";
            List<Shift> shifts = scheduleManager.NeededShifts(startOfWeek.AddDays(-1), endOfWeek);
            dayContainer.Controls.Clear();

            // create usercontrol for days of the week
            for (int i = 0; i < 7; i++)
            {
                List<Shift> shifts1 = new List<Shift>();
                DateTime day = startOfWeek.AddDays(i);
                foreach (Shift shift in shifts)
                {
                    if (shift.ShiftStart.DayOfYear == day.DayOfYear)
                    {
                        shifts1.Add(shift);
                        count ++;
                    }
                }
                UserControWeek ucWeek = new UserControWeek(day, shifts1, this, dashboard, scheduleManager);
                dayContainer.Controls.Add(ucWeek);
            }
            if (count > 0)
            {
                this.btnCopyWeek.Visible = true;
            }
        }

        private void PreviousWeek()
        {
            this.btnCopyWeek.Visible= false;
            count = 0;
            // update startOfWeek and endOfWeek to the previous week
            startOfWeek = startOfWeek.AddDays(-7);
            endOfWeek = endOfWeek.AddDays(-7);

            lblDate.Text = $"{startOfWeek.ToString("MMMM dd")} - {endOfWeek.ToString("MMMM dd")}";
            List<Shift> shifts = scheduleManager.NeededShifts(startOfWeek.AddDays(-1), endOfWeek);
            dayContainer.Controls.Clear();

            // create usercontrol for days of the week
            for (int i = 0; i < 7; i++)
            {
                List<Shift> shifts1 = new List<Shift>();
                DateTime day = startOfWeek.AddDays(i);
                foreach (Shift shift in shifts)
                {
                    if (shift.ShiftStart.DayOfYear == day.DayOfYear)
                    {
                        shifts1.Add(shift);
                        count++;
                    }
                }
                UserControWeek ucWeek = new UserControWeek(day, shifts1, this, dashboard, scheduleManager);
                dayContainer.Controls.Add(ucWeek);
            }
            if (count > 0)
            {
                this.btnCopyWeek.Visible = true;
            }
        }


        private DateTime GetFirstWeekOfYear(int year)
        {
            // get January 1st of the given year
            DateTime jan1 = new DateTime(year, 1, 1);

            // get the day of the week for January 1st
            int dayOfWeekJan1 = (int)jan1.DayOfWeek;

            // if January 1st is a Monday or a Tuesday, then the first week of the year is in that year
            if (dayOfWeekJan1 <= 2)
            {
                return jan1.AddDays(-dayOfWeekJan1 + 1);
            }

            // otherwise, the first week of the year is in the previous year
            return jan1.AddDays(8 - dayOfWeekJan1);
        }






        private void btnWeek_Click_1(object sender, EventArgs e)
        {
            DisplayWeek();
        }

        private void btnMonth_Click_1(object sender, EventArgs e)
        {
            DisplayDays();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (monthActive == false && weekActive == false)
            {
                MessageBox.Show("You need to select a weekly or monthly overview!");
            }

            dayContainer.Controls.Clear();

            if (monthActive == true)
            {
                // increment the month and adjust the year if necessary
                month++;
                if (month == 13)
                {
                    month = 1;
                    year++;
                }

                String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
                lblDate.Text = monthName + " " + year;

                staticMonth = month;
                staticYear = year;

                //get first day of the new month
                DateTime startOfTheMonth = new DateTime(year, month, 1);

                //get count of days of the new month
                int days = DateTime.DaysInMonth(year, month);

                //calculate the start day of the week for the new month
                int daysOfTheWeek = (int)startOfTheMonth.DayOfWeek;

                // adjust start day to Monday if currently Sunday
                if (daysOfTheWeek == 0)
                {
                    daysOfTheWeek = 7;
                }

                //create a blank usercontrol for any days of the week that occur before the start of the month
                for (int i = 1; i < daysOfTheWeek; i++)
                {
                    UserControlBlank ucBlank = new UserControlBlank();
                    dayContainer.Controls.Add(ucBlank);
                }

                //create usercontrol for days
                for (int i = 1; i <= days; i++)
                {
                    List<Shift> shifts1 = new List<Shift>();
                    DateTime date = new DateTime(year, month, i);
                    foreach (Shift shift in scheduleManager.Shifts)
                    {
                        if (shift.ShiftStart.DayOfYear == date.DayOfYear)
                        {
                            shifts1.Add(shift);
                            count++;
                        }
                    }

                    UserControlDays ucDays = new UserControlDays(this.dashboard,date,shifts1,scheduleManager);
                    ucDays.days(i);
                    dayContainer.Controls.Add(ucDays);
                }
            }
            else
            {
                NextWeek();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (monthActive == false && weekActive == false)
            {
                MessageBox.Show("You need to select a weekly or monthly overview!");
            }

            dayContainer.Controls.Clear();

            if (monthActive)
            {
                // decrement the month and adjust the year if necessary
                month--;
                if (month == 0)
                {
                    month = 12;
                    year--;
                }

                String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
                lblDate.Text = monthName + " " + year;

                staticMonth = month;
                staticYear = year;

                // get the first day of the new month
                DateTime startOfTheMonth = new DateTime(year, month, 1);

                // get the count of days of the new month
                int days = DateTime.DaysInMonth(year, month);

                // calculate the start day of the week for the new month
                int daysOfTheWeek = (int)startOfTheMonth.DayOfWeek;

                // adjust start day to Monday if currently Sunday
                if (daysOfTheWeek == 0)
                {
                    daysOfTheWeek = 7;
                }

                // create a blank user control for any days of the week that occur before the start of the month
                for (int i = 1; i < daysOfTheWeek; i++)
                {
                    UserControlBlank ucBlank = new UserControlBlank();
                    dayContainer.Controls.Add(ucBlank);
                }

                // create user controls for days
                for (int i = 1; i <= days; i++)
                {
                    List<Shift> shifts1 = new List<Shift>();
                    DateTime date = new DateTime(year, month, i);
                    foreach (Shift shift in scheduleManager.Shifts)
                    {
                        if (shift.ShiftStart.DayOfYear == date.DayOfYear)
                        {
                            shifts1.Add(shift);
                            count++;
                        }
                    }

                    UserControlDays ucDays = new UserControlDays(this.dashboard, date, shifts1, scheduleManager);
                    ucDays.days(i);
                    dayContainer.Controls.Add(ucDays);
                }
            }
            else
            {
                PreviousWeek();
            }
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            DisplayWeek();

        }

        private void btnCopyWeek_Click(object sender, EventArgs e)
        {
            this.scheduleManager.CopyWeek(this.startOfWeek.DayOfYear,this.startOfWeek.Year);
        }
    }
}
