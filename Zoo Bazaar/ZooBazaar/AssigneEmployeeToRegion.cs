using BusinessLogicLayer;
using BusinessLogicManagerLayer;
using BusinessLogicObjectLayer;
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
    public partial class AssigneEmployeeToRegion : Form
    {
        RegionManager regionManager = new RegionManager(new RegionDAL());
        EmployeeManager employeeManager = new EmployeeManager(new EmployeeDAL());



        Employee emp;
        public AssigneEmployeeToRegion(Employee employee)
        {
            InitializeComponent();
            this.emp = employee;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void Refresh()
        {
            lbCurrentRegions.Items.Clear();
            dgvEmployees.Rows.Clear();
            cbAllRegions.Items.Clear();
            lblEmployeeID.Text = "Employee ID: " + emp.ID.ToString();
            dgvEmployees.Rows.Add(new object[] { emp.ID, emp.FirstName + " " + emp.LastName, emp.Position.ToString(), emp.Email, emp.Phone, emp.ContractType.ToString() });
            List<ZooRegion> regions = regionManager.ReadAllRegions();


            foreach (ZooRegion region in employeeManager.GetAssignedRegionsByEmployeeID(emp.ID))
            {
                lbCurrentRegions.Items.Add(region.Name);
            }
            foreach (ZooRegion region in regions)
            {
                cbAllRegions.Items.Add(region.Name);
            }
        }

        private void AssigneEmployeeToRegion_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnAddRegions_Click(object sender, EventArgs e)
        {
            if (cbAllRegions.Text == "")
            {
                MessageBox.Show("Please select a region!");
            }
            else
            {
                ZooRegion region = regionManager.GetRegionByName(cbAllRegions.Text);

                employeeManager.SaveRegionToEmployee(emp, region);
                MessageBox.Show("Region was saved for the employee!");
            }

            Refresh();

        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            string regionName = lbCurrentRegions.SelectedItem.ToString();
            ZooRegion region = regionManager.GetRegionByName(regionName);

            string message = employeeManager.DeleteRegionAssignment(emp, region);
            MessageBox.Show(message);

            Refresh();
        }
    }
}
