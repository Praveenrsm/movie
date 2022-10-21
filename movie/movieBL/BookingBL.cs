using Microsoft.EntityFrameworkCore;
using movieDataLayer;
using movieentity1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace movieBL
{
    public class BookingBL
    {
        MovieContext db = null;
        public BookingBL(MovieContext db)
        {
            this.db = db;
        }
        public string AddBookings(Booking booking)
        {
            // db = new MovieContext();
            db.booking.Add(booking);
            db.SaveChanges();
            return "saved";
        }
        public string UpdateMovies(Booking booking)
        {
            //db = new MovieContext();
            db.Entry(booking).State = EntityState.Modified;
            db.SaveChanges();
            return "updated";
        }
        public string DeleteMovies(int bookingid)
        {
            //db = new MovieContext();
            Booking movieObj = db.booking.Find(bookingid);
            db.Entry(movieObj).State = EntityState.Deleted;
            db.SaveChanges();
            return "deleted";
        }
        public List<Booking> ShowAll()
        {
            //db = new MovieContext();
            List<Booking> movielist = db.booking.ToList();
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
        public Booking ShowMovieById(int bookingid)
        {
            // db = new MovieContext();
            Booking movie = db.booking.Find(bookingid);
            return movie;
        }
    }
}
