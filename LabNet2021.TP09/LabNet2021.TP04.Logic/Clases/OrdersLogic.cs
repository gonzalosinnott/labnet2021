using LabNet2021.TP04.Entities;
using LabNet2021.TP04.Logic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.TP04.Logic
{
    public class OrdersLogic : BaseDbClasesLogic, IABMLogic<Orders>
    {
        public List<Orders> GetAll()
        {
            return context.Orders.ToList();
        }
        
        public Orders UpdateOrAddOrdersData(int id, DateTime shippedDate, int shipperId, string shipName, string address, string city, string country)
        {
            Orders order = new Orders
            {
                OrderID = id,
                ShippedDate = shippedDate,
                ShipVia = shipperId,
                ShipName = shipName,
                ShipAddress = address,
                ShipCity = city,
                ShipCountry = country
            };

            return order;           
        }

        public int GetMaxId()
        {
            int maxId = context.Orders.Select(x => x.OrderID).Max();

            return maxId + 1;
        }

        public int GetId(string id)
        {
            var auxOrder = context.Orders.Find(id);
            return auxOrder.OrderID;
        }

        public bool Find(int id)
        {
            try
            {
                bool output = false;
                var bufferShippers = context.Shippers.Find(id);
                if (bufferShippers != null)
                {
                    output = true;
                }
                return output;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Add(Orders newOrder)
        {
            context.Orders.Add(newOrder);
            context.SaveChanges();
        }

        public Orders ReturnDataById(int id)
        {
            var auxOrder = context.Orders.SingleOrDefault(x => x.OrderID == id);
            return auxOrder;
        }

        public void Delete(int id)
        {
            try
            {
                var orderToDelete = context.Orders.Find(id);

                context.Orders.Remove(orderToDelete);

                context.SaveChanges();
            }
            catch(Exception)
            {
                throw new CustomException("Para que funcione con los registros QUE NO HAYAN SIDO CARGADOS A TRAVES DE ESTE PROGRAMA hay que eliminar todas las FK que afecten a la tabla Customers");
            }           
        }

        public void Update(Orders order)
        {   
            try
            {
                var customerUpdate = context.Orders.Find(order.OrderID);

                customerUpdate.ShippedDate = order.ShippedDate;
                customerUpdate.ShipVia = order.ShipVia;
                customerUpdate.ShipName = order.ShipName;
                customerUpdate.ShipAddress = order.ShipAddress;
                customerUpdate.ShipCity = order.ShipCity;
                customerUpdate.ShipCountry = order.ShipCountry;

                context.SaveChanges();
            }
            catch(Exception)
            {
                throw new CustomException("INGRESO DE DATOS ERRONEOS");
            }                       
        }        
    }
}
