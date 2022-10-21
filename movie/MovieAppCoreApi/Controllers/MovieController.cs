using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using movieentity1;
using movieBL.services;
using Microsoft.AspNetCore.Authorization;

namespace MovieAppCoreApi.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private MovieService _movieservice;
        public MovieController(MovieService movieservice)
        {
            _movieservice = movieservice;
        }
        [HttpGet("GetMovies")]
        public IEnumerable<MovieEL> GetMovies()
        {
            return _movieservice.GetMovies();
        }
        [HttpGet("GetMovieById")]
        public MovieEL GetMovieById(int movieId)
        {
            return _movieservice.GetMovieById(movieId);
        }
        [HttpPost("AddMovie")]
        public IActionResult AddMovie([FromBody] MovieEL movie)
        {
            _movieservice.AddMovie(movie);
            return Ok("movie created successfully");
        }
        [HttpDelete("DeleteMovie")]
        public IActionResult DeleteMovie(int movieId)
        {
            _movieservice.DeleteMovie(movieId);
            return Ok("Movie deleted successfully!!!");
        }
        [HttpPut("UpdateMovie")]
        public IActionResult UpdateMovie([FromBody] MovieEL movie)
        {
            _movieservice.UpdateMovie(movie);
            return Ok("movie updated successfully");
        }
    }
}