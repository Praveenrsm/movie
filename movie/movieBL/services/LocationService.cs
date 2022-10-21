using movieDataLayer.Repository;
using movieentity1;
using System;
using System.Collections.Generic;
using System.Text;

namespace movieBL.services
{
    public class LocationService
    {
        ILocationRepository _movieRepository;
        public LocationService(ILocationRepository movieRepository)
        {
            this._movieRepository = movieRepository;
        }
        public void AddLocation(Location movie)
        {
            _movieRepository.AddLocation(movie);
        }
        public void UpdateLocation(Location movie)
        {
            _movieRepository.UpdateLocation(movie);
        }
        public void DeleteLocation(int LocationId)
        {
            _movieRepository.DeleteLocation(LocationId);
        }
        //get movie by id
        public void GetLocationByid(int LocationId)
        {
            _movieRepository.GetLocationById(LocationId);
        }
        //get movies
        public IEnumerable<Location> GetLocations()
        {
            return _movieRepository.GetLocations();
        }
    }
}
