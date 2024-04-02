using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using BusinessLogicManagerLayer;
using BusinessLogicObjectLayer;
using DataAccessLayer;

namespace Desktop_Application
{
    public partial class Dashboard : Form
    {
        private Form activateForm;
        Employee employee;

        private EmployeeDAL EmployeeDAL = new EmployeeDAL();
        private EmployeeScheduleManager employeeScheduleManager;

        public Dashboard(Employee emp)
        {



            InitializeComponent();
            OpenChildForm(new Home());
            this.employee = emp;
            string name = (employee.FirstName + " " + employee.LastName).ToString();
            lblUsername.Text = name;
            lblPosition.Text = employee.Position.ToString();
            employeeScheduleManager = new EmployeeScheduleManager(EmployeeDAL.GetAllEmployees(), new DataAccessLayer.ShiftsDAL());
            employeeScheduleManager.LoadShifts();
            employeeScheduleManager.LoadEmp();


        }

        public void OpenChildForm(Form childForm)
        {

            if (activateForm != null)
            {
                activateForm.Close();
            }

            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.ChildForm.Controls.Add(childForm);
            this.ChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblZooRegion.Text = childForm.Text;



        }

        private void NavBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Home());
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Customers());
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {


            OpenChildForm(new Schedule(this, employeeScheduleManager));
        }

        private void btnAnimals_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Animals());
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Employees());
        }

        private void btnZoo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Zoo());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Settings(employee, this));
        }
    }
}
