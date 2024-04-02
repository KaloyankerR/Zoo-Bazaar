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
    public partial class AnimalsInCage : Form
    {
        Cage cage;
        AnimalManager animalManager = new AnimalManager(new AnimalDAL());

        public AnimalsInCage(Cage cage1)
        {
            InitializeComponent();
            this.cage = cage1;
        }

        private void AnimalsInCage_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Refresh()
        {
            lblCageName.Text = cage.CageName;
            lblIDofCage.Text = cage.ID.ToString();
            foreach (Animal animal in animalManager.GetAnimalsByCageID(cage.ID))
            {
                dgvAnimals.Rows.Add(new object[] { animal.ID, animal.Name, animal.AnimalType.ToString(), animal.Age.ToString(), animal.Gender, animal.TypeOfFood.ToString(), animal.CageName, animal.RegionName });

            }
        }

        private void btnUpdateAnimal_Click(object sender, EventArgs e)
        {
            if (dgvAnimals.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvAnimals.SelectedRows[0];


                string id = selectedRow.Cells["ID"].Value.ToString();

                Animal animal = animalManager.GetAnimalById(Convert.ToInt32(id));

                UpdateAnimal animalUpdate = new UpdateAnimal(animal);
                animalUpdate.Show();

            }
        }
    }
}
