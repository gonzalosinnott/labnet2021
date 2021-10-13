using LabNet2021.TP04.Entities;
using LabNet2021.TP04.Logic.Clases;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;

namespace LabNet2021.TP08.WebApi.Controllers
{
    [RoutePrefix("Api/PublicApi")]
    public class PublicApiController : ApiController
    {
        [HttpGet]
        [Route("GetQuote")]
        public IHttpActionResult Index()
        {
            try
            {
                PublicApiLogic logic = new PublicApiLogic();
                
                return Ok(logic.ListQuotes());
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }
    }
}