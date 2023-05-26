using FadokoBackendV4.Models;
using FadokoBackendV4.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FadokoBackendV4.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        [HttpGet]

        public IActionResult Get()
        {
            using (var context = new vizsgaremek_v4Context())
            {
                try
                {
                    var admins = new List<Admin>(context.Admins).Select(admin => new AdminDto()
                    {
                        AdId = admin.AdId,
                        AdName = admin.AdName,
                        AdPermission = admin.AdPermission,
                        AdEmail = admin.AdEmail,
                        AdPhone = admin.AdPhone,
                        Active = admin.Active
                    });
                    return Ok(admins);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }

            }
        }

        [HttpGet("{AdId}")]

        public IActionResult Get(int AdId)
        {
            using (var context = new vizsgaremek_v4Context())
            {
                try
                {
                    var admins = new List<Admin>(context.Admins).Select(admin => new AdminDto()
                    {
                        AdId = admin.AdId,
                        AdName = admin.AdName,
                        AdPermission = admin.AdPermission,
                        AdEmail = admin.AdEmail,
                        AdPhone = admin.AdPhone,
                        Active = admin.Active
                    });
                    var selection = admins.FirstOrDefault(a => a.AdId == AdId);
                    return Ok(selection);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }

            }
        }
        [HttpPost]

        public IActionResult Post(AdminRequestDto adminrequest)
        {
            using (var context = new vizsgaremek_v4Context())
            {
                try
                {
                    Admin admin = new Admin();
                    admin.AdName = adminrequest.AdName;
                    admin.AdPermission = adminrequest.AdPermission;
                    admin.AdEmail = adminrequest.AdEmail;
                    admin.AdPhone = adminrequest.AdPhone;
                    admin.Active = adminrequest.Active;
                    admin.Hash = adminrequest.Hash;
                    admin.Salt = adminrequest.Salt;
                    context.Admins.Add(admin);
                    context.SaveChanges();
                    return Ok("Add admin ok.");
                }
                catch (Exception ex)
                {
                    return BadRequest("ADMIN POST ERROR: "+ex.Message);
                }

            }
        }
        [HttpPut("{AdId}")]

        public IActionResult Put(int AdId, AdminRequestDto adminupdate)
        {
            using (var context = new vizsgaremek_v4Context())
            {
                try
                {
                    Admin admin = context.Admins.First(a => a.AdId == AdId);
                    admin.AdName = adminupdate.AdName;
                    admin.AdPermission = adminupdate.AdPermission;
                    admin.AdEmail = adminupdate.AdEmail;
                    admin.AdPhone = adminupdate.AdPhone;
                    admin.Active = adminupdate.Active;
                    admin.Hash = adminupdate.Hash;
                    admin.Salt = adminupdate.Salt;
                    context.Update(admin);
                    context.SaveChanges();
                    return Ok("User modification ok.");
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }

            }
        }
        [HttpDelete("{adid}")]

        public IActionResult Delete(int adid)
        {
            using (var context = new vizsgaremek_v4Context())
            {
                try
                {
                    Admin admin = context.Admins.First(admin => admin.AdId == adid);
                    context.Admins.Remove(admin);
                    context.SaveChanges();
                    return Ok("Delete ok.");
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }

            }
        }
    }
}
