using movieentity1;
using System;
using System.Collections.Generic;
using System.Text;

namespace movieDataLayer.Repository
{
    public interface IMovieRepository
    {
        void AddMovie(MovieEL movie);
        void UpdateMovie(MovieEL movie);
        void DeleteMovie(int movieid);    
        MovieEL GetMovieById(int movieId);
        IEnumerable<MovieEL> GetMovies();
    }
}
