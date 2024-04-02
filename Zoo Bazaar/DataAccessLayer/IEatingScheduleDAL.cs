using BusinessLogicObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IEatingScheduleDAL
    {
        string SaveEatingSchedule(AnimalEatingSchedule animalEatingSchedule);
        List<AnimalEatingSchedule> GetAllEatingSchedules();
        AnimalEatingSchedule GetEatingScheduleByAnimal(int id);
        string DeleteEatingScheduleByAnimal(int id);
        string UpdateEatingSchedule(AnimalEatingSchedule updatedEatingSchedule);
    }
}
