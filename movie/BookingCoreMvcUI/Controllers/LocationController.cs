using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using movieentity1;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BookingCoreMvcUI.Controllers
{
    public class LocationController : Controller
    {
        private IConfiguration _configuration;
        public LocationController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IEnumerable<Location> movieresult = null;
            using (HttpClient client = new HttpClient())
            {
                string endpoint = _configuration["WebApiBaseUrl"] + "Location/GetLocation";
                using (var response = await client.GetAsync(endpoint))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        movieresult = JsonConvert.DeserializeObject<IEnumerable<Location>>(result);
                    }
                }
            }
            return View(movieresult);
        }

        public async Task<IActionResult> EditLocation(int Id)
        {
            Location movieel = null;
            using (HttpClient client = new HttpClient())
            {
                string endpoint = _configuration["WebApiBaseUrl"] + "Location/GetLocationById?LocationId=" + Id;
                using (var response = await client.GetAsync(endpoint))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        movieel = JsonConvert.DeserializeObject<Location>(result);
                    }
                }
            }
            return View(movieel);

        }


        [HttpPost]
        public async Task<IActionResult> EditLocation(Location locations)
        {
            ViewBag.status = "";
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(locations), Encoding.UTF8, "application/json");
                string endpoint = _configuration["WebApiBaseUrl"] + "Location/UpdateLocation";
                using (var response = await client.PutAsync(endpoint, content))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        ViewBag.status = "Ok";
                        ViewBag.message = "Location details updated successfully";
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
        public async Task<IActionResult> DeleteLocation(int Id)
        {
            Location movieel = null;
            using (HttpClient client = new HttpClient())
            {
                string endpoint = _configuration["WebApiBaseUrl"] + "Location/GetLocationById?LocationId=" + Id;
                using (var response = await client.GetAsync(endpoint))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        movieel = JsonConvert.DeserializeObject<Location>(result);
                    }
                }
            }
            return View(movieel);

        }
        [HttpPost]
        public async Task<IActionResult> DeleteLocation(Location locations)
        {
            ViewBag.status = "";
            using (HttpClient client = new HttpClient())
            {
                string endpoint = _configuration["WebApiBaseUrl"] + "Location/DeleteLocation?LocationId=" + locations.Id;
                using (var response = await client.DeleteAsync(endpoint))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        ViewBag.status = "Ok";
                        ViewBag.message = "Location details deleted successfully";
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
        public IActionResult LocationEntry()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LocationEntry(Location location1)
        {

            ViewBag.status = "";
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(location1), Encoding.UTF8, "application/json");
                string endpoint = _configuration["WebApiBaseUrl"] + "Location/AddLocation";
                using (var response = await client.PostAsync(endpoint, content))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        ViewBag.status = "Ok";
                        ViewBag.message = "Location details saved successfully";

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
