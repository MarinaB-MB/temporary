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
    public class ApiController : ControllerBase
    {
        public async Task<string> GetApiMenu()
        {
            //https://etp.gpb.ru/api/procedures.php?inn=7724514910&kpp=772801001&late=10
            string result = "";
            int index = 0;

            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://etp.gpb.ru");

                var content = new FormUrlEncodedContent(
                    new Dictionary<string, string>
                    {
                    { "inn", "7724514910" },
                    { "kpp", "772801001" },
                    { "late", "1" }
                    });

                var response = await client.PostAsync("api/procedures.php", content);
                var xml = new XmlSerializer(typeof(Companies));

                using (var sr = new StringReader(await response.Content.ReadAsStringAsync()))
                {
                    result = sr.ReadToEnd();
                    Response.Clear();
                    Response.ContentType = "text/xml";
                    var a = Response.WriteAsync(result);
                    return Convert.ToString(a);
                }
            }
            catch
            {
                return "Не удалось подключиться";
            }


        }
        public async Task<string> GetApiMenu2()
        {
            //https://etp.gpb.ru/api/company_list.php?late=1

            string result = "";
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
                    result = sr.ReadToEnd();
                    Response.Clear();
                    Response.ContentType = "text/xml";
                    var a = Response.WriteAsync(result);
                    return Convert.ToString(a);
                }
            }
            catch
            {
                return "Не удалось подключиться";
            }


        }
        public async Task<string> GetApiMenu3()
        {
            //https://etp.gpb.ru/api/company.php?inn=7744001497&kpp=997950001

            string result = "";

            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://etp.gpb.ru");

                var content = new FormUrlEncodedContent(
                    new Dictionary<string, string>
                    {
                    { "inn", "7744001497" },
                    { "kpp", "997950001" }
                    });

                var response = await client.PostAsync("company.php", content);
                var xml = new XmlSerializer(typeof(Companies));

                using (var sr = new StringReader(await response.Content.ReadAsStringAsync()))
                {
                    result = sr.ReadToEnd();
                    Response.Clear();
                    Response.ContentType = "text/xml";
                    var a = Response.WriteAsync(result);
                    return Convert.ToString(a);
                }
            }
            catch
            {
                return "Не удалось подключиться";
            }


        }
        public async Task<string> GetApiMenu4()
        {
            //https://etp.gpb.ru/api/protocols_list.php?updatedonly

            string result = "";

            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://etp.gpb.ru");

                var response = await client.GetAsync("api/protocols_list.php");
                var xml = new XmlSerializer(typeof(Companies));

                using (var sr = new StringReader(await response.Content.ReadAsStringAsync()))
                {
                    result = sr.ReadToEnd();
                    Response.Clear();
                    Response.ContentType = "text/xml";
                    var a = Response.WriteAsync(result);
                    return Convert.ToString(a);
                }
            }
            catch
            {
                return "Не удалось подключиться";
            }


        }
        public async Task<string> GetApiMenu5()
        {
            //https://etp.gpb.ru/api/protocols.php?num=ГП410451
            string result = "";

            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://etp.gpb.ru");

                var content = new FormUrlEncodedContent(
                    new Dictionary<string, string>
                    {
                    { "num", "ГП410451" },
                    });

                var response = await client.PostAsync("api/protocols.php", content);
                var xml = new XmlSerializer(typeof(Companies));

                using (var sr = new StringReader(await response.Content.ReadAsStringAsync()))
                {
                    result = sr.ReadToEnd();
                    Response.Clear();
                    Response.ContentType = "text/xml";
                    var a = Response.WriteAsync(result);
                    return Convert.ToString(a);
                }
            }
            catch
            {
                return "Не удалось подключиться";
            }
        }

    }
}
