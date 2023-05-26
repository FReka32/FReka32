using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoPiac.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LogoutController : ControllerBase
    {
        [HttpPost("{uId}")]

        public IActionResult Post(string uId)
        {
            if (Program.LoggedInUsers.ContainsKey(uId))
            {
                Program.LoggedInUsers.Remove(uId);
                return StatusCode(200,"Sikeres kijelentkezés.");
            }
            else
            {
                return BadRequest("Sikertelen kijelentkezés!");
            }
        }
    }
}
