using Iskola.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Iskola.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class IskolaController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            using(var context=new iskolaContext())
            {
                try
                {
                    return Ok(context.Iskolaks.ToList());
                }
                catch(Exception ex)
                {
                    return StatusCode(400,ex.Message);
                }
            }
        }
    }
}
