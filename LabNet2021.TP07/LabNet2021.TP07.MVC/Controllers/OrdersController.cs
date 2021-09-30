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
        OrdersLogic ordersLogic = new OrdersLogic();

        // GET: Orders
        public ActionResult IndexOrders()
        {
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

        [HttpPost]
        public ActionResult Insert(DateTime shippedDate, int shipperId, string shipName, string address, string city, string country)
        {
            try
            {
                Orders orderEntity = new Orders
                {
                    OrderID = ordersLogic.GetMaxId(),
                    ShippedDate = shippedDate,
                    ShipVia = shipperId,
                    ShipName = shipName,
                    ShipAddress = address,
                    ShipCity = city,
                    ShipCountry = country
                };

                ordersLogic.Add(orderEntity);

                return RedirectToAction("IndexOrders", "Orders");

            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        
    }
}