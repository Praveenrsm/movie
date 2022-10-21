using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using movieentity1;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MovieCoreMvcUI.Controllers
{
    public class MovieController : Controller
    {
        private IConfiguration _configuration;
        public MovieController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IEnumerable<MovieEL> movieresult= null;
            using (HttpClient client = new HttpClient())
            {
                string endpoint = _configuration["WebApiBaseUrl"] + "Movie/GetMovies";
                using (var response = await client.GetAsync(endpoint))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var result=await response.Content.ReadAsStringAsync();
                        movieresult=JsonConvert.DeserializeObject<IEnumerable<MovieEL>>(result);    
                    }
                }
            }
                return View(movieresult);
        }

        public async Task<IActionResult> EditMovie(int Id)
        {
            MovieEL movieel = null;
            using (HttpClient client = new HttpClient())
            {
                string endpoint = _configuration["WebApiBaseUrl"] + "Movie/GetMovieById?movieId="+Id;
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
        public async Task<IActionResult> EditMovie(MovieEL movie)
        {
            ViewBag.status = "";
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(movie), Encoding.UTF8, "application/json");
                string endpoint = _configuration["WebApiBaseUrl"] + "Movie/UpdateMovie";
                using (var response = await client.PutAsync(endpoint,content))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        ViewBag.status = "Ok";
                        ViewBag.message = "Movie details updated successfully";

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
        public async Task<IActionResult> DeleteMovie(int Id)
        {
            MovieEL movieel = null;
            using (HttpClient client = new HttpClient())
            {
                string endpoint = _configuration["WebApiBaseUrl"] + "Movie/GetMovieById?movieId=" + Id;
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
        public async Task<IActionResult> DeleteMovie(MovieEL movieEL)
        {
            ViewBag.status = "";
            using (HttpClient client = new HttpClient())
            {
                string endpoint = _configuration["WebApiBaseUrl"] + "Movie/DeleteMovie?movieId=" +movieEL.Id;
                using (var response = await client.DeleteAsync(endpoint))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        ViewBag.status = "Ok";
                        ViewBag.message = "Movie details deleted successfully";

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
        public IActionResult MovieEntry()
        {
            //List<SelectListItem> language = new List<SelectListItem>()
            //{
            //    new SelectListItem{Value="Select",Text="select"},
            //    new SelectListItem{Value="Tamil",Text="Tamil"},
            //    new SelectListItem{Value="English",Text="English"},
            //    new SelectListItem{Value="Kannada",Text="Kannada"},
            //};
            //ViewBag.languagelist = language;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> MovieEntry(MovieEL movie)
        {
            ViewBag.status = "";
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(movie), Encoding.UTF8, "application/json");
                string endpoint = _configuration["WebApiBaseUrl"] + "Movie/AddMovie";
                using (var response = await client.PostAsync(endpoint, content))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        ViewBag.status = "Ok";
                        ViewBag.message = "Movie details saved successfully";

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
