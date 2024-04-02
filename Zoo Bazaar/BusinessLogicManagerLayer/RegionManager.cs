using BusinessLogicObjectLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicManagerLayer
{
    public class RegionManager
    {

        private IRegionDAL regionCRUD;


        public RegionManager(IRegionDAL region)
        {
            this.regionCRUD = region;
        }

        public string CreateRegion(ZooRegion region)
        {
            string message = regionCRUD.CreateRegion(region);
            return message;
        }

        public List<ZooRegion> ReadAllRegions()
        {
            List<ZooRegion> regions = regionCRUD.ReadAllRegions();
            return regions;
        }

        public string DeleteRegionById(int regionId)
        {
            string message = regionCRUD.DeleteRegionById(regionId);
            return message;
        }

        public ZooRegion GetRegionByName(string regionName)
        {
            ZooRegion region = regionCRUD.GetRegionByName(regionName);
            return region;
        }

        public ZooRegion GetRegionByID(int regionID)
        {
            ZooRegion region = regionCRUD.GetRegionByID(regionID);
            return region;
        }

        

        public string UpdateRegion(int id, ZooRegion updatedRegion)
        {
            string message = regionCRUD.UpdateRegion(id, updatedRegion);
            return message;
        }
    }
}
