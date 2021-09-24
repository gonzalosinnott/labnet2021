using LabNet2021.TP05.Entities;
using LabNet2021.TP05.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.TP05.Logic.Clases
{
    public class ProductsLogic : BaseDbClasesLogic, ILogic<Products>
    {
        public int ProductID { get; private set; }
        public string ProductName { get; private set; }
        public short? UnitsInStock { get; private set; }
        public decimal? UnitPrice { get; private set; }

        public List<Products> GetAll()
        {
            return context.Products.ToList();
        }

        public List<ProductsLogic> ProductsWithNoStock()
        {
            var query = context.Products.Where(Products => Products.UnitsInStock == 0).Select(Products => new ProductsLogic { ProductID = Products.ProductID, ProductName = Products.ProductName, UnitsInStock = Products.UnitsInStock });

            return query.ToList();
        }

        public List<ProductsLogic> ProductsWithStockAndValueMoreThanThree()
        {
            var query = from p in context.Products
                        where p.UnitsInStock > 0 && p.UnitPrice > 3
                        select new ProductsLogic
                        {
                            ProductID = p.ProductID,
                            ProductName = p.ProductName,
                            UnitsInStock = p.UnitsInStock,
                            UnitPrice = p.UnitPrice
                        };

            return query.ToList();
        }
    }
}
