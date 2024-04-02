using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicObjectLayer
{
    public class Cage
    {
        public int ID { get; set; }
        public string CageName { get; set; }
        public int RegionID { get; set; }
        public string RegionName { get; set; }

        public string TypeOfAnimal { get; set; }
        public int Capacity { get; set; }
        public int AnimalsInCage { get; set; }
        public string Outdoor { get; set; }
        public int Size { get; set; }

        public Cage() 
        {
            
        }

        public Cage(string name, int regionID, string regionName, string breedOfAnimal, int capacity, int size, string outdoor)
        {
            ID = GenerateRandomNumber();
            CageName = name;
            RegionID = regionID;
            RegionName = regionName;
            TypeOfAnimal = breedOfAnimal;
            Capacity = capacity;
            AnimalsInCage = 0;
            Size = size;
            Outdoor = outdoor;
        }
        public Cage(int id, string name, int regionID, string regionName, string breedOfAnimal, int capacity, int size, string outdoor, int assigneAnimals)
        {
            ID = id;
            CageName = name;
            RegionID = regionID;
            RegionName = regionName;
            TypeOfAnimal = breedOfAnimal;
            Capacity = capacity;
            AnimalsInCage = assigneAnimals;
            Size = size;
            Outdoor = outdoor;
        }


        public static int GenerateRandomNumber()
        {           
            Random random = new Random();

            int randomNumber = random.Next(100000, 999999);

            return randomNumber;
        }
    }
}
