using LabNet2021.TP04.Logic.Exceptions;
using LabNet2021.TP05.Entities;
using LabNet2021.TP05.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.TP05.Logic.Clases
{
    public class ProductsDTO : BaseDbClasesLogic, ILogic<Products>
    {
        public int ProductID { get; private set; }
        public string ProductName { get; private set; }
        public short? UnitsInStock { get; private set; }
        public decimal? UnitPrice { get; private set; }
        public string CategoryName { get; private set; }
        public string CategoryDescription { get; private set; }

        public List<Products> GetAll()
        {
            return context.Products.ToList();
        }

        public List<ProductsDTO> ProductsWithNoStock()
        {
            var query = context.Products.Where(p => p.UnitsInStock == 0).Select(p => new ProductsDTO
                                                                                     {
                                                                                         ProductID = p.ProductID, 
                                                                                         ProductName = p.ProductName, 
                                                                                         UnitsInStock = p.UnitsInStock
                                                                                     });
            
            if (query is null)
            {
                throw new CustomException(" NO EXISTEN REGISTROS QUE CUMPLAN LA CONDICION ESPECIFICADA");
            }
            
            return query.ToList();
        }

        public List<ProductsDTO> ProductsWithStockAndValueMoreThanThree()
        {
            var query = from p in context.Products
                        where p.UnitsInStock > 0 && p.UnitPrice > 3
                        select new ProductsDTO
                        {
                            ProductID = p.ProductID,
                            ProductName = p.ProductName,
                            UnitsInStock = p.UnitsInStock,
                            UnitPrice = p.UnitPrice
                        };

            if (query is null)
            {
                throw new CustomException(" NO EXISTEN REGISTROS QUE CUMPLAN LA CONDICION ESPECIFICADA");
            }

            return query.ToList();
        }

        public Products FirstProductWithId789OrNull()
        {
            var query = context.Products.FirstOrDefault(p => p.ProductID == 789);
            
            if(query is null)
            {
                throw new CustomException(" NO EXISTEN REGISTROS QUE CUMPLAN LA CONDICION ESPECIFICADA");
            }
            return query;
        }

        public List<ProductsDTO> ProductsByName()
        {
            var query = context.Products.OrderBy(p => p.ProductName).Select(p => new ProductsDTO { ProductID = p.ProductID, ProductName = p.ProductName});

            if (query is null)
            {
                throw new CustomException(" NO EXISTEN REGISTROS QUE CUMPLAN LA CONDICION ESPECIFICADA");
            }

            return query.ToList();
        }

        public List<ProductsDTO> ProductsByUnitInStock()
        {
            var query = from p in context.Products
                        orderby p.UnitsInStock descending
                        select new ProductsDTO
                        {
                            ProductID = p.ProductID,
                            ProductName = p.ProductName,
                            UnitsInStock = p.UnitsInStock,
                        };

            if (query is null)
            {
                throw new CustomException(" NO EXISTEN REGISTROS QUE CUMPLAN LA CONDICION ESPECIFICADA");
            }

            return query.ToList();
        }

        public List<ProductsDTO> ProductsWithDescription()
        {
           var query = from p in context.Products
                        join c in context.Categories
                        on p.CategoryID equals c.CategoryID
                        select new ProductsDTO
                        {
                            ProductID = p.ProductID,
                            ProductName = p.ProductName,
                            CategoryName = c.CategoryName,
                            CategoryDescription = c.Description
                        };

            if (query is null)
            {
                throw new CustomException(" NO EXISTEN REGISTROS QUE CUMPLAN LA CONDICION ESPECIFICADA");
            }

            return query.ToList();
        }

        public ProductsDTO ReturnFirstProduct()
        {
            var query = context.Products.Select(p => new ProductsDTO
                                                    {
                                                        ProductID = p.ProductID,
                                                        ProductName = p.ProductName,
                                                        UnitsInStock = p.UnitsInStock,
                                                        UnitPrice = p.UnitPrice
                                                    }).FirstOrDefault(); ;

            if (query is null)
            {
                throw new CustomException(" NO EXISTEN REGISTROS QUE CUMPLAN LA CONDICION ESPECIFICADA");
            }

            return query;
        }


    }
}
