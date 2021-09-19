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
        public void Add_CustomerWithRequiredEmptyField()
        {
            CustomersLogic customer = new CustomersLogic();

            string id = "";
            string company = "";
            string title = "Sales Representative";
            string contactName = "John Doe";
            string address = "Street 123";
            string city = "Buenos Aires";
            string country = "Argentina";
            string phone = "12345";

            customer.AddCustomerData(id, company, title, contactName, address, city, country, phone);
        }

        [TestMethod]
        [ExpectedException(typeof(CustomException))]
        public void Add_EmployeeWithRequiredEmptyField()
        {
            EmployeesLogic customer = new EmployeesLogic();

            int id = 0;
            string lastName = "";
            string name = "";
            string title = "Developer";
            string address = "Street 123";
            string city = "Buenos Aires";
            string country = "Argentina";
            string phone = "12345";

            customer.UpdateOrAddEmployeeData(id, lastName, name, title, address, city, country, phone);
        }

        [TestMethod]
        [ExpectedException(typeof(CustomException))]
        public void Delete_Customer()
        {
            CustomersLogic customer = new CustomersLogic();
            string id = "MockID";

            customer.Delete(id);
        }

        [TestMethod]
        public void Customer_GetAll()
        {
            CustomersLogic customer = new CustomersLogic();

            List<Customers>  list = customer.GetAll();

            Assert.IsNotNull(list);
        }

        [TestMethod]
        public void Employee_GetAll()
        {
            EmployeesLogic employee = new EmployeesLogic();

            List<Employees> list = employee.GetAll();

            Assert.IsNotNull(list);
        }
    }
}
