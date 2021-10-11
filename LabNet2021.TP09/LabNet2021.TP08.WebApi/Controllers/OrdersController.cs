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
        OrdersLogic logic = new OrdersLogic();

        public List<OrdersModel> GetAllOrders()
        {
            try
            {
                List<Orders> orders = logic.GetAll();
                List<OrdersModel> ordersView = orders.Select(o => new OrdersModel()
                {
                    Id = o.OrderID,
                    ShippedDate = o.ShippedDate.ToString(),
                    ShipVia = (int)o.ShipVia,
                    ShipName = o.ShipName,
                    Address = o.ShipAddress,
                    City = o.ShipCity,
                    Country = o.ShipCountry
                }).ToList();

                return ordersView;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public OrdersModel GetOrderByID(int id)
        {
            try
            {
                Orders order = logic.ReturnDataById(id);

                OrdersModel orderView = new OrdersModel
                {
                    Id = order.OrderID,
                    ShippedDate = order.ShippedDate.ToString(),
                    ShipVia = (int)order.ShipVia,
                    ShipName = order.ShipName,
                    Address = order.ShipAddress,
                    City = order.ShipCity,
                    Country = order.ShipCountry
                };

                return orderView;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void PostNewOrder(OrdersModel orderView)
        {
            try
            {
                var orderEntity = new Orders
                {
                    ShippedDate = Convert.ToDateTime(orderView.ShippedDate),
                    ShipVia = orderView.ShipVia,
                    ShipName = orderView.ShipName,
                    ShipAddress = orderView.Address,
                    ShipCity = orderView.City,
                    ShipCountry = orderView.Country
                };

                logic.Add(orderEntity);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Put(OrdersModel order)
        {
            try
            {
                if(logic.Find(order.Id))
                {
                    var orderEntity = new Orders
                    {
                        OrderID = order.Id,
                        ShippedDate = Convert.ToDateTime(order.ShippedDate.ToString()),
                        ShipVia = order.ShipVia,
                        ShipName = order.ShipName,
                        ShipAddress = order.Address,
                        ShipCity = order.City,
                        ShipCountry = order.Country
                    };

                    logic.Update(orderEntity);
                }
                else
                {
                    throw new Exception("ID NO VALIDO");
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int id)
        {
            try
            {
                logic.Delete(id);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
