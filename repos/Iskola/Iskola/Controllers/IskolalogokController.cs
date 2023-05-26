using Iskola.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Iskola.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class IskolalogokController : ControllerBase
    {
        [HttpDelete("{uid}")]
        public IActionResult Delete(string uid, int id)
        {
            using(var context = new iskolaContext())
            {
                try {
                    if( uid == "FEB3F4FEA09CE43E")
                    {
                        Iskolalogok log = new Iskolalogok();
                        log.Id= id;
                        context.Iskolalogoks.Remove(log);
                        context.SaveChanges();
                        return StatusCode(204, "Az adatok törlése sikeresen megtörtént");
                    }
                    else
                    {
                        return StatusCode(205, "Nincs jogosultsága!");
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
