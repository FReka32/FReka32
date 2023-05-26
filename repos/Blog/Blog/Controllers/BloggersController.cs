using Blog.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BloggersController : ControllerBase
    {
        private readonly BloggerContext _dbContext;
        public BloggersController(BloggerContext dbContext)
        {
            _dbContext = dbContext;
        }

        //GET: api/Posts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Blogger>>> GetBloggers()
        {
            if(_dbContext.Bloggers == null)
            {
                return NotFound();
            }
            return await _dbContext.Bloggers.ToListAsync();
        }
    }
}
