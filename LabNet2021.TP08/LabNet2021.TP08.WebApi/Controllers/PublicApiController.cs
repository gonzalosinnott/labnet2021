using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace LabNet2021.TP08.WebApi.Controllers
{
    public class ApiController : Controller
    {
        // GET: Api
        public ActionResult Index()
        {
            try
            {
                List<Api> result = null;
                string response = string.Empty;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://simpsons-quotes-api.herokuapp.com/quotes?count=5");
                httpWebRequest.ContentType = "application/json; charset=utf-8";
                httpWebRequest.Method = "GET";
                httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    response = streamReader.ReadToEnd();
                }
                httpResponse.Close();

                result = Deserialize<List<Api>>(response);
                return View(result);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View("Error");
            }
        }

        public static T Deserialize<T>(string jsonData)
        {
            JsonSerializer json = new JsonSerializer();
            return json.Deserialize<T>(new JsonTextReader(new StringReader(jsonData)));
        }
    }
}