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
    public partial class UpdateCage : Form
    {
        RegionManager regionManager = new RegionManager(new RegionDAL());
        BreedsManager breedsManager = new BreedsManager(new BreedDAL());
        CageManager cageManager = new CageManager(new CageDAL());

        Zoo zoo;
        Cage cage;
        public UpdateCage(Cage zooCage, Zoo zoo2)
        {
            InitializeComponent();
            this.cage = zooCage;
            this.zoo = zoo2;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateCage_Load(object sender, EventArgs e)
        {
            cbRegion.Items.Clear();
            cbTypeOfAnimal.Items.Clear();
            foreach (ZooRegion region in regionManager.ReadAllRegions())
            {
                cbRegion.Items.Add(region.Name);
            }
            tbCageName.Text = cage.CageName;
            cbRegion.Text = cage.RegionName;
            cbTypeOfAnimal.Text = cage.TypeOfAnimal;
            cageCapacity.Value = cage.Capacity;
            tbAnimalsAssigned.Text = cage.AnimalsInCage.ToString();
            cageSize.Value = cage.Size;

            if (cage.Outdoor == "YES")
            {
                rbYES.Checked = true;
            }
            else
            {
                rbNO.Checked = true;
            }
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

        private void btnUpdateCage_Click(object sender, EventArgs e)
        {
            string name = tbCageName.Text;
            ZooRegion region = regionManager.GetRegionByName(cbRegion.Text);
            string typeOfAnimal = cbTypeOfAnimal.Text;
            int capacity = Convert.ToInt32(cageCapacity.Value);
            int size = Convert.ToInt32(cageSize.Value);
            int animalsInCage = Convert.ToInt32(tbAnimalsAssigned.Text);

            string outdoor = "";
            if (rbYES.Checked)
            {
                outdoor = "YES";
            }
            else if (rbNO.Checked)
            {
                outdoor = "NO";
            }


            Cage updatedCage = new Cage(cage.ID, name, region.ID, region.Name, typeOfAnimal, capacity, size, outdoor, animalsInCage);

            string message = cageManager.UpdateCage(cage.ID, updatedCage);
            MessageBox.Show(message);
        }

        private void UpdateCage_FormClosed(object sender, FormClosedEventArgs e)
        {
            zoo.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnimalsInCage animals = new AnimalsInCage(cage);
            animals.Show();
        }
    }
}
