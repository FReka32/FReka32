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
    public class IskolalogokController : ControllerBase
    {
        [HttpDelete("{uid}")]

        public IActionResult Delete(string uid,int id)
        {
            using(var context=new iskolaContext())
            {
                try
                {
                    if (uid == "FEB3F4FEA09CE43E")
                    {
                        Iskolalogok iskolalogo = new Iskolalogok();
                        iskolalogo.Id = id;
                        context.Iskolalogoks.Remove(iskolalogo);
                        context.SaveChanges();
                        return StatusCode(204, "Adatok törlése sikeresen megtörtént.");
                    }
                    else
                    {
                        return StatusCode(200, "Nincs joga!");
                    }
                }
                catch (Exception ex)
                {
                    return StatusCode(401, ex.Message);
                }
            }
        }
    }
}
