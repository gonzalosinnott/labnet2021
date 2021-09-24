using LabNet2021.TP04.Logic.Exceptions;
using LabNet2021.TP05.Entities;
using LabNet2021.TP05.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.TP05.Logic.Clases
{
    public class OrdersDTO : BaseDbClasesLogic, ILogic<Orders>
    {
        public string Customer { get; private set; }
        public string CustomerRegion { get; private set; }
        public DateTime? OrderDate { get; private set; }
        

        public List<Orders> GetAll()
        {
            return context.Orders.ToList();
        }

        public List<OrdersDTO> CustomerRegionWAJoinOrdersDateOver111997()
        {
            DateTime date = new DateTime(1997, 01, 01, 0, 00, 0);

             var query = from o in context.Orders                         
                         join c in context.Customers
                         on o.CustomerID equals c.CustomerID
                         where c.Region == "WA"
                         where o.OrderDate > date
                         select new OrdersDTO
                         {
                             Customer = c.CompanyName,
                             CustomerRegion = c.Region,
                             OrderDate = o.OrderDate                             
                         };
               
            if (query is null)
            {
                throw new CustomException(" NO EXISTEN REGISTROS QUE CUMPLAN LA CONDICION ESPECIFICADA");
            }

            return query.ToList();
        }
    }
}