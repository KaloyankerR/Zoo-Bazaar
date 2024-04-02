using BusinessLogicObjectLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicManagerLayer
{
    public class CageManager
    {
        private ICageDAL cageCRUD;


        public CageManager(ICageDAL cage)
        {
            this.cageCRUD = cage;
        }

        public string SaveCage(Cage cage)
        {
            string message = cageCRUD.SaveCage(cage);
            return message;
        }

        public List<Cage> ReadAllCages()
        {
            List<Cage> cages = cageCRUD.ReadAllCages();
            return cages;
        }

        public string DeleteCage(int cageID)
        {
            string message = cageCRUD.DeleteCage(cageID);
            return message;
        }
        public string UpdateCage(int id, Cage updatedCage)
        {
            string message = cageCRUD.UpdateCage(id, updatedCage);
            return message;
        }
        public Cage GetCageById(int id)
        {
            Cage cage = cageCRUD.GetCageById(id);
            return cage;
        }

        public List<Cage> GetCagesByRegionName(string regionName)
        {
            List<Cage> cages = cageCRUD.GetCagesByRegionName(regionName);
            return cages;
        }
    }
}
