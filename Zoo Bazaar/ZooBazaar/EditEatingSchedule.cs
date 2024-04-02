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
    public partial class EditEatingSchedule : Form
    {
        EatingScheduleManager eatingScheduleManager = new EatingScheduleManager(new EatingScheduleDAL());
        AnimalEatingSchedule _animalEatingSchedule;
        List<int> hours = new List<int>();
        List<int> minutes = new List<int>();
        int counter = 1;
        List<(int, TimeOnly)> TimeSlots = new List<(int, TimeOnly)>();

        public EditEatingSchedule(AnimalEatingSchedule animalEatingSchedule)
        {
            InitializeComponent();
            _animalEatingSchedule = animalEatingSchedule;
            GetCbxData();
            InitializeTimeSlots();
            cbxHours.DataSource = hours;
            cbxHours.SelectedIndex = 0;
            cbxMinutes.DataSource = minutes;
            cbxMinutes.SelectedIndex = 0;
            btnPrevious.Enabled = false;
            UpdateUI();
            LoadCurrentTimeSlot();
            if (_animalEatingSchedule.NumberOfTimesADay < TimeSlots.Count)
            {
                TimeSlots.RemoveAt(TimeSlots.Count - 1);
            }
        }

        private void InitializeTimeSlots()
        {
            foreach (var timeSlot in _animalEatingSchedule.TimeSlots)
            {
                TimeSlots.Add((counter++, timeSlot));
            }
            counter = 1;
        }

        private void GetCbxData()
        {
            hours.Clear();
            minutes.Clear();

            for (int i = 1; i <= 23; i++)
            {
                hours.Add(i);
            }
            hours.Add(0);

            for (int i = 0; i < 60; i += 5)
            {
                minutes.Add(i);
            }
        }

        private void SaveCurrentTimeSlot()
        {
            var newTimeSlot = new TimeOnly((int)cbxHours.SelectedItem, (int)cbxMinutes.SelectedItem);
            var timeSlotIndex = TimeSlots.FindIndex(ts => ts.Item1 == counter);

            if (timeSlotIndex != -1)
            {
                TimeSlots[timeSlotIndex] = (counter, newTimeSlot);
            }
            else
            {
                TimeSlots.Add((counter, newTimeSlot));
            }
        }

        private void LoadOrResetTimeSlot()
        {
            if (TimeSlots.Any(ts => ts.Item1 == counter))
            {
                LoadCurrentTimeSlot();
            }
            else
            {
                cbxHours.SelectedIndex = 0;
                cbxMinutes.SelectedIndex = 0;
            }
        }

        private void UpdateUI()
        {
            lblInfo.Text = $"Timeslot {counter}";
            btnPrevious.Enabled = counter > 1;
            btnNext.Text = (counter == _animalEatingSchedule.NumberOfTimesADay) ? "Save" : "Next";
            btnNext.Enabled = true;
        }

        private void PerformSaveOperation()
        {
            List<TimeOnly> timeSlots = TimeSlots.Select(ts => ts.Item2).ToList();
            string message = eatingScheduleManager.UpdateEatingSchedule(new AnimalEatingSchedule(_animalEatingSchedule.AnimalEatingScheduleID, _animalEatingSchedule.Animal, _animalEatingSchedule.NumberOfTimesADay, timeSlots));
            MessageBox.Show($"{message}");
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SaveCurrentTimeSlot();

            if (counter < _animalEatingSchedule.NumberOfTimesADay)
            {
                counter++;
                LoadOrResetTimeSlot();
            }
            else if (counter == _animalEatingSchedule.NumberOfTimesADay)
            {
                PerformSaveOperation();
                return;
            }

            UpdateUI();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (counter > 1)
            {
                counter--;
                LoadCurrentTimeSlot();
                UpdateUI();
            }
        }

        private void LoadCurrentTimeSlot()
        {
            if (TimeSlots.Any(ts => ts.Item1 == counter))
            {
                var currentTimeSlot = TimeSlots.First(ts => ts.Item1 == counter).Item2;
                cbxHours.SelectedItem = currentTimeSlot.Hour;
                cbxMinutes.SelectedItem = currentTimeSlot.Minute;
            }
            else
            {
                cbxHours.SelectedIndex = 0;
                cbxMinutes.SelectedIndex = 0;
            }
        }
    }

}
