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
    public partial class Zoo : Form
    {
        RegionManager regionManager = new RegionManager(new RegionDAL());
        CageManager cageManager = new CageManager(new CageDAL());


        public Zoo()
        {
            InitializeComponent();
        }

        private void btnCreateRegion_Click(object sender, EventArgs e)
        {
            CreateRegion Region = new CreateRegion();
            Region.Show();
        }

        private void Zoo_Load(object sender, EventArgs e)
        {
            Refresh();

        }

        public void Refresh()
        {
            dgvRegions.Rows.Clear();
            dgvCages.Rows.Clear();

            cbFilterByRegion.Items.Clear();
            cbFilterByRegion.Items.Add("ALL");

            foreach (ZooRegion region in regionManager.ReadAllRegions())
            {
                cbFilterByRegion.Items.Add(region.Name);
            }


            foreach (ZooRegion region in regionManager.ReadAllRegions())
            {
                dgvRegions.Rows.Add(new object[] { region.ID, region.Name, (region.CagesAssigned + "/" + region.CagesCapacity) });

            }

            foreach (Cage cage in cageManager.ReadAllCages())
            {
                dgvCages.Rows.Add(new object[] { cage.ID, cage.CageName, cage.RegionName, (cage.AnimalsInCage + "/" + cage.Capacity).ToString() });
            }


        }

        private void btnDeleteRegion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this region?", "Delete region", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (dgvRegions.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvRegions.SelectedRows[0];

                    string message = "";
                    string id = selectedRow.Cells["ID"].Value.ToString();

                    ZooRegion region = regionManager.GetRegionByID(Convert.ToInt32(id));

                    if (region.CagesAssigned > 0)
                    {
                        message = "Zoo Region has assigned cages. Please make sure that the zoo region is free of cages before deleting!";
                    }
                    else
                    {
                        message = regionManager.DeleteRegionById(Convert.ToInt32(id));

                    }


                    MessageBox.Show(message);

                    Refresh();

                }
            }
        }

        private void btnCreateCage_Click(object sender, EventArgs e)
        {

            CreateCage cage = new CreateCage();
            cage.Show();

        }

        private void btnDeleteCage_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this cage?", "Delete cage", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (dgvCages.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvCages.SelectedRows[0];


                    string id = selectedRow.Cells["cageID"].Value.ToString();


                    Cage cage = cageManager.GetCageById(Convert.ToInt32(id));


                    string message = "";
                    string message2 = "";

                    if (cage.AnimalsInCage > 0)
                    {
                        message = "There are still animals in the cage. Please make sure that the cage is free of animals before deleting!";
                    }
                    else
                    {
                         message = cageManager.DeleteCage(Convert.ToInt32(id));

                        string regionName = selectedRow.Cells["Region"].Value.ToString();


                        ZooRegion region = regionManager.GetRegionByName(regionName);

                        region.CagesAssigned -= 1;

                         message2 = regionManager.UpdateRegion(region.ID, region);
                        MessageBox.Show(message2);

                    }


                    MessageBox.Show(message);


                    Refresh();

                }
            }

        }

        private void btnUpdateCage_Click(object sender, EventArgs e)
        {

            if (dgvCages.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvCages.SelectedRows[0];


                string id = selectedRow.Cells["cageID"].Value.ToString();

                Cage cage = cageManager.GetCageById(Convert.ToInt32(id));

                UpdateCage updateCage = new UpdateCage(cage, this);
                updateCage.Show();

            }

        }

        private void cbFilterByRegion_TextChanged(object sender, EventArgs e)
        {
            dgvCages.Rows.Clear();
            if (cbFilterByRegion.Text == "ALL")
            {
                Refresh();
            }
            else
            {
                string regionName = cbFilterByRegion.Text;
                foreach (Cage cage in cageManager.GetCagesByRegionName(regionName))
                {
                    dgvCages.Rows.Add(new object[] { cage.ID, cage.CageName, cage.RegionName, (cage.AnimalsInCage + "/" + cage.Capacity).ToString() });
                }

            }
        }

        private void cbFilterByRegion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddBreeds_Click(object sender, EventArgs e)
        {

            if (dgvRegions.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvRegions.SelectedRows[0];


                string id = selectedRow.Cells["ID"].Value.ToString();
                ZooRegion region = regionManager.GetRegionByID(Convert.ToInt32(id));



                AddBreed breed = new AddBreed(region);
                breed.Show();

            }
            
        }
    }
}
