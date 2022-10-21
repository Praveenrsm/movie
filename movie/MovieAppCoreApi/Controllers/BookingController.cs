using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using movieBL.services;
using movieentity1;
using System.Collections.Generic;

namespace MovieAppCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private BookingService _movieservice;
        public BookingController(BookingService movieservice)
        {
            _movieservice = movieservice;
        }
        [HttpGet("GetBooking")]
        public IEnumerable<Booking> GetBooking()
        {
            return _movieservice.GetBookings();
        }
        [HttpPost("AddBooking")]
        public IActionResult AddBooking([FromBody] Booking movie)
        {
            _movieservice.AddBooking(movie);
            return Ok("Booking created successfully");
        }
        [HttpDelete("DeleteBooking")]
        public IActionResult DeleteBooking(int BookingId)
        {
            _movieservice.DeleteBooking(BookingId);
            return Ok("Booking deleted successfully");
        }
        [HttpPut("UpdateBooking")]
        public IActionResult UpdateBooking([FromBody] Booking movie)
        {
            _movieservice.UpdateBooking(movie);
            return Ok("Booking updated successfully");
        }
        [HttpGet("GetBookingById")]
        public Booking GetBookingById(int BookingId)
        {
            return _movieservice.GetBookingById(BookingId);
        }
    }
}
