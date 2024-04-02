using BusinessLogicObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IBreedDAL
    {
        List<Breed> GetBreadsByRegion(string region);
        string SaveBreed(Breed breed);

        List<Breed> GetAllBreeds();
    }
}
