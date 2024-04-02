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
    public partial class NumberOfTimesAnimalEatsPerDay : Form
    {
        private Animal _animal;
        private bool _update;
        private AnimalEatingSchedule _animalEatingSchedule;

        public NumberOfTimesAnimalEatsPerDay(Animal animal, bool update, AnimalEatingSchedule eatingSchedule)
        {
            InitializeComponent();
            _animal = animal;
            _update = update;
            _animalEatingSchedule = eatingSchedule;
            if (update)
            {
                nudNrTimes.Value = eatingSchedule.NumberOfTimesADay;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int numberOfTimesAnimalEatsPerDay = Convert.ToInt32(nudNrTimes.Value);
            if (_update)
            {
                _animalEatingSchedule.NumberOfTimesADay = numberOfTimesAnimalEatsPerDay;
                EditEatingSchedule editEatingSchedule = new EditEatingSchedule(_animalEatingSchedule);
                this.Close();
                editEatingSchedule.ShowDialog();
            }
            else
            {
                SetEatingSchedule setEatingSchedule = new SetEatingSchedule(_animal, numberOfTimesAnimalEatsPerDay);
                this.Close();
                setEatingSchedule.ShowDialog();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
