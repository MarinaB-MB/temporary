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
            return Ol();
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
        public IActionResult Ol()
        {
            return View("menu", "menu6");
        }

        public async Task<string> GetApiMenu()
        {
            string result = "";
            int index = 0;

            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://etp.gpb.ru");

                var content = new FormUrlEncodedContent(
                    new Dictionary<string, string>
                    {
                    { "late", "1" },
                    { "inn", "7724514910" },
                    { "cpp", "772801001" }
                    });

                var response = await client.PostAsync("api/procedures.php", content);
                var xml = new XmlSerializer(typeof(Procedures));

                result += xml;
                result += response;
                result += await response.Content.ReadAsStringAsync();

                using (var sr = new StringReader(await response.Content.ReadAsStringAsync()))
                {
                    var procedures = (Procedures)xml.Deserialize(sr);

                    result += procedures;

                    foreach (Procedure i in procedures.procedure)
                    {
                        result += "\nИдентификатор: " + i.number + "\nРегистрационный Номер: " + i.registry_number + "\nСтатус: " + i.status + "\n";

                        index++;

                        if (index == 5)
                        {
                            break;
                        }
                    }
                    return result;
                }
            }
            catch
            {
                return "Error";
            }
            
            
        }

        public async Task<string> GetApiMenu2()
        {
            string result = "";
            int index = 0;

            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://etp.gpb.ru");

                var content = new FormUrlEncodedContent(
                    new Dictionary<string, string>
                    {
                    { "late", "1" }
                    });

                var response = await client.PostAsync("api/company_list.php", content);
                var xml = new XmlSerializer(typeof(Companies));

                using (var sr = new StringReader(await response.Content.ReadAsStringAsync()))
                {
                    var companies = (Companies)xml.Deserialize(sr);



                    foreach (Company i in companies.company)
                    {
                        result += "\nID: " + i.id + "\nINN: " + i.inn + "\nKPP: " + i.kpp + "\nDate Accept: " + i.date_accept + "\n";

                        index++;

                        if (index == 5)
                        {
                            break;
                        }
                    }
                    return result;
                }
            }
            catch
            {
                return "Error";
            }


        }

        public IActionResult SandBox()
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
