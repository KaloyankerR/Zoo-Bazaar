using BusinessLogicLayer;
using BusinessLogicManagerLayer;
using BusinessLogicObjectLayer;
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
    public partial class CreateShift : Form
    {
        EmployeeScheduleManager employeeScheduleManager;
        Dashboard dashboard;
        DateTime scheduleDay;
        List<Employee> assignedEmp = new List<Employee>();
        public CreateShift(Dashboard dashboard, EmployeeScheduleManager employeeScheduleManager, DateTime scheduleDay)
        {
            InitializeComponent();
            this.employeeScheduleManager = employeeScheduleManager;
            this.dashboard = dashboard;
            //this.scheduleDay = new ScheduleDay(scheduleDay);
            this.scheduleDay = scheduleDay;
            foreach (Employee emp in employeeScheduleManager.Employees)
            {
                FLPAvaibleEmp.Controls.Add(new UCEmployee(emp, false, this));
            }
            this.FLPAssignedEmp.Visible = false;
            this.FLPAvaibleEmp.Visible = false;
            this.label6.Visible = false;
            this.label7.Visible = false;

            DTPStart.Value = scheduleDay;
            DTPStart.CustomFormat = "HH:mm";
            DTPStart.ShowUpDown = true;

            DTPEnd.Value = scheduleDay;
            DTPEnd.CustomFormat = "HH:mm";
            DTPEnd.ShowUpDown = true;


        }


        private void BCreate_Click(object sender, EventArgs e)
        {

        }

        private void BBack_Click(object sender, EventArgs e)
        {
        }

        public void AssignEmployee(UCEmployee uCEmployee)
        {

            FLPAssignedEmp.Controls.Add(uCEmployee);
            FLPAvaibleEmp.Controls.Remove(uCEmployee);
            //shift.EmployeesAssigned.Add(uCEmployee.GetEmployee());
            this.assignedEmp.Add(uCEmployee.GetEmployee());
            //change with method
        }

        public void UnAssignEmployee(UCEmployee uCEmployee)
        {
            FLPAvaibleEmp.Controls.Add(uCEmployee);
            FLPAssignedEmp.Controls.Remove(uCEmployee);
            //shift.EmployeesAssigned.Remove(uCEmployee.GetEmployee());
            this.assignedEmp.Remove(uCEmployee.GetEmployee());

            //change with method
        }

        private void CBType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FLPAssignedEmp.Visible = true;
            FLPAvaibleEmp.Visible = true;
            this.label6.Visible = true;
            this.label7.Visible = true;
            this.SelectType((Position)Enum.Parse(typeof(Position), CBType.SelectedItem.ToString()));
        }

        public void SelectType(Position position)
        {
            FLPAssignedEmp.Controls.Clear();
            FLPAvaibleEmp.Controls.Clear();
            foreach (Employee emp in employeeScheduleManager.Employees)
            {
                if (emp.Position == position)
                {
                    FLPAvaibleEmp.Controls.Add(new UCEmployee(emp, false, this));
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.dashboard.OpenChildForm(new ScheduleDay(dashboard, scheduleDay, employeeScheduleManager));

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                //employeeScheduleManager.AddShift(new BusinessLogicObjectLayer.Shift(Position.CARETAKER, DateTime.Now, DateTime.Now.AddHours(2), 6, new List<Employee> { new Employee() }));
                //this.dashboard.OpenChildForm(scheduleDay);
                DateTime start = new DateTime(scheduleDay.Year, scheduleDay.Month, scheduleDay.Day, DTPStart.Value.Hour, DTPStart.Value.Minute, 0);
                DateTime end = new DateTime(scheduleDay.Year, scheduleDay.Month, scheduleDay.Day, DTPEnd.Value.Hour, DTPEnd.Value.Minute, 0);

                employeeScheduleManager.AddShift(new Shift((Position)Enum.Parse(typeof(Position), CBType.SelectedItem.ToString()), start, end, Convert.ToInt32(NUDCapacity.Value), assignedEmp));
                this.dashboard.OpenChildForm(new ScheduleDay(dashboard, scheduleDay, employeeScheduleManager));
            }
            catch
            (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
