using BusinessLogicManagerLayer;
using DataAccessLayer;
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
    public partial class CreateCage : Form
    {
        RegionManager regionManager = new RegionManager(new RegionDAL());
        BreedsManager breedsManager = new BreedsManager(new BreedDAL());
        CageManager cageManager = new CageManager(new CageDAL());



        public CreateCage()
        {
            InitializeComponent();
        }

        private void CreateCage_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        public void Refresh()
        {
            List<ZooRegion> regions = regionManager.ReadAllRegions();
            foreach (ZooRegion region in regions)
            {
                cbRegion.Items.Add(region.Name);
            }
            cbTypeOfAnimal.Items.Clear();
            tbCageName.Text = "";
            cageSize.Value = 0;
            cageCapacity.Value = 0;
            rbNO.Checked = false;
            rbYES.Checked = false;
        }

        private void cbRegion_TextChanged(object sender, EventArgs e)
        {
            cbTypeOfAnimal.Items.Clear();
            string region = cbRegion.Text;
            foreach (Breed breed in breedsManager.GetBreadsByRegion(region))
            {
                cbTypeOfAnimal.Items.Add(breed.Name);
            }
        }

        private void btnCreateCage_Click(object sender, EventArgs e)
        {
            string name = tbCageName.Text;
            ZooRegion region = regionManager.GetRegionByName(cbRegion.Text);
            string typeOfAnimal = cbTypeOfAnimal.Text;
            int capacity = Convert.ToInt32(cageCapacity.Value);
            int size = Convert.ToInt32(cageSize.Value);
            string outdoor = "";
            if (rbYES.Checked)
            {
                outdoor = "YES";
            }
            else if (rbNO.Checked)
            {
                outdoor = "NO";
            }


            Cage cage = new Cage(name, region.ID, region.Name, typeOfAnimal, capacity, size, outdoor);

            if (region.CagesAssigned == region.CagesCapacity)
            {
                MessageBox.Show("Can not create more cages region is already full!");
            }
            else
            {
                string message = cageManager.SaveCage(cage);
                region.CagesAssigned += 1;
                string message2 = regionManager.UpdateRegion(region.ID, region);
                MessageBox.Show(message);
                MessageBox.Show(message2);
            }


        }
    }
}
