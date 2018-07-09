using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IntroToWebAPI.Models;

namespace IntroToWebAPI.Controllers
{
    [Produces("application/xml")]
    [Route("api/Products")]
    public class ProductsController : Controller
    {
        private static List<Product> ProductList = new List<Product>()
        {
            new Product(){ID = 1, Name = "Mouse", Quantity=1},
            new Product(){ID = 2, Name = "Bottle", Quantity=1},
            new Product(){ID = 3, Name = "Speakers", Quantity=1},
            new Product(){ID = 4, Name = "Paise", Quantity=1}
        };

        //[HttpGet]
        //public string Get() => "Hello CJ from Web API";

        [HttpGet]
        public List<Product> Get()
        {
            return ProductList;
        }

        //[HttpGet("{id}")]
        //public Product Get(int id)
        //{
        //    return ProductList.SingleOrDefault(p => p.ID == id);
        //}

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = ProductList.SingleOrDefault(p => p.ID == id);
            if (product == null)
            {
                return this.NotFound("Data Not Aviable");
            }

            return this.Ok(product); 
        }

        // Need to work on
        //[HttpGet("/GetList")]
        //public List<Product> GetList()
        //{
        //    return ProductList;
        //}

        [HttpPost]
        [Consumes("application/json")]
        public IActionResult Post(
            [FromBody]
            Product product)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest("Model Data is Invalid");
            }

            ProductList.Add(product);
            return CreatedAtAction(nameof(Get),
                    new { id = product.ID }, product
                   );
        }
    }
}