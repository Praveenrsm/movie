using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using movieBL.services;
using movieentity1;
using System.Collections.Generic;

namespace MovieAppCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private LocationService _movieservice;
        public LocationController(LocationService movieservice)
        {
            _movieservice = movieservice;
        }
        [HttpGet("GetLocation")]
        public IEnumerable<Location> GetLocation()
        {
            return _movieservice.GetLocations();
        }
        [HttpPost("AddLocation")]
        public IActionResult AddLocation([FromBody] Location movie)
        {
            _movieservice.AddLocation(movie);
            return Ok("Location created successfully");
        }
        [HttpDelete("DeleteLocation")]
        public IActionResult DeleteLocation(int LocationId)
        {
            _movieservice.DeleteLocation(LocationId);
            return Ok("Location deleted successfully!!!");
        }
        [HttpPost("UpdateLocation")]
        public IActionResult UpdateLocation([FromBody] Location movie)
        {
            _movieservice.UpdateLocation(movie);
            return Ok("Location updated successfully");
        }
    }
}
