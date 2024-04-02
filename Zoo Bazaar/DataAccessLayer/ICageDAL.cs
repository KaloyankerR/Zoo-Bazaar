using BusinessLogicObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface ICageDAL
    {
        string SaveCage(Cage cage);
        List<Cage> ReadAllCages();
        string DeleteCage(int cageID);
        string UpdateCage(int id, Cage updatedCage);
        Cage GetCageById(int id);
        List<Cage> GetCagesByRegionName(string regionName);


    }
}
