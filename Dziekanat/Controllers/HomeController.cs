using Dziekanat.Data;
using Dziekanat.Interfaces;
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
        private readonly DziekanatContext _context;
        private readonly IObslugaBazyDanych obslugaBazyDanych;
        private readonly ILogger<HomeController> _logger;
        public HomeController(DziekanatContext context, IObslugaBazyDanych serwis, ILogger<HomeController> logger)
        {
            _context = context;
            obslugaBazyDanych = serwis;
            _logger = logger;
        }

        
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("Register_Error")]
        public IActionResult Register(string login, string password)
        {

            User user = obslugaBazyDanych.LoginUser(login, password);
            if (user != null)
            {
                if (user.Type == "student")
                {
                    Student student = obslugaBazyDanych.SetStudent(user);
                }
                return View("./Dashboard", new { test = user.ID });
                Response.Redirect("/Dashboard");
                return View("./Dashboard");
            }
            else
            {
                ViewBag.info = "Nie poprawny login lub has³o";
                // Response.Redirect("/Index");
                return View("./Index");
            }

        }

        [HttpGet]
        [Route("Dashboard")]
        public IActionResult Dashboard()
        {
            return View();
        }

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