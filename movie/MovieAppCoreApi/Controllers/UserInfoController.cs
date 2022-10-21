using Microsoft.AspNetCore.Mvc;
using movieBL.services;
using movieentity1;

namespace MovieAppCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserInfoController : ControllerBase
    {
        private UserInfoService _userInfoService;
        public UserInfoController(UserInfoService userInfoService)
        {
            _userInfoService = userInfoService;
        }
        [HttpPost("Register")]
        public IActionResult Register([FromBody] UserInfo userInfo)
        {
            _userInfoService.Register(userInfo);
            return Ok("Register successfully!!");
        }
        [HttpPost("Login")]
        public IActionResult Login([FromBody] UserInfo userInfo)
        {
            UserInfo user = _userInfoService.Login(userInfo);
            if (user != null)
                return Ok("Login success!!");
            else
                return NotFound();
        }
    }
}
