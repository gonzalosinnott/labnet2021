using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.TP04.Logic
{
    public class OrdersDTO : OrdersLogic, IDTO<OrdersDTO>
    {
        public int Id { get; private set; }
        public DateTime? ShippedDate { get; private set; }
        public string ShipVia { get; private set; }
        public string ShipName { get; private set; }
        public string Address { get; private set; }
        public string City { get; private set; }
        public string Country { get; private set; }

        public List<OrdersDTO> GetCustomInfo()
        {
            var query = from o in context.Orders join s in context.Shippers on o.ShipVia equals s.ShipperID
                        select new OrdersDTO
                        {
                            Id = o.OrderID,
                            ShippedDate = o.ShippedDate,                            
                            ShipVia = s.CompanyName,
                            ShipName = o.ShipName,
                            Address = o.ShipAddress,
                            City = o.ShipCity,
                            Country = o.ShipCountry
                        };

            return query.ToList();
        }        
    }
}
