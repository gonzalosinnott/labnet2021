using LabNet2021.TP05.Entities;
using LabNet2021.TP05.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.TP05.Logic.Clases
{
    public class CustomersLogic : BaseDbClasesLogic, ILogic<Customers>
    {
        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }

        public Customers ReturnACustomers()
        {
            var query = context.Customers.FirstOrDefault();           

            return query;
        }
    }
}
