using LabNet2021.TP04.Entities;
using LabNet2021.TP04.Logic;
using LabNet2021.TP07.MVC.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabNet2021.TP07.MVC.Controllers
{
    public class OrdersController : Controller
    {
        // GET: Orders
        public ActionResult Index()
        {
            var ordersLogic = new OrdersLogic();
            var shippersLogic = new ShippersLogic();

            List<Orders> orders = ordersLogic.GetAll();
            List<Shippers> shippers = shippersLogic.GetAll();

            var query = from o in orders
                        join s in shippers on o.ShipVia equals s.ShipperID
                        select new OrdersView
                        {
                            Id = o.OrderID,
                            ShippedDate = (o.ShippedDate ?? DateTime.Now).ToString("d"),
                            ShipVia = s.CompanyName,
                            ShipName = o.ShipName,
                            Address = o.ShipAddress,
                            City = o.ShipCity,
                            Country = o.ShipCountry
                        };

            List<OrdersView> ordersView = query.ToList();
            
            return View(ordersView);
        }

        public ActionResult Insert()
        {
            return View("InsertOrder");
        }


    }
}