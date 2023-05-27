using Kerenyi_Robert_backend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Kerenyi_Robert_backend.Controllers
{
    [Route("api/")]
    [ApiController]
    public class VersenyzokController : ControllerBase
    {
        static string UID = "FEB3F4FEA09CE43E";

        [HttpGet]
        [Route("GetVersenyzoNev")]
        public IActionResult GetVersenyzoNev(string nev)
        {
            using (var context=new uszoebContext())
            {
                try
                {
                    return Ok(context.Versenyzoks.Include(f => f.Orszag).Include(f => f.Szamoks).FirstOrDefault(f => f.Nev == nev));
                }
                catch (Exception ex)
                {
                    //return BadRequest(ex.Message);
                    return StatusCode(400, ex.Message);
                }
            }
        }

        [HttpGet]
        [Route("GetVersenyzokSzama")]
        public IActionResult GetVersenyzokSzama()
        {
            using (var context = new uszoebContext())
            {
                try
                {
                    return Ok(context.Versenyzoks.Count());
                }
                catch (Exception ex)
                {
                    //return BadRequest(ex.Message);
                    return StatusCode(400, ex.Message);
                }
            }
        }

        [HttpPost]
        [Route("AddVersenyzo")]
        public IActionResult AddVersenyzo(Versenyzok versenyzo,string uId)
        {
            using (var context = new uszoebContext())
            {
                if (UID == uId)
                {
                    try
                    {
                        context.Versenyzoks.Add(versenyzo);
                        context.SaveChanges();
                        return StatusCode(201,"A versenyző hozzáadása sikeresen megtörtént.");
                    }
                    catch (Exception ex)
                    {
                        //return BadRequest(ex.Message);
                        return StatusCode(400, ex.Message);
                    }
                }
                else
                {
                    //return Unauthorized("Nincs jogosultsága új versenyző felvételéhez!");
                    return StatusCode(401,"Nincs jogosultsága új versenyző felvételéhez!");
                }
            }
        }

        [HttpPut]
        [Route("UpdateVersenyzo")]
        public IActionResult UpdateVersenyzo(Versenyzok versenyzo, string uId)
        {
            using (var context = new uszoebContext())
            {
                if (UID == uId)
                {
                    try
                    {
                        context.Versenyzoks.Update(versenyzo);
                        context.SaveChanges();
                        return StatusCode(200, "A versenyző adatainak a módosítása sikeresen megtörtént.");
                    }
                    catch (Exception ex)
                    {
                        //return BadRequest(ex.Message);
                        return StatusCode(400, ex.Message);
                    }
                }
                else
                {
                    //return Unauthorized("Nincs jogosultsága új versenyző felvételéhez!");
                    return StatusCode(401, "Nincs jogosultsága új versenyző adatainak a módosításához!");
                }
            }
        }

        [HttpDelete]
        [Route("DeleteVersenyzo")]
        public IActionResult DeleteVersenyzo(int id, string uId)
        {
            using (var context = new uszoebContext())
            {
                if (UID == uId)
                {
                    try
                    {
                        Versenyzok versenyzo = new Versenyzok();
                        versenyzo.Id = id;
                        context.Versenyzoks.Remove(versenyzo);
                        context.SaveChanges();
                        return StatusCode(204, "A versenyző adatainak a törlése sikeresen megtörtént.");
                    }
                    catch (Exception ex)
                    {
                        //return BadRequest(ex.Message);
                        return StatusCode(400, ex.Message);
                    }
                }
                else
                {
                    //return Unauthorized("Nincs jogosultsága új versenyző felvételéhez!");
                    return StatusCode(401, "Nincs jogosultsága új versenyző adatainak a módosításához!");
                }
            }
        }

    }
}
