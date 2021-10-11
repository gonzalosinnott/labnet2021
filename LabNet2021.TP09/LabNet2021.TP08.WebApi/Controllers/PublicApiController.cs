using LabNet2021.TP04.Entities;
using LabNet2021.TP04.Logic.Clases;
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
    public class PublicApiController : Controller
    {
        // GET: Api
        public ActionResult Index()
        {
            try
            {
                PublicApiLogic logic = new PublicApiLogic();
                
                return View(logic.ListQuotes());
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View("Error");
            }
        }
    }
}