using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ViewResult Index()
        {
            // return View("~/TempView/JanviTemp.cshtml");  // For calling the other location which is not available in Views folder

             return View(); // If i write this way, then it return Home page index.cshtml
            // return View("ContactUS"); // but if i written this way, then it's return comntactus page ;)

            //var obj = new { Id = 1, name = "Janvi" };
            //return View("ContactUs" ,obj);
        }
        
        public ViewResult AboutUs()
        {
            return View();
        }
    }
}
