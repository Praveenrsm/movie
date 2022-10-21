using movieentity1;
using System;
using System.Collections.Generic;
using System.Text;

namespace movieDataLayer.Repository
{
    public interface IBookingRepository
    {
        void AddBooking(Booking booking);
        void UpdateBooking(Booking booking);
        void DeleteBooking(int bookingid);
        Booking GetBookingById(int bookingid);
        IEnumerable<Booking> GetBookings();
    }
}
