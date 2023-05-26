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
    public class ProductController : ControllerBase
    {
            [HttpGet]

            public IActionResult Get()
            {
                using (var context = new vizsgaremek_v4Context())
                {
                    try
                    {
                        var products = new List<Product>(context.Products);
                        return Ok(products);
                    }
                    catch (Exception ex)
                    {
                        return BadRequest(ex.Message);
                    }
                }
            }

            [HttpGet("{PrId}")]

            public IActionResult Get(int PrId)
            {
                using (var context = new vizsgaremek_v4Context())
                {
                    try
                    {
                        var products = new List<Product>(context.Products);
                        var selection = products.FirstOrDefault(a => a.PrId == PrId);
                        return Ok(selection);
                    }
                    catch (Exception ex)
                    {
                        return BadRequest(ex.Message);
                    }

                }
            }
            [HttpPost]

            public IActionResult Post(ProductRequestDto productrequest)
            {
                using (var context = new vizsgaremek_v4Context())
                {
                    try
                    {
                        Product product = new Product();
                        product.PrName = productrequest.PrName;
                        product.PrOther = productrequest.PrOther;
                        product.PrUrl = productrequest.PrUrl;
                        product.PrActive = productrequest.PrActive;
                        product.PrPrice = productrequest.PrPrice;
                        context.Products.Add(product);
                        context.SaveChanges();
                        return Ok("Add product ok.");
                    }
                    catch (Exception ex)
                    {
                        return BadRequest(ex.Message);
                    }

                }
            }
            [HttpPut("{PrId}")]

            public IActionResult Put(int PrId, ProductRequestDto productupdate)
            {
                using (var context = new vizsgaremek_v4Context())
                {
                    try
                    {
                        Product product = context.Products.First(a => a.PrId == PrId);
                        product.PrName = productupdate.PrName;
                        product.PrOther = productupdate.PrOther;
                        product.PrUrl = productupdate.PrUrl;
                        product.PrActive = productupdate.PrActive;
                        product.PrPrice = productupdate.PrPrice;
                        context.Update(product);
                        context.SaveChanges();
                        return Ok("Product modification ok.");
                    }
                    catch (Exception ex)
                    {
                        return BadRequest(ex.Message);
                    }

                }
            }
            [HttpDelete("{prid}")]

            public IActionResult Delete(int prid)
            {
                using (var context = new vizsgaremek_v4Context())
                {
                    try
                    {
                        Product product = context.Products.First(product => product.PrId == prid);
                        context.Products.Remove(product);
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
