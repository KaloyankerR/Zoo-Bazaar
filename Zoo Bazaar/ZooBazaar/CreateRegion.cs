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
    public partial class CreateRegion : Form
    {
        RegionManager regionManager = new RegionManager(new RegionDAL());

        public CreateRegion()
        {
            InitializeComponent();
        }

        private void CreateRegion_Load(object sender, EventArgs e)
        {
            Restart();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateRegion_Click(object sender, EventArgs e)
        {
            string name = tbRegionName.Text;
            string animalsType = tbTypeOfAnimals.Text;
            int cageCapacity = Convert.ToInt32(CageCapacity.Value);
            int animalsCapacity = Convert.ToInt32(AnimalCapacity.Value);

            ZooRegion region = new ZooRegion(name, animalsType, cageCapacity, animalsCapacity);

            string message = regionManager.CreateRegion(region);
            MessageBox.Show(message);

            Restart();
        }

        public void Restart()
        {
            tbRegionName.Text = "";
            tbTypeOfAnimals.Text = "";
            CageCapacity.Value = 0;
            AnimalCapacity.Value = 0;
        }
    }
}
