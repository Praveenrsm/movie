using Microsoft.AspNetCore.Mvc;
using ProductBL.Services;
using ProductEntity;
using System.Collections.Generic;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColourController : ControllerBase
    {
        private ColourService _colourservice;
        public ColourController(ColourService colourservice)
        {
            _colourservice = colourservice;
        }
        [HttpGet("GetColour")]
        public IEnumerable<Colour> GetColours()
        {
            return _colourservice.GetColours();
        }
        [HttpPost("AddColour")]
        public IActionResult AddColour([FromBody] Colour col)
        {
            _colourservice.AddColour(col);
            return Ok("Colour created successfully");
        }
        [HttpDelete("DeleteColour")]
        public IActionResult DeleteColour(int ColourId)
        {
            _colourservice.DeleteColour(ColourId);
            return Ok("Colour deleted successfully");
        }
        [HttpPut("UpdateColour")]
        public IActionResult UpdateColour([FromBody] Colour col)
        {
            _colourservice.UpdateColour(col);
            return Ok("Colour updated successfully");
        }
        [HttpGet("GetColourById")]
        public Colour GetColourById(int ColourId)
        {
            return _colourservice.GetColourById(ColourId);
        }
    }
}
