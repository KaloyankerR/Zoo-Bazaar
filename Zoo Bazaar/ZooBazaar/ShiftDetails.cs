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
    public partial class ShiftDetails : Form
    {
        Shift shift;
        Dashboard dashboard;
        EmployeeScheduleManager employeeScheduleManager;
        DateTime date;
        List<Shift> shifts1 = new List<Shift>();
        public ShiftDetails(Shift shift, Dashboard dashboard, DateTime date, List<Shift> shifts, EmployeeScheduleManager employeeScheduleManager)
        {
            InitializeComponent();
            this.shift = shift;
            this.dashboard = dashboard;
            this.employeeScheduleManager = employeeScheduleManager;
            this.date = date;
            this.shifts1 = shifts;
            this.RefreshPage();
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
            label1.Text = shift.ShiftStart.Hour + ":" + mS + " - " + shift.ShiftEnd.Hour + ":" + mE;

            label2.Text = shift.EmployeesAssigned.Count + " / " + shift.Capacity;

        }

        private void BBack_Click(object sender, EventArgs e)
        {
        }

        public void RefreshPage()
        {
            this.FLPAssignedEmp.Controls.Clear();
            foreach (BusinessLogicLayer.Employee employee in shift.EmployeesAssigned)
            {
                FLPAssignedEmp.Controls.Add(new UCEmployee(employee, true, this));
            }
            this.FLPAvaibleEmp.Controls.Clear();
            foreach (BusinessLogicLayer.Employee employee in employeeScheduleManager.Employees)
            {
                if (shift.EmployeesAssigned.Contains(employee) == false)
                {
                    FLPAvaibleEmp.Controls.Add(new UCEmployee(employee, false, this));
                }
            }
        }

        public void AssignEmployee(UCEmployee uCEmployee)
        {
            FLPAssignedEmp.Controls.Add(uCEmployee);
            FLPAvaibleEmp.Controls.Remove(uCEmployee);
            //shift.EmployeesAssigned.Add(uCEmployee.GetEmployee());
            employeeScheduleManager.AssignEmployee(shift, uCEmployee.GetEmployee());

            label2.Text = shift.EmployeesAssigned.Count + " / " + shift.Capacity;
            //change with method
        }

        public void UnAssignEmployee(UCEmployee uCEmployee)
        {
            FLPAvaibleEmp.Controls.Add(uCEmployee);
            FLPAssignedEmp.Controls.Remove(uCEmployee);
            //shift.EmployeesAssigned.Remove(uCEmployee.GetEmployee());
            employeeScheduleManager.UnAssignEmployee(shift, uCEmployee.GetEmployee());


            label2.Text = shift.EmployeesAssigned.Count + " / " + shift.Capacity;
            //change with method
        }

        private void FLPAvaibleEmp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dashboard.OpenChildForm(new ScheduleDay(dashboard, shifts1, date, employeeScheduleManager));

        }
    }
}
