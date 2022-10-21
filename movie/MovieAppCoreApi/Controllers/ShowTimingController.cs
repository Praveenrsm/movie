using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using movieBL.services;
using movieentity1;
using System.Collections.Generic;

namespace MovieAppCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowTimingController : ControllerBase
    {
        private ShowTimingService _showtimingservice;
        public ShowTimingController(ShowTimingService showtimingservice)
        {
            _showtimingservice = showtimingservice;
        }
        [HttpGet("GetShowTiming")]
        public IEnumerable<ShowTiming> GetShowTimings()
        {
            return _showtimingservice.GetShowTimings();
        }
        [HttpPost("AddShowTiming")]
        public IActionResult AddShowTiming([FromBody] ShowTiming showtiming)
        {
            _showtimingservice.AddShowTiming(showtiming);
            return Ok("show timing created successfully");
        }
        [HttpDelete("DeleteShowTiming")]
        public IActionResult DeleteShowTiming(int showtimingid)
        {
            _showtimingservice.DeleteShowTiming(showtimingid);
            return Ok("show timing deleted successfully!!!");
        }
        [HttpPost("UpdateShowTiming")]
        public IActionResult UpdateShowTiming([FromBody] ShowTiming showtiming)
        {
            _showtimingservice.UpdateShowTiming(showtiming);
            return Ok("show timing updated successfully");
        }
    }
}
