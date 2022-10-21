using Microsoft.AspNetCore.Mvc;

namespace MovieAppCoreApi.Controllers
{
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
