﻿using uszoeb_backend.DTOs;
using uszoeb_backend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace uszoeb_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngatlanController : ControllerBase
    {
        [HttpGet]

        public IActionResult get()
        {
            try
            {
                using (var context = new ingatlanContext())
                {
                    List<IngatlanDTO> results = new List<IngatlanDTO>();
                    var adatok = context.Ingatlanoks.Include(f => f.KategoriaNavigation).ToList();
                    foreach (var item in adatok)
                    {
                        IngatlanDTO result = new IngatlanDTO();
                        result.Id = item.Id;
                        result.Kategoria = item.KategoriaNavigation.Nev;
                        result.Leiras = item.Leiras;
                        result.HirdetesDatuma = item.HirdetesDatuma;
                        result.Tehermentes = item.Tehermentes;
                        result.Ar = item.Ar;
                        result.KepUrl = item.KepUrl;
                        results.Add(result);
                    }
                    return StatusCode(200, results);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(400, ex.Message);
            }
        }

        [HttpPost]

        public IActionResult post(Ingatlanok ingatlan)
        {
            try
            {
                using (var context = new ingatlanContext())
                {
                    context.Ingatlanoks.Add(ingatlan);
                    context.SaveChanges();
                    var adat = context.Ingatlanoks.ToList();
                    return StatusCode(201, $"id: {adat[adat.Count - 1].Id}");
                }
            }
            catch
            {
                return BadRequest("Hiányos adatok");
            }
        }

        [HttpDelete("{id}")]

        public IActionResult post(int id)
        {
            try
            {
                using (var context = new ingatlanContext())
                {
                    Ingatlanok ingatlan = new Ingatlanok();
                    ingatlan.Id = id;
                    context.Ingatlanoks.Remove(ingatlan);
                    context.SaveChanges();
                    return StatusCode(204, "NO CONTENT");
                }
            }
            catch
            {
                return StatusCode(404, "Ingatlan nem létezik");
            }
        }
    }
}