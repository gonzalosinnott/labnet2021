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
    public class CustomersDTO : BaseDbClasesLogic, ILogic<Customers>
    {

        public string CompanyName { get; private set; }
        public string ContactName { get; private set; }
        public string ContactTitle { get; private set; }
        public string Address { get; private set; }
        public string City { get; private set; }
        public string Region { get; private set; }
        public string ContactNameUpper { get; private set; }
        public string ContactNameLower { get; private set; }
        public string OrderAmount { get; private set; }



        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }

        public Customers ReturnACustomers()
        {
            var query = context.Customers.FirstOrDefault();

            if (query is null)
            {
                throw new CustomException(" NO EXISTEN REGISTROS QUE CUMPLAN LA CONDICION ESPECIFICADA");
            }

            return query;
        }

        public List<CustomersDTO> CustomersFromWARegion()
        {

            var query = from c in context.Customers
                        where c.Region == "WA"
                        select new CustomersDTO
                        {
                            CompanyName = c.CompanyName,
                            ContactName = c.ContactName,
                            ContactTitle = c.ContactTitle,
                            Address = c.Address,
                            City = c.City,
                            Region = c.Region
                        };
            if (query is null)
            {
                throw new CustomException(" NO EXISTEN REGISTROS QUE CUMPLAN LA CONDICION ESPECIFICADA");
            }

            return query.ToList();
        }

        public List<CustomersDTO> CustomersNameInUpperAndLowerCase()
        {
            var query = context.Customers.Select(Customers => new CustomersDTO { ContactNameUpper = Customers.ContactName.ToUpper(), ContactNameLower = Customers.ContactName.ToLower() });

            if (query is null)
            {
                throw new CustomException(" NO EXISTEN REGISTROS QUE CUMPLAN LA CONDICION ESPECIFICADA");
            }
            return query.ToList();
        }

        public List<CustomersDTO> FirstThreeCustomersFromWARegion()
        {
            var query = context.Customers.Select(c => new CustomersDTO 
                                            {
                                                CompanyName = c.CompanyName,
                                                ContactName = c.ContactName,
                                                ContactTitle = c.ContactTitle,
                                                Address = c.Address,
                                                City = c.City,
                                                Region = c.Region
                                            }).Where(c => c.Region == "WA").Take(3);

            if (query is null)
            {
                throw new CustomException(" NO EXISTEN REGISTROS QUE CUMPLAN LA CONDICION ESPECIFICADA");
            }

            return query.ToList();
        }

        public List<CustomersDTO> CustomersWithAmountOfOrders()
        {
            var query = from c in context.Customers
                        select new CustomersDTO
                        {
                            CompanyName = c.CompanyName,
                            OrderAmount = context.Orders.Where(o => o.CustomerID == c.CustomerID).Count().ToString()
                        };

            if (query is null)
            {
                throw new CustomException(" NO EXISTEN REGISTROS QUE CUMPLAN LA CONDICION ESPECIFICADA");
            }

            return query.ToList();
        }
    }   
}
