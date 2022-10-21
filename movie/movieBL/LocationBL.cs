using Microsoft.EntityFrameworkCore;
using movieDataLayer;
using movieentity1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace movieBL
{
    public class LocationBL
    {
        MovieContext db = null;
        public LocationBL(MovieContext db)
        {
            this.db = db;
        }
        public string AddLocations(Location booking)
        {
            // db = new MovieContext();
            db.location.Add(booking);
            db.SaveChanges();
            return "saved";
        }
        public string UpdateLocations(Location booking)
        {
            //db = new MovieContext();
            db.Entry(booking).State = EntityState.Modified;
            db.SaveChanges();
            return "updated";
        }
        public string DeleteLocations(int bookingid)
        {
            //db = new MovieContext();
            Location movieObj = db.location.Find(bookingid);
            db.Entry(movieObj).State = EntityState.Deleted;
            db.SaveChanges();
            return "deleted";
        }
        public List<Location> ShowAll()
        {
            //db = new MovieContext();
            List<Location> movielist = db.location.ToList();
            return movielist;
        }
        //public List<MovieEL> ShowAllByMovieType(string type)
        //{
        //    // db = new MovieContext();
        //    List<MovieEL> movielist = db.movies.ToList();
        //    //linq query -> select * from movie where movietype="type"
        //    var result = from movies in movielist
        //                 where movies.MovieType == type
        //                 orderby movies.Name ascending
        //                 select new MovieEL { Name = movies.Name, Id = movies.Id };
        //    List<MovieEL> movieresult = new List<MovieEL>();
        //    foreach (var item in result) //linq query execution
        //    {
        //        movieresult.Add(item);
        //    }
        //    return movieresult;
        //}
        public Location ShowLocationById(int bookingid)
        {
            // db = new MovieContext();
            Location movie = db.location.Find(bookingid);
            return movie;
        }
    }
}
