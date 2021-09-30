using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabNet2021.TP07.MVC.Models
{
    public class OrdersView
    {
        public int Id { get; set; }
        public string ShippedDate { get; set; }
        public string ShipVia { get; set; }
        public string ShipName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}