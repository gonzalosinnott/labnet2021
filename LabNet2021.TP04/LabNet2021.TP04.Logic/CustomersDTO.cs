using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.TP04.Logic
{
    public class CustomersDTO : CustomersLogic
    {
        public string CompanyName { get; private set; }
        public string ContactName { get; private set; }
        public string ContactTitle { get; private set; }
        public string Address { get; private set; }
        public string City { get; private set; }
        public string Country { get; private set; }
        public string Phone { get; private set; }

        public List<CustomersDTO> GetCustomInfo()
        {
            var query = from c in context.Customers
                        select new CustomersDTO
                        {
                            CompanyName = c.CompanyName,
                            ContactName = c.ContactName,
                            ContactTitle = c.ContactTitle,
                            Address = c.Address,
                            City = c.City,
                            Country = c.Country,
                            Phone = c.Phone
                        };

            return query.ToList();
        }
    }
}
