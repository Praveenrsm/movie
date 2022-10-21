using System;
using System.Collections.Generic;
using movieDataLayer;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using movieentity1;
namespace movieBL
{
    public class MovieBL
    {
        MovieContext db = null;
        public MovieBL(MovieContext db)
        {
            this.db = db;
        }
        public string AddMovies(MovieEL movie)
        {
           // db = new MovieContext();
            db.movies.Add(movie);
            db.SaveChanges();
            return "saved";
        }
        public string UpdateMovies(MovieEL movie)
        {
            //db = new MovieContext();
            db.Entry(movie).State = EntityState.Modified;
            db.SaveChanges();
            return "updated";
        }
        public string DeleteMovies(int movieId)
        {
            //db = new MovieContext();
            MovieEL movieObj = db.movies.Find(movieId);
            db.Entry(movieObj).State = EntityState.Deleted;
            db.SaveChanges();
            return "deleted";
        }
        public List<MovieEL> ShowAll()
        {
            //db = new MovieContext();
            List<MovieEL> movielist = db.movies.ToList();
            return movielist;
        }
        public List<MovieEL> ShowAllByMovieType(string type)
        {
           // db = new MovieContext();
            List<MovieEL> movielist = db.movies.ToList();
            //linq query -> select * from movie where movietype="type"
            var result = from movies in movielist
                         where movies.MovieType == type
                         orderby movies.Name ascending
                         select new MovieEL { Name = movies.Name, Id = movies.Id };
            List<MovieEL> movieresult = new List<MovieEL>();
            foreach (var item in result) //linq query execution
            {
                movieresult.Add(item);
            }
            return movieresult;
        }
        public MovieEL ShowMovieById(int movieid)
        {
           // db = new MovieContext();
            MovieEL movie = db.movies.Find(movieid);
            return movie;
        }
    }
}
