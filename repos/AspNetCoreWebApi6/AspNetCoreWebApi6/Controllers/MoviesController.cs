using AspNetCoreWebApi6.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreWebApi6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly MovieContext _dbContext;

        public MoviesController(MovieContext dbContext) 
        {
            _dbContext = dbContext;
        }

        // GET api/Movies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie>>> GetMovies()
        {
            if(_dbContext.Movies == null)
            {
                return NotFound();
            }
            return await _dbContext.Movies.ToListAsync();
        }

    }
}
