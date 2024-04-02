using BusinessLogicObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IAnimalDAL
    {
        string SaveAnimal(Animal animal);
        List<Animal> GetAllAnimals();
        List<Animal> GetAnimalsByRegionName(string regionName);
        List<Animal> GetAllAnimalsByBreed(string breed);
        Animal GetAnimalById(int id);

        string DeleteAnimalById(int id);

        string UpdateAnimal(Animal updatedAnimal);
        List<Animal> GetAnimalsByCageID(int cageID);
    }
}
