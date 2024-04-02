using BusinessLogicLayer;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Desktop_Application
{
    public partial class Animals : Form
    {
        RegionManager regionManager = new RegionManager(new RegionDAL());
        BreedsManager breedsManager = new BreedsManager(new BreedDAL());
        CageManager cageManager = new CageManager(new CageDAL());
        AnimalManager animalManager = new AnimalManager(new AnimalDAL());

        public Animals()
        {
            InitializeComponent();
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            CreateAnimal animal = new CreateAnimal();
            animal.Show();
        }

        private void Animals_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        public void Refresh()
        {
            dgvAnimals.Rows.Clear();
            cbFilterByRegion.Items.Clear();
            tbFilterByBreed.Text = "";

            foreach (Animal animal in animalManager.GetAllAnimals())
            {
                dgvAnimals.Rows.Add(new object[] { animal.ID, animal.Name, animal.AnimalType.ToString(), animal.Age.ToString(), animal.Gender, animal.TypeOfFood.ToString(), animal.CageName, animal.RegionName });

            }

            List<ZooRegion> regions = regionManager.ReadAllRegions();
            cbFilterByRegion.Items.Add("ALL");
            foreach (ZooRegion region in regions)
            {
                cbFilterByRegion.Items.Add(region.Name);
            }
        }

        private void cbFilterByRegion_TextChanged(object sender, EventArgs e)
        {
            string input = cbFilterByRegion.Text;
            if (input == "ALL")
            {
                Refresh();
            }
            else
            {
                dgvAnimals.Rows.Clear();

                foreach (Animal animal in animalManager.GetAnimalsByRegionName(input))
                {
                    dgvAnimals.Rows.Add(new object[] { animal.ID, animal.Name, animal.AnimalType.ToString(), animal.Age.ToString(), animal.Gender, animal.TypeOfFood.ToString(), animal.CageName, animal.RegionName });

                }
            }
        }

        private void tbFilterByBreed_TextChanged(object sender, EventArgs e)
        {
            string input = tbFilterByBreed.Text;
            if (input != "")
            {
                dgvAnimals.Rows.Clear();

                foreach (Animal animal in animalManager.GetAllAnimalsByBreed(input))
                {
                    dgvAnimals.Rows.Add(new object[] { animal.ID, animal.Name, animal.AnimalType.ToString(), animal.Age.ToString(), animal.Gender, animal.TypeOfFood.ToString(), animal.CageName, animal.RegionName });

                }
            }
            else
            {
                Refresh();
            }
        }

        private void btnDeleteAnimal_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this animal?", "Delete Animal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (dgvAnimals.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvAnimals.SelectedRows[0];


                    string id = selectedRow.Cells["ID"].Value.ToString();

                    Animal animal = animalManager.GetAnimalById(Convert.ToInt32(id));

                    string message = animalManager.DeleteAnimalById(Convert.ToInt32(id));

                    Cage cage = cageManager.GetCageById(animal.CageID);
                    ZooRegion zooRegion = regionManager.GetRegionByID(animal.RegionID);

                    cage.AnimalsInCage -= 1;
                    cageManager.UpdateCage(cage.ID, cage);

                    zooRegion.AnimalsAssigned -= 1;
                    regionManager.UpdateRegion(animal.RegionID, zooRegion);

                    MessageBox.Show(message);

                    Refresh();

                }
            }
        }

        private void btnUpdateAnimal_Click(object sender, EventArgs e)
        {
            if (dgvAnimals.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvAnimals.SelectedRows[0];


                string id = selectedRow.Cells["ID"].Value.ToString();

                Animal animal = animalManager.GetAnimalById(Convert.ToInt32(id));

                UpdateAnimal animalUpdate = new UpdateAnimal(animal, this);
                animalUpdate.Show();

            }
        }

        private void btnEatingSchedule_Click(object sender, EventArgs e)
        {
            if (dgvAnimals.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvAnimals.SelectedRows[0];


                string id = selectedRow.Cells["ID"].Value.ToString();

                Animal animal = animalManager.GetAnimalById(Convert.ToInt32(id));

                ViewAnimalEatingSchedule animalEatingSchedule = new ViewAnimalEatingSchedule(animal);
                animalEatingSchedule.ShowDialog();

            }
        }
    }
}
