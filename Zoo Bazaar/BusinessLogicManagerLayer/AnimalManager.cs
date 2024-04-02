using BusinessLogicObjectLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicManagerLayer
{
    public class AnimalManager
    {
        private IAnimalDAL animalCRUD;


        public AnimalManager(IAnimalDAL animal)
        {
            this.animalCRUD = animal;
        }

        public string SaveAnimal(Animal animal)
        {
            string message = animalCRUD.SaveAnimal(animal);
            return message;
        }

        public List<Animal> GetAllAnimals()
        {
            List<Animal> animals = animalCRUD.GetAllAnimals();
            return animals;
        }

        public List<Animal> GetAnimalsByRegionName(string regionName)
        {
            List<Animal> animals = animalCRUD.GetAnimalsByRegionName(regionName);
            return animals;
        }

        public List<Animal> GetAllAnimalsByBreed(string breed)
        {
            List<Animal> animals = animalCRUD.GetAllAnimalsByBreed(breed);
            return animals;
        }

        public Animal GetAnimalById(int id)
        {
            Animal animal = animalCRUD.GetAnimalById(id);
            return animal;
        }

        public string DeleteAnimalById(int id)
        {
            string message = animalCRUD.DeleteAnimalById(id);
            return message;
        }

        public string UpdateAnimal(Animal updatedAnimal)
        {
            string message = animalCRUD.UpdateAnimal(updatedAnimal);
            return message;
        }

        public List<Animal> GetAnimalsByCageID(int cageID)
        {
            List<Animal> animals = animalCRUD.GetAnimalsByCageID(cageID);
            return animals;
        }
    }
}
