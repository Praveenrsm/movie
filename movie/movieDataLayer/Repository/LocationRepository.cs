using Microsoft.EntityFrameworkCore;
using movieentity1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace movieDataLayer.Repository
{
    public class LocationRepository:ILocationRepository
    {
        MovieContext _movieDbcontext;
        public LocationRepository(MovieContext context)
        {
            this._movieDbcontext = context;
        }
        public void AddLocation(Location location)
        {
            _movieDbcontext.location.Add(location);
            _movieDbcontext.SaveChanges();
        }
        public void DeleteLocation(int locationid)
        {
            var movie = _movieDbcontext.location.Find(locationid);
            _movieDbcontext.location.Remove(movie);
            _movieDbcontext.SaveChanges();
        }
        public IEnumerable<Location> GetLocations()
        {
            return _movieDbcontext.location.ToList();
        }
        public Location GetLocationById(int locationid)
        {
            return _movieDbcontext.location.Find(locationid);
        }
        public void UpdateLocation(Location location)
        {
            _movieDbcontext.Entry(location).State = EntityState.Modified;
            _movieDbcontext.SaveChanges();
        }
    }
}
