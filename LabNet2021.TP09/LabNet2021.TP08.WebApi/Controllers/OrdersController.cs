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
    [RoutePrefix("Api/Orders")]
    public class OrdersController : ApiController
    {
        OrdersLogic logic = new OrdersLogic();
        ShippersLogic auxLogic = new ShippersLogic();

        [HttpGet]
        [Route("GetAllOrders")]
        public IHttpActionResult GetAllOrders()
        {
            try
            {
                
                List<Shippers> shippers = auxLogic.GetAll();
                List<Orders> orders = logic.GetAll();                
                
                var ordersView = from o in orders
                                 join s in shippers on o.ShipVia equals s.ShipperID
                                 select new OrdersModel
                                 {
                                     Id = o.OrderID,
                                     ShippedDate = o.ShippedDate.ToString(),
                                     ShipVia = s.CompanyName,
                                     ShipName = o.ShipName,
                                     Address = o.ShipAddress,
                                     City = o.ShipCity,
                                     Country = o.ShipCountry
                                 }; 

                return Ok(ordersView.ToList());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [Route("GetOrderById/{Id}")]
        public IHttpActionResult GetOrderByID(int id)
        {
            try
            {
                Orders order = logic.ReturnDataById(id);
                
                if (order == null)
                {
                    return NotFound();
                }

                OrdersModel orderView = new OrdersModel
                {
                    Id = order.OrderID,
                    ShippedDate = order.ShippedDate.ToString(),
                    ShipVia = auxLogic.GetName((int)order.ShipVia),
                    ShipName = order.ShipName,
                    Address = order.ShipAddress,
                    City = order.ShipCity,
                    Country = order.ShipCountry
                };

                return Ok(orderView);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("InsertOrder")]
        public IHttpActionResult PostNewOrder(OrdersModel orderView)
        {            
            try
            {
                var orderEntity = new Orders
                {
                    OrderID = logic.GetMaxId(),
                    ShippedDate = Convert.ToDateTime(orderView.ShippedDate),
                    ShipVia = auxLogic.GetId(orderView.ShipVia),
                    ShipName = orderView.ShipName,
                    ShipAddress = orderView.Address,
                    ShipCity = orderView.City,
                    ShipCountry = orderView.Country
                };                

                logic.Add(orderEntity);

                return Ok(orderView);
            }
            catch (Exception)
            {
                throw;
            }            
        }

        [HttpPut]
        [Route("UpdateOrder")]
        public IHttpActionResult Put(OrdersModel orderView)
        {
            try
            {
                
                Orders order = logic.ReturnDataById(orderView.Id);

                if (order == null)
                {
                    return NotFound();
                }

                var orderEntity = new Orders
                {
                    OrderID = orderView.Id,
                    ShippedDate = Convert.ToDateTime(orderView.ShippedDate.ToString()),
                    ShipVia = auxLogic.GetId(orderView.ShipVia),
                    ShipName = orderView.ShipName,
                    ShipAddress = orderView.Address,
                    ShipCity = orderView.City,
                    ShipCountry = orderView.Country
                };

                logic.Update(orderEntity);
 
                return Ok(orderView);               
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpDelete]
        [Route("DeleteOrder")]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                Orders order = logic.ReturnDataById(id);

                if (order == null)
                {
                    return NotFound();
                }

                logic.Delete(id);

                return Ok(order);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [Route("Shippers")]
        public IHttpActionResult GetShippers()
        {
            try
            {

                List<Shippers> shippers = auxLogic.GetAll();

                var shippersView = from s in shippers
                                     select new ShippersModel
                                     {
                                         ShipperID = s.ShipperID,
                                         CompanyName = s.CompanyName,
                                         Phone = s.Phone,                                         
                                     };

                return Ok(shippersView.ToList());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
