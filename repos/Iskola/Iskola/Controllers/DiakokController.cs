using Iskola.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Iskola.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DiakokController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            using(var context = new iskolaContext())
            {
                try
                {
                    return StatusCode(201, context.Diakoks.ToList());
                }
                catch (Exception ex)
                {

                    return BadRequest(ex.Message);
                }
            }
        }

        [HttpPost]

        public IActionResult Post(Diakok diak)
        {
            using(var context = new iskolaContext())
            {
                try
                {
                    context.Diakoks.Add(diak);
                    context.SaveChanges();
                    return StatusCode(201, "A diák adatainak rögzítése sikeresen megtörtént");
                }
                catch (Exception ex)
                {
                    return StatusCode(401, ex.Message);
                }
            }
        }
    }
}
