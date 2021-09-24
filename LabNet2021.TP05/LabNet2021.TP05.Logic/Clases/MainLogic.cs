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
        CustomersLogic customers = new CustomersLogic();
        CategoriesLogic categories = new CategoriesLogic();
        OrdersLogic orders = new OrdersLogic();
        ProductsLogic products = new ProductsLogic();
        
        public List<Customers> QueryOne()
        {
            List<Customers> customer = new List<Customers>();
            customer.Add(customers.ReturnACustomers());

            return customer;            
        }

        public List<ProductsLogic> QueryTwo()
        {            
            return products.ProductsWithNoStock();
        }

        public List<ProductsLogic> QueryThree()
        {
            return products.ProductsWithStockAndValueMoreThanThree();
        }
    }
}
