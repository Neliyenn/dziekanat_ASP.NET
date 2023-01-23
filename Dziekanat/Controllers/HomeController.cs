using Dziekanat.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
namespace Dziekanat.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        [HttpGet]
        [Route("Ogloszenia")]
        public IActionResult Ogloszenia()
        {
            return View();
        }
        [HttpGet]
        [Route("Plan_Zajec")]
        public IActionResult Plan_Zajec()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}