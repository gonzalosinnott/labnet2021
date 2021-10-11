using LabNet2021.TP04.Entities;
using LabNet2021.TP04.Logic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.TP04.Logic
{
    public class OrdersDetailsLogic : BaseDbClasesLogic
    {
        public List<Order_Details> GetAll()
        {
            return context.Order_Details.ToList();
        }

        public int GetId(int id)
        {            
            var auxOrder = context.Order_Details.FirstOrDefault(x => x.OrderID == id);
            int auxID = auxOrder.OrderID;
            return auxID;
        }
        
        public void DeleteAllRelatedId(int id)
        {
            try
            {
                OrdersDetailsLogic auxOrders = new OrdersDetailsLogic();
                List<Order_Details> auxList = auxOrders.GetAll();
                context.Order_Details.RemoveRange(context.Order_Details.Where(x => x.OrderID ==id));

                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new CustomException($"{ ex.Message }");
            }
        }
    }
}
