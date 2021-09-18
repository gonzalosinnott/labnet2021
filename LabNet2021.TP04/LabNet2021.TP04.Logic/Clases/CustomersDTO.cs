using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.TP04.Logic
{
    public class CustomersDTO : CustomersLogic
    {
        public string Id { get; set; }
        public string CompanyName { get;  set; }
        public string ContactTitle { get;  set; }
        public string ContactName { get;  set; }
        public string Address { get;  set; }
        public string City { get;  set; }
        public string Country { get;  set; }
        public string Phone { get;  set; }
        

        public List<CustomersDTO> GetCustomInfo()
        {
            var query = from c in context.Customers
                        select new CustomersDTO
                        {
                            Id = c.CustomerID,
                            CompanyName = c.CompanyName,
                            ContactTitle = c.ContactTitle,
                            ContactName = c.ContactName,                            
                            Address = c.Address,
                            City = c.City,
                            Country = c.Country,
                            Phone = c.Phone
                        };

            return query.ToList();
        }        
    }
}
