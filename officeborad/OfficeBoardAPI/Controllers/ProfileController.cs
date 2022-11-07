using Microsoft.AspNetCore.Mvc;
using officeBL.services;
using OfficeEntity;

namespace OfficeBoardAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private EditProfileServices _editprofileservice;
        public ProfileController(EditProfileServices editprofileservice)
        {
            _editprofileservice = editprofileservice;
        }
        [HttpPut("UpdateProfile")]
        public IActionResult UpdateProfile([FromBody] Profile profile)
        {
            _editprofileservice.UpdateProfile(profile);
            return Ok("Booking updated successfully");
        }
    }
}
