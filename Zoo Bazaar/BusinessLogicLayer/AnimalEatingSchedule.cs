using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicObjectLayer
{
    public class AnimalEatingSchedule
    {
        public int AnimalEatingScheduleID { get; set; }
        public Animal Animal { get; set; }
        public int NumberOfTimesADay { get; set; }
        public List<TimeOnly> TimeSlots { get; set; }

        public AnimalEatingSchedule(int animalEatingScheduleID, Animal animal, int numberOfTimesADay, List<TimeOnly> timeSlots)
        {
            AnimalEatingScheduleID = animalEatingScheduleID;
            Animal = animal;
            NumberOfTimesADay = numberOfTimesADay;
            TimeSlots = timeSlots;
        }

        public AnimalEatingSchedule()
        {
        }
    }
}
