using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using introAspNetModule3.Models;

namespace introAspNetModule3.Controllers
{
    public class TicketsController : Controller
    {
        //[HttpGet("/")]
        //public string Index() => "Hello from Cj's Movies";

        //[HttpGet("/tix")]
        //public string Index() => "Hello from Cj's Movies";

        ////http://localhost/tix
        //[HttpGet("/tix")]
        //public IActionResult Index()
        //{
        //    //Content return Content Results
        //    return Content("Hello from CJ's Movies");
        //}

        ////http://localhost/tix2
        //[HttpGet("/tix2")]
        //public string Index2()
        //{
        //    //This will also return same as Index
        //    return "Hello from CJ's Movies";
        //}

        [HttpGet("/tix")]
        public IActionResult Index()
        {
            // GO to Database
            // GET Some Models
            var seatData = new Seat()
            {
                Location = "Mumbai",
                Price = 500.00
            };

            return View(seatData); 
            // Error till the time we don't create new view
            // View Name should be similar to Action Method
        }
    }
}