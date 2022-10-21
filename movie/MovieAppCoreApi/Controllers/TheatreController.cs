using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using movieBL.services;
using movieentity1;
using System.Collections.Generic;
using TheatreBL.services;

namespace MovieAppCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TheatreController : ControllerBase
    {
            private TheatreService _theatreservice;
            public TheatreController(TheatreService theatreservice)
            {
                _theatreservice = theatreservice;
            }
            [HttpGet("GetTheatres")]
            public IEnumerable<Theatre> GetTheatres()
            {
                return _theatreservice.GetTheatres();
            }
            [HttpPost("AddTheatre")]
            public IActionResult AddTheatre([FromBody] Theatre theatre)
            {
                _theatreservice.AddTheatre(theatre);
                return Ok("theatre created successfully");
            }
            [HttpDelete("DeleteTheatre")]
            public IActionResult DeleteTheatre(int theatreid)
            {
                _theatreservice.DeleteTheatre(theatreid);
                return Ok("theatre deleted successfully!!!");
            }
            [HttpPut("UpdateTheatre")]
            public IActionResult UpdateTheatre([FromBody] Theatre theatre)
            {
                _theatreservice.UpdateTheatre(theatre);
                return Ok("theatre updated successfully");
            }
        [HttpGet("GetTheatreById")]
        public Theatre GetTheatreById(int movieId)
        {
            return _theatreservice.GetTheatreById(movieId);
        }
    }
    }

