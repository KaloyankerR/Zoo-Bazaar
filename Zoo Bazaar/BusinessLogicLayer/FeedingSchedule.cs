using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicObjectLayer
{
    public class FeedingSchedule
    {
        public int ID { get; set; }
        public Animal Animal { get; set; }
        public TimeOfDay TimeOfDay { get; set; }
        public TypeOfFood Food { get; set; }
        public string FeedingQuantity { get; set; }
        public DateTime FeedingTime { get; set; }

        public FeedingSchedule() 
        {
        
        }

        public FeedingSchedule(int id, Animal animal, TimeOfDay timeOfDay, TypeOfFood food, string feedingQuantity, DateTime feedingTime)
        {
            ID = id;
            Animal = animal;
            TimeOfDay = timeOfDay;
            Food = food;
            FeedingQuantity = feedingQuantity;
            FeedingTime = feedingTime;
        }
    }
}
