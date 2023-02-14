using Dziekanat.Database;
using Dziekanat.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Dziekanat.Controllers
{
    public class HomeController : Controller
    {

        private readonly DziekanatContext _context;
        private readonly IObslugaBazyDanych obslugaBazyDanych;
        private readonly ILogger<HomeController> _logger;

        public HomeController(DziekanatContext context, IObslugaBazyDanych serwis,ILogger<HomeController> logger)
        {
            _context = context;
            obslugaBazyDanych = serwis;
            _logger = logger;
            
        }


        // public IActionResult Index()
        // {
        //     return View();
        // }

        [HttpGet]
        [Route("Login")]
        public ActionResult Login(string login, string password)
        {
            
            User user = obslugaBazyDanych.LoginUser(login,password);
            if(user != null){
                return Ok(user);
            }else{
                return BadRequest();
            }

        }


        [HttpGet]
        [Route("GetAdmin")]
        public ActionResult GetAdmin(int userID)
        {
            Admin admin = obslugaBazyDanych.SetAdmin(userID);
            if(admin != null){
                return Ok(admin);
            }else{
                return BadRequest();
            }

        }

        [HttpGet]
        [Route("GetStudent")]
        public ActionResult GetStudent(int userID)
        {
            Student student = obslugaBazyDanych.SetStudent(userID);
            if(student != null){
                return Ok(student);
            }else{
                return BadRequest();
            }

        }

        [HttpGet]
        [Route("GetZajecia")]
        public ActionResult GetZajecia(int studentID)
        {
            List<Zajecia> zajecia = obslugaBazyDanych.GetZajecia(studentID);
            if(zajecia != null){
                return Ok(zajecia);
            }else{
                return BadRequest();
            }
        }

        public IObslugaBazyDanych GetObslugaBazyDanych()
        {
            return obslugaBazyDanych;
        }

        [HttpPost]
        [Route("ZmianaHaslaAsync/{userID}/{password}/{newpassword}")]
        public async Task<ActionResult> ZmianaHaslaAsync(int userID,string password,string newpassword)
        {
            bool result = await obslugaBazyDanych.ZmianaHasla(userID, password, newpassword);
            if(result){
                Console.WriteLine("Zmieniono Hasło");
                return Ok();
            }else{
                Console.WriteLine("Nie zmieniono hasła");
                return BadRequest();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
