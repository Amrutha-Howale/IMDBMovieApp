using IMDBapp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMDBapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly MovieContext _context;

        public MovieController(MovieContext context)
        {
            _context = context;
        }

        // Get api/<MovieController>
        [HttpGet("GetMovie")]
        public List<Movies> Get()
        {
            var movies = _context.movies.ToList();
            return movies;
        }

        // POST api/<MovieController>
        [HttpPost, Route("createMovies")]
        public async Task<IActionResult> Post([FromBody] Movies movies)
        {
            _context.movies.Add(movies);
            await _context.SaveChangesAsync();
            return Ok();
        }

        // PUT api/<MovieController>
        [Route("EditMovies")]
        [HttpPut]
        public async Task<IActionResult> EditMovies(int id, Movies movies)
        {
            _context.Entry(movies).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
