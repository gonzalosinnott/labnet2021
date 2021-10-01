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
                shippersLogic.Add(shippersLogic.UpdateOrAddShippersData(shippersLogic.GetMaxId(),companyName,phone));
                return RedirectToAction("IndexShippers");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View("Error");
            }
        }

        public ActionResult Delete(int id)
        {
            try
            {
                shippersLogic.Delete(id);
                return RedirectToAction("IndexShippers");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View("Error");
            }

            
        }

        public ActionResult EditView(int id)
        {
            Shippers auxShipper = shippersLogic.ReturnDataById(id);

            ViewBag.ID = auxShipper.ShipperID;
            ViewBag.CompanyName = auxShipper.CompanyName;
            ViewBag.Phone = auxShipper.Phone;
            
            return View("ModifyShipper");
        }

        [HttpPost]
        public ActionResult EditConfirm(int id, string companyname, string phone)
        {
            try
            {
                shippersLogic.Update(shippersLogic.UpdateOrAddShippersData(id, companyname, phone));
                return RedirectToAction("IndexShippers");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View("Error");
            }
        }
    }
}