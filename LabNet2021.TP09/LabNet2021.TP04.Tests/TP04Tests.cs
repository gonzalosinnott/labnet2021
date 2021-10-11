using Microsoft.VisualStudio.TestTools.UnitTesting;
using LabNet2021.TP04.Logic;
using System;
using LabNet2021.TP04.Logic.Exceptions;
using Moq;
using LabNet2021.TP04.Entities;
using System.Collections.Generic;

namespace LabNet2021.TP04.Tests
{
    [TestClass]
    public class TP04Tests
    {        
        [TestMethod]
        [ExpectedException(typeof(CustomException))]
        public void Add_ShipperWithRequiredEmptyField()
        {
            ShippersLogic shipper = new ShippersLogic();

            int id = 1;
            string companyName = "";
            string phone = "12345";

            shipper.UpdateOrAddShippersData(id, companyName, phone);
        }        

        [TestMethod]
        [ExpectedException(typeof(CustomException))]
        public void DeleteOrder_Error()
        {
            OrdersLogic order = new OrdersLogic();
            int id = 1;

            order.Delete(id);
        }

        [TestMethod]
        public void Orders_GetAll()
        {
            OrdersLogic orders = new OrdersLogic();

            List<Orders>  list = orders.GetAll();

            Assert.IsNotNull(list);
        }

        [TestMethod]
        public void Shippers_GetAll()
        {
            ShippersLogic shippers = new ShippersLogic();

            List<Shippers> list = shippers.GetAll();

            Assert.IsNotNull(list);
        }
    }
}
