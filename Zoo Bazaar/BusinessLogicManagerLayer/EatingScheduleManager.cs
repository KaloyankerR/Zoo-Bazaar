using BusinessLogicObjectLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicManagerLayer
{
    public class EatingScheduleManager
    {
        private IEatingScheduleDAL eatingScheduleDAL;

        public EatingScheduleManager(IEatingScheduleDAL eatingScheduleDAL)
        {
            this.eatingScheduleDAL = eatingScheduleDAL;
        }

        public string SaveEatingSchedule(AnimalEatingSchedule animalEatingSchedule)
        {
            return eatingScheduleDAL.SaveEatingSchedule(animalEatingSchedule);
        }

        public string UpdateEatingSchedule(AnimalEatingSchedule updatedEatingSchedule)
        {
            return eatingScheduleDAL.UpdateEatingSchedule(updatedEatingSchedule);
        }

        public string DeleteEatingScheduleByAnimal(int animalId)
        {
            return eatingScheduleDAL.DeleteEatingScheduleByAnimal(animalId);
        }

        public AnimalEatingSchedule GetEatingScheduleByAnimal(int animalId)
        {
            return eatingScheduleDAL.GetEatingScheduleByAnimal(animalId);
        }

        public List<AnimalEatingSchedule> GetAllEatingSchedules()
        {
            return eatingScheduleDAL.GetAllEatingSchedules();
        }
    }

}
