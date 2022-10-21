using movieDataLayer.Repository;
using movieentity1;
using System.Collections.Generic;
using System;
using System.Text;

namespace movieBL.services
{
    public class MovieService
    {
        IMovieRepository _movieRepository;
        public MovieService(IMovieRepository movieRepository)
        {
            this._movieRepository = movieRepository;
        }
        public void AddMovie(MovieEL movie)
        {
            _movieRepository.AddMovie(movie);
        }
        public void UpdateMovie(MovieEL movie)
        {
            _movieRepository.UpdateMovie(movie);
        }
        public void DeleteMovie(int movieId)
        {
            _movieRepository.DeleteMovie(movieId);
        }
        //get movie by id
        public MovieEL GetMovieById(int movieId)
        {
           return _movieRepository.GetMovieById(movieId);
        }
        //get movies
        public IEnumerable<MovieEL> GetMovies()
        {
            return _movieRepository.GetMovies();
        }
    }
}
