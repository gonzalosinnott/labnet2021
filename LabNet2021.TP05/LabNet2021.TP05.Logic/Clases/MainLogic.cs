using LabNet2021.TP05.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.TP05.Logic.Clases
{
    public class MainLogic
    {
        CustomersDTO customers = new CustomersDTO();
        OrdersDTO orders = new OrdersDTO();
        ProductsDTO products = new ProductsDTO();

        public List<Customers> QueryOne()
        {
            List<Customers> customer = new List<Customers>();
            customer.Add(customers.ReturnACustomers());

            return customer;
        }

        public List<ProductsDTO> QueryTwo()
        {
            return products.ProductsWithNoStock();
        }

        public List<ProductsDTO> QueryThree()
        {
            return products.ProductsWithStockAndValueMoreThanThree();
        }

        public List<CustomersDTO> QueryFour()
        {
            return customers.CustomersFromWARegion();
        }

        public List<Products> QueryFive()
        {
            List<Products> product = new List<Products>();
            product.Add(products.FirstProductWithId789OrNull());

            return product;
        }

        public List<CustomersDTO> QuerySix()
        {
            return customers.CustomersNameInUpperAndLowerCase();
        }

        public List<OrdersDTO> QuerySeven()
        {
            return orders.CustomerRegionWAJoinOrdersDateOver111997();
        }

        public List<CustomersDTO> QueryEigth()
        {
            return customers.FirstThreeCustomersFromWARegion();
        }

        public List<ProductsDTO> QueryNine()
        {
            return products.ProductsByName();
        }

        public List<ProductsDTO> QueryTen()
        {
            return products.ProductsByUnitInStock();
        }

        public List<ProductsDTO> QueryEleven()
        {
            return products.ProductsWithDescription();
        }

        public List<ProductsDTO> QueryTwelve()
        {
            List<ProductsDTO> product = new List<ProductsDTO>();
            product.Add(products.ReturnFirstProduct());

            return product;
        }

        public List<CustomersDTO> QueryThirteen()
        {
            return customers.CustomersWithAmountOfOrders();
        }
    }
}
