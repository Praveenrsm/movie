using Microsoft.AspNetCore.Mvc;
using movieBL.services;
using movieentity1;

namespace MovieAppCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        
        
            private AdminService _adminService;
            public AdminController(AdminService adminService)
            {
                _adminService = adminService;
            }
            [HttpPost("Register")]
            public IActionResult Register([FromBody] Admin admins)
            {
                _adminService.Register(admins);
                return Ok("Register successfully!!");
            }
            [HttpPost("Login")]
            public IActionResult Login([FromBody] Admin admins)
            {
               Admin admin = _adminService.Login(admins);
                if (admin != null)
                    return Ok("Login success!!");
                else
                    return NotFound();
            }
        }
    }

