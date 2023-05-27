using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PiacListaAPI.Models;

namespace PiacListaAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GyumolcsController : ControllerBase
    {
        public static List<Gyumolcs> gyumolcsok = new List<Gyumolcs>();
        
        [HttpGet]

        public IActionResult GetGyumolcsok()
        {
            Gyumolcs gyumolcs1 = new Gyumolcs();
            gyumolcs1.Id = 1;
            gyumolcs1.Nev = "Piros alma";
            gyumolcs1.Ar = 750;
            gyumolcs1.Minoseg = 2;
            gyumolcs1.KepUtvonala = "img/pirosalma.jpg";

            Gyumolcs gyumolcs2 = new Gyumolcs();
            gyumolcs2.Id = 2;
            gyumolcs2.Nev = "Vilmos körte";
            gyumolcs2.Ar = 950;
            gyumolcs2.Minoseg = 1;
            gyumolcs2.KepUtvonala = "img/vilmoskorte.jpg";

            gyumolcsok.Add(gyumolcs1);
            gyumolcsok.Add(gyumolcs2);
            return Ok(gyumolcsok);
        }
    }
}
