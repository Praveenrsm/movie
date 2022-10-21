using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using movieentity1;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MovieCoreMvcUI.Controllers
{
    public class TheatreController : Controller
    {
        private IConfiguration _configuration;
        public TheatreController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IEnumerable<Theatre> movieresult = null;
            using (HttpClient client = new HttpClient())
            {
                string endpoint = _configuration["WebApiBaseUrl"] + "Theatre/GetTheatres";
                using (var response = await client.GetAsync(endpoint))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        movieresult = JsonConvert.DeserializeObject<IEnumerable<Theatre>>(result);
                    }
                }
            }
            return View(movieresult);
        }
        public async Task<IActionResult> EditTheatre(int Id)
        {
            Theatre movieel = null;
            using (HttpClient client = new HttpClient())
            {
                string endpoint = _configuration["WebApiBaseUrl"] + "Theatre/GetTheatreById?TheatreId=" + Id;
                using (var response = await client.GetAsync(endpoint))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        movieel = JsonConvert.DeserializeObject<Theatre>(result);
                    }
                }
            }
            return View(movieel);

        }


        [HttpPost]
        public async Task<IActionResult> EditTheatre(Theatre movie)
        {
            ViewBag.status = "";
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(movie), Encoding.UTF8, "application/json");
                string endpoint = _configuration["WebApiBaseUrl"] + "Theatre/UpdateTheatre";
                using (var response = await client.PutAsync(endpoint, content))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        ViewBag.status = "Ok";
                        ViewBag.message = "Theatre details updated successfully";

                    }
                    else
                    {
                        ViewBag.status = "Error";
                        ViewBag.message = "wrong entity";
                    }
                }
            }
            return View();
        }
        public async Task<IActionResult> DeleteTheatre(int Id)
        {
            MovieEL movieel = null;
            using (HttpClient client = new HttpClient())
            {
                string endpoint = _configuration["WebApiBaseUrl"] + "Theatre/GetTheatreById?TheatreId=" + Id;
                using (var response = await client.GetAsync(endpoint))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        movieel = JsonConvert.DeserializeObject<MovieEL>(result);
                    }
                }
            }
            return View(movieel);

        }
        [HttpPost]
        public async Task<IActionResult> DeleteTheatre(Theatre movieEL)
        {
            ViewBag.status = "";
            using (HttpClient client = new HttpClient())
            {
                string endpoint = _configuration["WebApiBaseUrl"] + "Theatre/DeleteTheatre?TheatreId=" + movieEL.Id;
                using (var response = await client.DeleteAsync(endpoint))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        ViewBag.status = "Ok";
                        ViewBag.message = "Theatre details deleted successfully";

                    }
                    else
                    {
                        ViewBag.status = "Error";
                        ViewBag.message = "wrong entity";
                    }
                }
            }
            return View();
        }
        public IActionResult TheatreEntry()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> TheatreEntry(Theatre theatre)
        {
            ViewBag.status = "";
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(theatre), Encoding.UTF8, "application/json");
                string endpoint = _configuration["WebApiBaseUrl"] + "Theatre/AddTheatre";
                using (var response = await client.PostAsync(endpoint, content))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        ViewBag.status = "Ok";
                        ViewBag.message = "theatre details saved successfully";

                    }
                    else
                    {
                        ViewBag.status = "Error";
                        ViewBag.message = "wrong entity";
                    }
                }
            }
            return View();
        }
    }
}
