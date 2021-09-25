using LabNet2021.TP04.Logic.Exceptions;
using LabNet2021.TP05.Entities;
using LabNet2021.TP05.Logic.Clases;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace LabNet2021.TP05.Tests
{
    [TestClass]
    public class QueriesTests
    {
        
        [TestMethod]
        public void ReturnACustomers_Test()
        {
            List<Customers> customers = new List<Customers>();
            CustomersDTO customer = new CustomersDTO();
            customers.Add(customer.ReturnACustomers());

            Assert.IsNotNull(customer);
        }

        [TestMethod]
        public void ProductsWithNoStock_Test()
        {
            ProductsDTO products = new ProductsDTO();

            Assert.IsNotNull(products.ProductsWithNoStock());
        }

        [TestMethod]
        public void ProductsWithStockAndValueMoreThanThree_Test()
        {
            ProductsDTO products = new ProductsDTO();

            Assert.IsNotNull(products.ProductsWithStockAndValueMoreThanThree());
        }

        [TestMethod]
        public void CustomersFromWARegion_Test()
        {
            CustomersDTO customers = new CustomersDTO();

            Assert.IsNotNull(customers.CustomersFromWARegion());
        }

        [TestMethod]
        [ExpectedException(typeof(CustomException))]
        public void FirstProductWithId789OrNull_Test()
        {
            ProductsDTO products = new ProductsDTO();

            products.FirstProductWithId789OrNull();
        }

        [TestMethod]
        public void CustomersNameInUpperAndLowerCase_Test()
        {
            CustomersDTO customers = new CustomersDTO();

            Assert.IsNotNull(customers.CustomersNameInUpperAndLowerCase());
        }

        [TestMethod]
        public void CustomerRegionWAJoinOrdersDateOver111997_Test()
        {
            OrdersDTO orders = new OrdersDTO();

            Assert.IsNotNull(orders.CustomerRegionWAJoinOrdersDateOver111997());
        }

        [TestMethod]
        public void FirstThreeCustomersFromWARegion_Test()
        {
            CustomersDTO customers = new CustomersDTO();

            Assert.IsNotNull(customers.FirstThreeCustomersFromWARegion());
        }

        [TestMethod]
        public void ProductsByName_Test()
        {
            ProductsDTO products = new ProductsDTO();

            Assert.IsNotNull(products.ProductsByName());
        }

        [TestMethod]
        public void ProductsByUnitInStock_Test()
        {
            ProductsDTO products = new ProductsDTO();

            Assert.IsNotNull(products.ProductsByUnitInStock());
        }

        [TestMethod]
        public void ProductsWithDescription_Test()
        {
            ProductsDTO products = new ProductsDTO();

            Assert.IsNotNull(products.ProductsWithDescription());
        }

        [TestMethod]
        public void ReturnFirstProductn_Test()
        {
            ProductsDTO products = new ProductsDTO();

            Assert.IsNotNull(products.ReturnFirstProduct());
        }

        [TestMethod]
        public void CustomersWithAmountOfOrders_Test()
        {
            CustomersDTO customers = new CustomersDTO();

            Assert.IsNotNull(customers.CustomersWithAmountOfOrders());
        }
    }
}
