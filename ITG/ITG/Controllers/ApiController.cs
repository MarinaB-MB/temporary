using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ITG.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ITG.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
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
                return "Не удалось подключиться";
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
        public async Task<string> GetApiMenu3()
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
        public async Task<string> GetApiMenu4()
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
        public async Task<string> GetApiMenu5()
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
        public async Task<string> GetApiMenu6()
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
        public async Task<string> GetApiMenu7()
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
        public async Task<string> GetApiMenu8()
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
    }
}
