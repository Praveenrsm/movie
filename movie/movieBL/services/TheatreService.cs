using movieDataLayer.Repository;
using movieentity1;
using System;
using System.Collections.Generic;
using System.Text;

namespace TheatreBL.services
{
    public class TheatreService
    {
        ITheatreRepository _theatreRepository;
        public TheatreService(ITheatreRepository theatreRepository)
        {
            this._theatreRepository = theatreRepository;
        }
        public void AddTheatre(Theatre theatre)
        {
            _theatreRepository.AddTheatre(theatre);
        }
        public void UpdateTheatre(Theatre theatre)
        {
            _theatreRepository.UpdateTheatre(theatre);
        }
        public void DeleteTheatre(int theatreid)
        {
            _theatreRepository.DeleteTheatre(theatreid);
        }
        //get movie by id
        public Theatre GetTheatreById(int movieId)
        {
            return _theatreRepository.GetTheatreById(movieId);
        }
        //get movies
        public IEnumerable<Theatre> GetTheatres()
        {
            return _theatreRepository.GetTheatres();
        }
    }
}
