using movieDataLayer.Repository;
using movieentity1;
using System;
using System.Collections.Generic;
using System.Text;

namespace movieBL.services
{
    public class BookingService
    {

        IBookingRepository _movieRepository;
        public BookingService(IBookingRepository movieRepository)
        {
            this._movieRepository = movieRepository;
        }
        public void AddBooking(Booking movie)
        {
            _movieRepository.AddBooking(movie);
        }
        public void UpdateBooking(Booking movie)
        {
            _movieRepository.UpdateBooking(movie);
        }
        public void DeleteBooking(int BookingId)
        {
            _movieRepository.DeleteBooking(BookingId);
        }
        //get movie by id
        public Booking GetBookingById(int BookingId)
        {
          return  _movieRepository.GetBookingById(BookingId);
        }
        //get movies
        public IEnumerable<Booking> GetBookings()
        {
            return _movieRepository.GetBookings();
        }
    }
}
