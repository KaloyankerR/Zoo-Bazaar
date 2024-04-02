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
    public partial class ViewAnimalEatingSchedule : Form
    {
        EatingScheduleManager eatingScheduleManager = new EatingScheduleManager(new EatingScheduleDAL());
        DataTable dt = new DataTable();
        Animal _animal = new Animal();
        AnimalEatingSchedule _animalEatingSchedule = new AnimalEatingSchedule();
        public ViewAnimalEatingSchedule(Animal animal)
        {
            InitializeComponent();
            _animal = animal;
            LoadData();
        }

        private void LoadData()
        {
            dt.Clear();

            dt.Columns.Add("TimeSlots");

            ReLoadData();
        }

        private void ReLoadData()
        {
            dt.Clear();
            _animalEatingSchedule = eatingScheduleManager.GetEatingScheduleByAnimal(_animal.ID);

            if (_animalEatingSchedule == null)
            {
                dgvEatingSchedule.DataSource = null;
                dt.Rows.Add("No eating schedule set for this animal");
                btnAddSchedule.Enabled = true;
                btnDeleteSchedule.Enabled = false;
                btnEditSchedule.Enabled = false;
                tbxAnimalName.Text = $"{_animal.Name}";
                tbxNrTimesEatsDay.Text = "";
            }
            else
            {
                var formattedTimeSlots = _animalEatingSchedule.TimeSlots.OrderBy(ts => ts).Select(ts => ts.ToString("HH:mm")).ToList();
                foreach (var timeslot in formattedTimeSlots)
                {
                    dt.Rows.Add(timeslot);
                }

                tbxAnimalName.Text = _animal.Name;
                tbxNrTimesEatsDay.Text = _animalEatingSchedule.NumberOfTimesADay.ToString();

                btnAddSchedule.Enabled = false;
                btnDeleteSchedule.Enabled = true;
                btnEditSchedule.Enabled = true;
            }

            dgvEatingSchedule.DataSource = null;
            dgvEatingSchedule.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this eating schedule?", "Delete eating schedule", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DeleteEatingSchedule();
                ReLoadData();
            }
        }

        private void DeleteEatingSchedule()
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            NumberOfTimesAnimalEatsPerDay numberOfTimesAnimalEatsPerDay = new NumberOfTimesAnimalEatsPerDay(_animal, false, null);
            numberOfTimesAnimalEatsPerDay.ShowDialog();
            ReLoadData();
        }

        private void btnDeleteSchedule_Click(object sender, EventArgs e)
        {
            eatingScheduleManager.DeleteEatingScheduleByAnimal(_animal.ID);
            MessageBox.Show("Eating schedule deleted");
        }

        private void btnEditSchedule_Click(object sender, EventArgs e)
        {
            NumberOfTimesAnimalEatsPerDay numberOfTimesAnimalEatsPerDay = new NumberOfTimesAnimalEatsPerDay(_animal, true, _animalEatingSchedule);
            numberOfTimesAnimalEatsPerDay.ShowDialog();
            ReLoadData();
        }
    }
}
