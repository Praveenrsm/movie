using Microsoft.AspNetCore.Mvc;
using ProductBL.Services;
using ProductEntity;
using System.Collections.Generic;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SizeController : Controller
    {
        private SizeService _sizeservice;
        public SizeController(SizeService articleservice)
        {
            _sizeservice = articleservice;
        }
        [HttpGet("GetSize")]
        public IEnumerable<Size> GetSize()
        {
            return _sizeservice.GetSizes();
        }
        [HttpPost("AddSize")]
        public IActionResult AddSize([FromBody] Size art)
        {
            _sizeservice.AddSize(art);
            return Ok("Size created successfully");
        }
        [HttpDelete("DeleteSize")]
        public IActionResult DeleteSize(int SizeId)
        {
            _sizeservice.DeleteSize(SizeId);
            return Ok("Size deleted successfully");
        }
        [HttpPut("UpdateSize")]
        public IActionResult UpdateSize([FromBody] Size art)
        {
            _sizeservice.UpdateSize(art);
            return Ok("Size updated successfully");
        }
        [HttpGet("GetSizeById")]
        public Size GetSizeById(int SizeId)
        {
            return _sizeservice.GetSizeById(SizeId);
        }

    }
}
