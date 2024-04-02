using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicObjectLayer
{
    public class Breed
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
        public int RegionID { get; set; }


        public Breed()
        {
            
        }
        public Breed(string name, string region, int regionID)
        {
            Name = name;
            Region = region;
            RegionID = regionID;

        }
    }
}
