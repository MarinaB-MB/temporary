using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ITG.Models;
using System.Net.Http;
using System.Xml.Serialization;
using System.IO;

namespace ITG.Controllers
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
        {
            return View();
        }
        public IActionResult menu()
        {
            return View();
        }
        public IActionResult menu2()
        {
            return View();
        }
        public IActionResult menu3()
        {
            return View();
        }
        public IActionResult menu4()
        {
            return View();
        }
        public IActionResult menu5()
        {
            return View();
        }
        public IActionResult menu6()
        {
            return View();
        }
        public IActionResult menu7()
        {
            return View();
        }
        public IActionResult menu8()
        {
            return View();
        }

        public IActionResult SandBox()
        {
            return View();
        }
        public void send_doc(String reason, String name, String month, String day, String year)
        {
            //sent doc
        }
        public IActionResult PersonalAccount()
        {
            return View();
        }

        public string SandBoxGet(string height, string altitude)
        {
            return height+ altitude;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
