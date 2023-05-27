using AutoPiac.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace AutoPiac.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FelhasznaloController : ControllerBase
    {
        [HttpGet("{uId}")]
        public IActionResult Get(string uId)
        {
            if(Program.LoggedInUsers.ContainsKey(uId) && Program.LoggedInUsers[uId].Jogosultsag == 9)
                {
                using (var context = new autopiacContext())
                {
                    try
                    {
                        var felhasznalo = new List<Felhasznalo>(context.Felhasznalos);
                        return Ok(felhasznalo);
                    }
                    catch ( Exception ex)
                    {
                        return BadRequest(ex.Message);
                    }
                }
            }
            else
            {
                return BadRequest("Nincs bejelentkezve/jogosultsága!");
            }
        }

        [HttpPost("{uId}")]
        public IActionResult Post(string uId, Felhasznalo felhasznalo)
        {
            if (Program.LoggedInUsers.ContainsKey(uId) && Program.LoggedInUsers[uId].Jogosultsag == 9)
            {
                using (var context = new autopiacContext())
                {
                    try
                    {
                        context.Felhasznalos.Add(felhasznalo);
                        context.SaveChanges();
                        return Ok("Felhasználó sikeresen hozzáadva!");
                    }
                    catch (Exception ex)
                    {
                        return BadRequest(ex.Message);
                    }
                }
            }
            else
            {
                return BadRequest("Nincs bejelentkezve/jogosultsága!");
            }
        }


        [HttpPut("{uId}")]
        public IActionResult Put(string uId, Felhasznalo felhasznalo)
        {
            if (Program.LoggedInUsers.ContainsKey(uId) && Program.LoggedInUsers[uId].Jogosultsag == 9)
            {
                using (var context = new autopiacContext())
                {
                    try
                    {
                        context.Felhasznalos.Update(felhasznalo);
                        context.SaveChanges();
                        return Ok("Felhasználó sikeresen módosítva!");
                    }
                    catch (Exception ex)
                    {
                        return BadRequest(ex.Message);
                    }
                }
            }
            else
            {
                return BadRequest("Nincs bejelentkezve/jogosultsága!");
            }
        }

        [HttpDelete("{uId}")]
        public IActionResult Delete(string uId, int id )
        {
            if (Program.LoggedInUsers.ContainsKey(uId) && Program.LoggedInUsers[uId].Jogosultsag == 9)
            {
                using (var context = new autopiacContext())
                {
                    try
                    {
                        Felhasznalo felhasznalo = new Felhasznalo();
                        felhasznalo.Id = id;
                        context.Felhasznalos.Remove(felhasznalo);
                        context.SaveChanges();
                        return Ok("Felhasználó sikeresen törölve!");
                    }
                    catch (Exception ex)
                    {
                        return BadRequest(ex.Message);
                    }
                }
            }
            else
            {
                return BadRequest("Nincs bejelentkezve/jogosultsága!");
            }
        }

    }
}
