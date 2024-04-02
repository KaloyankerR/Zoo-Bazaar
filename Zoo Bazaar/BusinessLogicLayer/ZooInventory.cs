using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicObjectLayer
{
    public class ZooInventory
    {
        public int Meat { get; set; }
        public int Grass { get; set; }
        public int Seeds { get; set; }
        public int SeaLifeFood { get; set; }
        public int Granula { get; set; }
        public List<Medicaments> Medicaments { get; set;}

        public ZooInventory()
        {

        }

        public ZooInventory(int meat, int grass, int seeds, int seaLifeFood, int granula, List<Medicaments> medicaments)
        {
            Meat = meat;
            Grass = grass;
            Seeds = seeds;
            SeaLifeFood = seaLifeFood;
            Granula = granula;
            Medicaments = medicaments;
        }
    }
}
