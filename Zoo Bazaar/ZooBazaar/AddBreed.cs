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
    public partial class AddBreed : Form
    {
        ZooRegion region;
        public AddBreed(ZooRegion region2)
        {
            InitializeComponent();
            this.region = region2;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbBreed.Text == "")
            {
                MessageBox.Show("There is no breed name input! Please enter the breed for the region!");
            }
            else
            {

                BreedsManager breedsManager = new BreedsManager(new BreedDAL());


                string breedName = tbBreed.Text;


                Breed breed = new Breed(breedName, region.Name, region.ID);

                string message = breedsManager.SaveBreed(breed);
                MessageBox.Show(message);
            }

        }

        private void AddBreed_Load(object sender, EventArgs e)
        {
            tbRegion.Text = region.Name;

        }
    }
}
