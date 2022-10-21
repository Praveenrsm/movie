using Microsoft.EntityFrameworkCore;
using movieentity1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace movieDataLayer.Repository
{
    public class TheatreRepository:ITheatreRepository
    {
        MovieContext _movieDbcontext;
        public TheatreRepository(MovieContext context)
        {
            this._movieDbcontext = context;
        }
        public void AddTheatre(Theatre theatre)
        {
            _movieDbcontext.theatre.Add(theatre);
            _movieDbcontext.SaveChanges();
        }
        public void DeleteTheatre(int theatreId)
        {
            var theatre = _movieDbcontext.theatre.Find(theatreId);
            _movieDbcontext.theatre.Remove(theatre);
            _movieDbcontext.SaveChanges();
        }
        public IEnumerable<Theatre> GetTheatres()
        {
            return _movieDbcontext.theatre.ToList();
        }
        public Theatre GetTheatreById(int theatreId)
        {
            return _movieDbcontext.theatre.Find(theatreId);
        }
        public void UpdateTheatre(Theatre theatre)
        {
            _movieDbcontext.Entry(theatre).State = EntityState.Modified;
            _movieDbcontext.SaveChanges();
        }
    }
}
