using Microsoft.AspNetCore.Mvc;
using officeBL.services;
using OfficeEntity;

namespace OfficeBoardAPI.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
        public class OfficeController : ControllerBase
        {
            private UserService _userService;
            public OfficeController(UserService userService)
            {
                _userService = userService;
            }
            [HttpPost("Register")]
            public IActionResult Register([FromBody] user users)
            {
                _userService.Register(users);
                return Ok("Register successfully!!");
            }
            [HttpPost("Login")]
            public IActionResult Login([FromBody] user users)
            {
                user user = _userService.Login(users);
                if (user != null)
                    return Ok("Login success!!");
                else
                    return NotFound();
            }
        }
    
}
