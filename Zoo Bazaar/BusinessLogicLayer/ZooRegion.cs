using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinessLogicObjectLayer
{
    public class ZooRegion
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string TypeOfAnimals { get; set; }
        public int CagesCapacity { get; set; }
        public int AnimalsCapacity { get; set; }
        public int CagesAssigned { get; set; }
        public int AnimalsAssigned { get; set; }


        public ZooRegion() 
        { 

        }

        public ZooRegion(string name, string animalsType, int cageCapacity, int animalsCapacity)
        {
            
            Name = name;
            TypeOfAnimals = animalsType;
            CagesCapacity = cageCapacity;
            AnimalsCapacity = animalsCapacity;
            CagesAssigned = 0;
            AnimalsAssigned = 0;
        }
    }
}
