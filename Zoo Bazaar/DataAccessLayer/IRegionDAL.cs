using BusinessLogicObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IRegionDAL
    {
        string CreateRegion(ZooRegion region);
        List<ZooRegion> ReadAllRegions();
        string DeleteRegionById(int regionId);
        ZooRegion GetRegionByName(string regionName);
        ZooRegion GetRegionByID(int regionID);
        string UpdateRegion(int id, ZooRegion updatedRegion);
    }
}
