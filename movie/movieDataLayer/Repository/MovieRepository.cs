using Microsoft.EntityFrameworkCore;
using movieentity1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace movieDataLayer.Repository
{
    public class MovieRepository : IMovieRepository
    {
        MovieContext _movieDbcontext;
        public MovieRepository(MovieContext context)
        {
            this._movieDbcontext = context;
        }
        public void AddMovie(MovieEL movie)
        {
            _movieDbcontext.movies.Add(movie);
            _movieDbcontext.SaveChanges();
        }
        public void DeleteMovie(int movieId)
        {
            var movie = _movieDbcontext.movies.Find(movieId);
            _movieDbcontext.movies.Remove(movie);
            _movieDbcontext.SaveChanges();
        }
        public IEnumerable<MovieEL> GetMovies()
        {
            return _movieDbcontext.movies.ToList();
        }
        public MovieEL GetMovieById(int movieId)
        {
            return _movieDbcontext.movies.Find(movieId);
        }
        public void UpdateMovie(MovieEL movie)
        {
            _movieDbcontext.Entry(movie).State = EntityState.Modified;
            _movieDbcontext.SaveChanges();
        }
       
    }
}
