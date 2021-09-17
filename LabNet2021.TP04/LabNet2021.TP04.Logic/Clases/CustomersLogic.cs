using LabNet2021.TP04.Data;
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
            var customerUpdate = context.Customers.Find(customer.CustomerID);

            customerUpdate.ContactName = customer.ContactName;

            context.SaveChanges();
        }
    }
}
