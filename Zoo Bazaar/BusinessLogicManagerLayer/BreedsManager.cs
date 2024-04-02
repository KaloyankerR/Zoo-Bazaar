using BusinessLogicObjectLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicManagerLayer
{
    public class BreedsManager
    {
        private IBreedDAL breedCRUD;


        public BreedsManager(IBreedDAL breed)
        {
            this.breedCRUD = breed;
        }

        public List<Breed> GetBreadsByRegion(string region)
        {
            List<Breed> breeds = breedCRUD.GetBreadsByRegion(region);
            return breeds;
        }

        public string SaveBreed(Breed breed)
        {
            string message = breedCRUD.SaveBreed(breed);
            return message;
        }

        public List<Breed> GetAllBreeds()
        {
            List<Breed> breed = breedCRUD.GetAllBreeds();
            return breed;
        }
    }
}
