using LabNet2021.TP04.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.TP04.Logic.Clases
{
    public class ShippersDTO : ShippersLogic, IDTO<ShippersDTO>
    {
        public int ShipperID { get; private set; }
        public string CompanyName { get; private set; }
        public string Phone { get; private set; }

        public List<ShippersDTO> GetCustomInfo()
        {
            var query = from s in context.Shippers
                        select new ShippersDTO
                        {
                            ShipperID = s.ShipperID,
                            CompanyName = s.CompanyName,
                            Phone = s.Phone
                        };

            return query.ToList();
        }

        public List<ShippersDTO> GetShippersList()
        {
            var query = from s in context.Shippers
                        select new ShippersDTO
                        {
                            CompanyName = s.CompanyName,                            
                        };

            return query.ToList();
        }
    }
}
