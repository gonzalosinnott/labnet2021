using LabNet2021.TP04.Data;
using LabNet2021.TP04.Entities;
using LabNet2021.TP04.Logic;
using LabNet2021.TP04.Logic.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LabNet2021.TP08.WebApi.Controllers
{
    public class OrdersController : ApiController
    {
        public IHttpActionResult GetAllOrders()
        {
            IList<OrdersModel> orders = null;

            using (var context = new NorthwindContext())
            {
                orders = context.Orders.Select(o => new OrdersModel()
                {
                    Id = o.OrderID,
                    ShippedDate = o.ShippedDate.ToString(),
                    ShipVia = (int)o.ShipVia,
                    ShipName = o.ShipName,
                    Address = o.ShipAddress,
                    City = o.ShipCity,
                    Country = o.ShipCountry
                }).ToList();
            }

            if (orders.Count == 0)
            {
                return NotFound();
            }

            return Ok(orders);
        }

        public IHttpActionResult GetOrderByID(int id)
        {
            OrdersModel orders = null;

            using (var context = new NorthwindContext())
            {
                orders = context.Orders
                .Where(o => o.OrderID == id)
                .Select(o => new OrdersModel()
                {
                    Id = o.OrderID,
                    ShippedDate = o.ShippedDate.ToString(),
                    ShipVia = (int)o.ShipVia,
                    ShipName = o.ShipName,
                    Address = o.ShipAddress,
                    City = o.ShipCity,
                    Country = o.ShipCountry
                }).FirstOrDefault();
            }

            if (orders == null)
            {
                return NotFound();
            }

            return Ok(orders);
        }

        public IHttpActionResult PostNewOrder(OrdersModel order)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            using (var context = new NorthwindContext())
            {
                context.Orders.Add(new Orders()
                {
                    ShippedDate = Convert.ToDateTime(order.ShippedDate),
                    ShipVia = order.ShipVia,
                    ShipName = order.ShipName,
                    ShipAddress = order.Address,
                    ShipCity = order.City,
                    ShipCountry = order.Country
                });

                context.SaveChanges();
            }

            return Ok();
        }

        public IHttpActionResult Put(OrdersModel order)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            using (var context = new NorthwindContext())
            {
                var existingOrder = context.Orders.Where(o => o.OrderID == order.Id).FirstOrDefault();

                if (existingOrder != null)
                {
                    existingOrder.ShippedDate = Convert.ToDateTime(order.ShippedDate.ToString());
                    existingOrder.ShipVia = order.ShipVia;
                    existingOrder.ShipName = order.ShipName;
                    existingOrder.ShipAddress = order.Address;
                    existingOrder.ShipCity = order.City;
                    existingOrder.ShipCountry = order.Country;

                    context.SaveChanges();
                }
                else
                {
                    return NotFound();
                }

                return Ok();
            }
        }

        public IHttpActionResult Delete(int id)
        {
            if (id <= 0)
                return BadRequest("NO ES UN ID VALIDO");

            using (var context = new NorthwindContext())
            {
                var order = context.Orders.Where(o => o.OrderID == id).FirstOrDefault();
                context.Order_Details.RemoveRange(context.Order_Details.Where(x => x.OrderID == id));

                context.Entry(order).State = System.Data.Entity.EntityState.Deleted;

                context.SaveChanges();
            }

            return Ok();
        }
    }
}
