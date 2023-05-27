using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Iskola.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DiakokController : ControllerBase
    {
        [HttpGet]

        public IActionResult Get()
        {
            using(var context=new Iskola.Models.iskolaContext())
            {
                try
                {
                    return StatusCode(201,context.Diakoks.ToList());
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
        }

        [HttpPost]

        public IActionResult Post(Iskola.Models.Diakok diak)
        {
            using(var context=new Iskola.Models.iskolaContext())
            {
                try
                {
                    context.Diakoks.Add(diak);
                    context.SaveChanges();
                    return StatusCode(201,"A diák adatainak a rögzitése sikeresen megtörtént");
                }
                catch (Exception ex)
                {
                    return StatusCode(401, ex.Message);
                }
            }
        }
    }
}
