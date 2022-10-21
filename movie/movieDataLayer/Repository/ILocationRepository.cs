using movieentity1;
using System;
using System.Collections.Generic;
using System.Text;

namespace movieDataLayer.Repository
{
    public interface ILocationRepository
    {
        void AddLocation(Location location);
        void UpdateLocation(Location location);
        void DeleteLocation(int locationid);
       Location GetLocationById(int locationid);
        IEnumerable<Location> GetLocations();
    }
}
