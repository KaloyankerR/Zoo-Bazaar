using BusinessLogicLayer;
using BusinessLogicManagerLayer;
using DataAccessLayer;
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
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }
        EmployeeManager employeeManager = new EmployeeManager(new EmployeeDAL());


        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            CreateEmployee createEmployee = new CreateEmployee();
            createEmployee.Show();
        }

        public void Refresh()
        {
            dgvEmployees.Rows.Clear();

            foreach (Employee emp in employeeManager.GetAllEmployees())
            {
                dgvEmployees.Rows.Add(new object[] { emp.ID, emp.FirstName + " " + emp.LastName, emp.Position.ToString(), emp.Email, emp.Phone, emp.ContractType.ToString() });

            }


        }

        private void Employees_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (dgvEmployees.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvEmployees.SelectedRows[0];


                    string id = selectedRow.Cells["ID"].Value.ToString();

                    Employee emp = employeeManager.GetEmployeeByID(Convert.ToInt32(id));

                    string message = employeeManager.DeleteEmployeeByID(emp.ID);

                    MessageBox.Show(message);

                    Refresh();

                }
            }
        }

        private void tbFilterByName_TextChanged(object sender, EventArgs e)
        {
            string name = tbFilterByName.Text;

            if (name != "")
            {
                dgvEmployees.Rows.Clear();

                foreach (Employee emp in employeeManager.GetAllEmployeesByName(name))
                {
                    dgvEmployees.Rows.Add(new object[] { emp.ID, emp.FirstName + " " + emp.LastName, emp.Position.ToString(), emp.Email, emp.Phone, emp.ContractType.ToString() });

                }
            }
            else
            {
                Refresh();
            }
        }

        private void btnAssignEmployeeToRegion_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvEmployees.SelectedRows[0];


                string id = selectedRow.Cells["ID"].Value.ToString();

                Employee emp = employeeManager.GetEmployeeByID(Convert.ToInt32(id));



                AssigneEmployeeToRegion assignRegion = new AssigneEmployeeToRegion(emp);
                assignRegion.Show();

                Refresh();

            }
        }
    }
}
