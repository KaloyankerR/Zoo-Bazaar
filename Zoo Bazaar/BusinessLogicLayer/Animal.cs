using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicObjectLayer
{
    public class Animal
    {
        public int ID { get; set; }
        public int CageID { get; set; }
        public string CageName { get; set; }
        public int RegionID { get; set; }
        public string RegionName { get; set; }
        public string Name { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string AnimalType { get; set; }
        public TypeOfFood TypeOfFood { get; set; }
        public string AdopterName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }

        public Animal()
        {

        }

        public Animal(string name, int cageID, string cageName, int regionID, string regionName, DateOnly dateOfBirth, string gender, string animalType, TypeOfFood typeOfFood, 
            string adopterName, string description, byte[] picture)
        {
            ID = GenerateRandomNumber();
            Name = name;
            CageID = cageID;
            CageName = cageName;
            RegionID = regionID;
            RegionName = regionName;
            DateOfBirth = dateOfBirth;
            Age = CalculateAge(dateOfBirth);
            Gender = gender;
            AnimalType = animalType;
            TypeOfFood = typeOfFood;
            AdopterName = adopterName;
            Description = description;
            Picture = picture;

        }
        public Animal(int id, string name, int cageID, string cageName, int regionID, string regionName, DateOnly dateOfBirth, string gender, string animalType, TypeOfFood typeOfFood,
            string adopterName, string description, byte[] picture)
        {
            ID = id;
            Name = name;
            CageID = cageID;
            CageName = cageName;
            RegionID = regionID;
            RegionName = regionName;
            DateOfBirth = dateOfBirth;
            Age = CalculateAge(dateOfBirth);
            Gender = gender;
            AnimalType = animalType;
            TypeOfFood = typeOfFood;
            AdopterName = adopterName;
            Description = description;
            Picture = picture;

        }

        public static int GenerateRandomNumber()
        {
            Random random = new Random();

            int randomNumber = random.Next(100000, 999999);

            return randomNumber;
        }

        public int CalculateAge(DateOnly dateOfBirth)
        {
            
            DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now);

            
            int age = currentDate.Year - dateOfBirth.Year;

           
            if (currentDate.Month < dateOfBirth.Month || (currentDate.Month == dateOfBirth.Month && currentDate.Day < dateOfBirth.Day))
            {
                age--;
            }

            return age;
        }
    }
}
