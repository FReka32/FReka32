using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Iskola.Models;

namespace Iskola.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class IskolaController : ControllerBase
    {
        [HttpGet]

        public IActionResult Get()
        {
            using (var context=new iskolaContext())
            {
                try
                {
                    return Ok(context.Iskolaks.ToList());
                }
                catch (Exception ex)
                {
                    return StatusCode(400, ex.Message);
                }
            }
        }
    }
}
