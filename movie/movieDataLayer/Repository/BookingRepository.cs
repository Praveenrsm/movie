using Microsoft.EntityFrameworkCore;
using movieentity1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace movieDataLayer.Repository
{
    public class BookingRepository:IBookingRepository
    {
        MovieContext _movieDbcontext;
        public BookingRepository(MovieContext context)
        {
            this._movieDbcontext = context;
        }
        public void AddBooking(Booking movie)
        {
            _movieDbcontext.booking.Add(movie);
            _movieDbcontext.SaveChanges();
        }
        public void DeleteBooking(int movieId)
        {
            var movie = _movieDbcontext.booking.Find(movieId);
            _movieDbcontext.booking.Remove(movie);
            _movieDbcontext.SaveChanges();
        }
        public IEnumerable<Booking> GetBookings()
        {
            return _movieDbcontext.booking.ToList();
        }
        public Booking GetBookingById(int bookingid)
        {
            return _movieDbcontext.booking.Find(bookingid);
        }
        public void UpdateBooking(Booking movie)
        {
            _movieDbcontext.Entry(movie).State = EntityState.Modified;
            _movieDbcontext.SaveChanges();
        }

    }
}
