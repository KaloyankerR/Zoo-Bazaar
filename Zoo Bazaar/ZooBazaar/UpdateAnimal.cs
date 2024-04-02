using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicManagerLayer;
using BusinessLogicObjectLayer;
using DataAccessLayer;
using Microsoft.VisualBasic.Devices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Desktop_Application
{
    public partial class UpdateAnimal : Form
    {
        byte[] picture;
        Animal animal;
        Animals animalsForm;

        CageManager cageManager = new CageManager(new CageDAL());
        RegionManager regionManager = new RegionManager(new RegionDAL());
        AnimalManager animalManager = new AnimalManager(new AnimalDAL());



        public UpdateAnimal(Animal animal2, Animals animals2Form)
        {
            InitializeComponent();
            this.animal = animal2;
            this.animalsForm = animals2Form;
        }

        public UpdateAnimal(Animal animal3)
        {
            this.animal = animal3;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Refresh()
        {
            cbCage.Items.Clear();
            lblID.Text = "ID: " + animal.ID.ToString();
            tbName.Text = animal.Name;
            tbDescription.Text = animal.Description;
            tbAdopter.Text = animal.AdopterName;

            tbRegion.Text = animal.RegionName;
            tbBreed.Text = animal.AnimalType;
            cbCage.Text = animal.CageID + " - " + animal.CageName;
            cbTypeOfFood.Text = animal.TypeOfFood.ToString();

            DateTime dateOfBirth = animal.DateOfBirth.ToDateTime(new TimeOnly(0));
            dtpDateOfBirth.Value = dateOfBirth;

            if (animal.Gender == "male")
            {
                rbMale.Checked = true;
            }
            else if (animal.Gender == "female")
            {
                rbFemale.Checked = true;
            }
            picture = animal.Picture;
            byte[] pictureData = animal.Picture;
            using (MemoryStream ms = new MemoryStream(pictureData))
            {
                Image picture = Image.FromStream(ms);
                pictureBox.Image = picture;
            }


            foreach (Cage cage in cageManager.GetCagesByRegionName(animal.RegionName))
            {
                cbCage.Items.Add(cage.ID + " - " + cage.CageName);
            }
        }

        private void UpdateAnimal_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            ZooRegion region = regionManager.GetRegionByName(tbRegion.Text);
            string breed = tbBreed.Text;
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


            Cage currentCage = cageManager.GetCageById(animal.CageID);

            string cageString = cbCage.Text;
            string[] cageSplit = cageString.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            Cage cage = cageManager.GetCageById(Convert.ToInt32(cageSplit[0]));

            Animal updatedAnimal = new Animal(animal.ID, name, cage.ID, cage.CageName, region.ID, region.Name, dateOfBirth, gender, breed, food, adopter, description, picture);

            if (cage.AnimalsInCage == cage.Capacity)
            {
                MessageBox.Show("Cage is already full! Animal was not be added!");
            }
            else if (cage.TypeOfAnimal != updatedAnimal.AnimalType)
            {
                MessageBox.Show("Breed of animal doesn't maatch the breed of the cage!");
            }
            else if (currentCage != cage)
            {

                currentCage.AnimalsInCage -= 1;
                cage.AnimalsInCage += 1;

                cageManager.UpdateCage(currentCage.ID, currentCage);
                cageManager.UpdateCage(cage.ID, cage);

                string message = animalManager.UpdateAnimal(updatedAnimal);

                MessageBox.Show(message);
                MessageBox.Show("Animal assigned to a different cage!");
            }
            else
            {
                string message = animalManager.UpdateAnimal(updatedAnimal);

                MessageBox.Show(message);

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

        private void UpdateAnimal_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (animalsForm != null)
            {
                animalsForm.Refresh();
            }
            
        }
    }
}
