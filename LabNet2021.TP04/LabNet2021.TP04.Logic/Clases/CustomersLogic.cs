using LabNet2021.TP04.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.TP04.Logic
{
    public class CustomersLogic : BaseDbClasesLogic, IABMLogic<Customers>
    {
        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }
        
        public Customers AddCustomerData(string Id, string companyName, string title, string contactName, string address, string city, string country, string phone)
        {
            Customers customer = new Customers();

            customer.CustomerID = Id;
            customer.CompanyName = companyName;
            customer.ContactName = contactName;
            customer.ContactTitle = title;
            customer.Address = address;
            customer.City = city;
            customer.Country = country;
            customer.Phone = phone;

            return customer;
        }

        public void Add(Customers newCustomer)
        {
            context.Customers.Add(newCustomer);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var customerToDelete = context.Customers.Find(id);

            context.Customers.Remove(customerToDelete);

            context.SaveChanges();
        }


        public void Update(Customers customer)
        {
            try
            {
                var customerUpdate = context.Customers.Find(customer.CustomerID);

                customerUpdate.CompanyName = customer.CompanyName;
                customerUpdate.ContactName = customer.ContactName;
                customerUpdate.ContactTitle = customer.ContactTitle;
                customerUpdate.Address = customer.Address;
                customerUpdate.City = customer.City;
                customerUpdate.Country = customer.Country;
                customerUpdate.Phone = customer.Phone;

                context.SaveChanges();
            }
            catch(Exception)
            {
                throw new Exception();
            }            
        }

       
    }
}
