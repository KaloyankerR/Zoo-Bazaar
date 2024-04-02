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
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

namespace Desktop_Application
{
    public partial class CreateAnimal : Form
    {
        RegionManager regionManager = new RegionManager(new RegionDAL());
        BreedsManager breedsManager = new BreedsManager(new BreedDAL());
        CageManager cageManager = new CageManager(new CageDAL());
        AnimalManager animalManager = new AnimalManager(new AnimalDAL());

        byte[] picture;

        public CreateAnimal()
        {
            InitializeComponent();
        }



        private void CreateAnimal_Load(object sender, EventArgs e)
        {
            List<ZooRegion> regions = regionManager.ReadAllRegions();
            foreach (ZooRegion region in regions)
            {
                cbRegion.Items.Add(region.Name);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            ZooRegion region = regionManager.GetRegionByName(cbRegion.Text);
            string breed = cbBreed.Text;
            string gender = "";
            if (rbMale.Checked)
            {
                gender = "male";
            }
            else if (rbFemale.Checked)
            {
                gender = "female";
            }
            else
            {
                gender = "no gender selected";
            }
            DateTime date = dtpDateOfBirth.Value;
            DateOnly dateOfBirth = DateOnly.FromDateTime(date);

            string adopter = tbAdopter.Text;
            string description = tbDescription.Text;

            string typeOFFood = cbTypeOfFood.Text;
            TypeOfFood food;
            Enum.TryParse(typeOFFood, out food);

            string cageString = cbCage.Text;
            string[] cageSplit = cageString.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            Cage cage = cageManager.GetCageById(Convert.ToInt32(cageSplit[0]));

            Animal animal = new Animal(name, cage.ID, cage.CageName, region.ID, region.Name, dateOfBirth, gender, breed, food, adopter, description, picture);

            if (cage.AnimalsInCage == cage.Capacity)
            {
                MessageBox.Show("Cage is already full! Animal was not be added!");
            }
            else if (cage.TypeOfAnimal != animal.AnimalType)
            {
                MessageBox.Show("Breed of animal doesn't maatch the breed of the cage!");
            }
            else
            {
                string message = animalManager.SaveAnimal(animal);
                cage.AnimalsInCage += 1;
                cageManager.UpdateCage(cage.ID, cage);

                region.AnimalsAssigned += 1;
                regionManager.UpdateRegion(region.ID, region);

                MessageBox.Show(message);

            }


        }

        private void cbRegion_TextChanged(object sender, EventArgs e)
        {
            cbBreed.Items.Clear();
            cbCage.Items.Clear();
            string region = cbRegion.Text;
            foreach (Breed breed in breedsManager.GetBreadsByRegion(region))
            {
                cbBreed.Items.Add(breed.Name);
            }

            foreach (Cage cage in cageManager.GetCagesByRegionName(region))
            {
                cbCage.Items.Add(cage.ID + " - " + cage.CageName);
            }
        }

        private void linkPhoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Create an instance of OpenFileDialog
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set the filter for the file extension and default file extension
            openFileDialog1.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif";
            openFileDialog1.Title = "Select an item image";

            // Show the dialog and get the result
            DialogResult result = openFileDialog1.ShowDialog();

            // If the user selected a file
            if (result == DialogResult.OK)
            {
                // Get the selected file's path
                string filePath = openFileDialog1.FileName;

                // Check if the file path is not empty
                if (!string.IsNullOrEmpty(filePath))
                {
                    lblPath.Text = filePath;
                    lblPath.Visible = true;

                    // Load the image from the file
                    Image selectedImage = Image.FromFile(filePath);

                    // Set the PictureBox's Image property with the loaded image
                    pictureBox.Image = selectedImage;

                    // Convert the image file to byte[]
                    byte[] imageData = File.ReadAllBytes(filePath);

                    // Set the byte[] as the item's picture
                    // Replace "item" with your own Item object
                    picture = imageData;
                }
            }
        }
    }
}
