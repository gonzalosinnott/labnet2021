using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using LabNet2021.TP04.Entities;
using Newtonsoft.Json;

namespace LabNet2021.TP04.Logic.Clases
{
    public class PublicApiLogic
    {
        public List<SimpsonsApiModel> ListQuotes()
        {
            try
            {
                List<SimpsonsApiModel> result = null;
                string response = string.Empty;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://simpsons-quotes-api.herokuapp.com/quotes");
                httpWebRequest.ContentType = "application/json; charset=utf-8";
                httpWebRequest.Method = "GET";
                httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    response = streamReader.ReadToEnd();
                }
                httpResponse.Close();

                result = Deserialize<List<SimpsonsApiModel>>(response);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static T Deserialize<T>(string jsonData)
        {
            JsonSerializer json = new JsonSerializer();
            return json.Deserialize<T>(new JsonTextReader(new StringReader(jsonData)));
        }
    }
}
