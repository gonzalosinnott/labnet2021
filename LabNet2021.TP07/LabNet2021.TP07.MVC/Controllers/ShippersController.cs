using LabNet2021.TP04.Entities;
using LabNet2021.TP04.Logic;
using LabNet2021.TP07.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabNet2021.TP07.MVC.Controllers
{
    public class ShippersController : Controller
    {
        ShippersLogic shippersLogic = new ShippersLogic();

        // GET: Shippers
        public ActionResult IndexShippers()
        {
            List<Shippers> shippers = shippersLogic.GetAll();

            List<ShippersView> shippersView = shippers.Select(s => new ShippersView
            {
                ShipperID = s.ShipperID,
                CompanyName = s.CompanyName,
                Phone = s.Phone
            }).ToList();

            return View(shippersView);
        }

        public ActionResult Insert()
        {
            return View("InsertShipper");
        }

        [HttpPost]
        public ActionResult Insert(string companyName, string phone)
        {
            try
            {
                Shippers shipperEntity = new Shippers
                {
                    ShipperID = shippersLogic.GetMaxId(),
                    CompanyName = companyName,
                    Phone = phone,
                };

                shippersLogic.Add(shipperEntity);

                return RedirectToAction("IndexShippers");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index" , "Error");
            }
        }

        public ActionResult Delete(int id)
        {
            try
            {
                shippersLogic.Delete(id);
                return RedirectToAction("IndexShippers");
            }
            catch(Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }
        }
    }
}