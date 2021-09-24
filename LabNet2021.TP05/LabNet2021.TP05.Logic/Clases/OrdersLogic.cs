using LabNet2021.TP05.Entities;
using LabNet2021.TP05.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.TP05.Logic.Clases
{
    public class OrdersLogic : BaseDbClasesLogic, ILogic<Orders>
    {
        public List<Orders> GetAll()
        {
            return context.Orders.ToList();
        }
    }
}