using LabNet2021.TP04.Entities;
using LabNet2021.TP04.Logic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.TP04.Logic
{
    public class CustomersLogic : BaseDbClasesLogic, IABMLogic<Customers>
    {
        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }
        
        public Customers AddCustomerData(string id, string companyName, string title, string contactName, string address, string city, string country, string phone)
        {
            Customers customer = new Customers();

            if (id.LongCount() == 0)
            {
                throw new CustomException("El campo Id de Identificacion es OBLIGATORIO");
            }
            else if (companyName.LongCount() == 0)
            {
                throw new CustomException("El campo Nombre de la Compañia es OBLIGATORIO");
            }
            else
            {
                customer.CustomerID = id;
                customer.CompanyName = companyName;
                customer.ContactName = contactName;
                customer.ContactTitle = title;
                customer.Address = address;
                customer.City = city;
                customer.Country = country;
                customer.Phone = phone;

                return customer;
            }
        }

        public void Add(Customers newCustomer)
        {
            context.Customers.Add(newCustomer);
            context.SaveChanges();
        }

        //Tuve que borrar la FK_Order_Details_Orders para que ande
        public void Delete(string id)
        {
            try
            {
                var customerToDelete = context.Customers.Find(id);

                context.Customers.Remove(customerToDelete);

                context.SaveChanges();
            }
            catch(Exception)
            {
                throw new CustomException("Para que funcione con los registros QUE NO HAYAN SIDO CARGADOS A TRAVES DE ESTE PROGRAMA hay que eliminar todas las FK que afecten a la tabla Customers");
            }
           
        }

        public void Update(Customers customer)
        {   
            try
            {
                var customerUpdate = context.Customers.Find(customer.CustomerID);

                customerUpdate.CompanyName = customer.CompanyName;
                customerUpdate.ContactName = customer.ContactName;
                customerUpdate.ContactTitle = customer.ContactTitle;
                customerUpdate.Address = customer.Address;
                customerUpdate.City = customer.City;
                customerUpdate.Country = customer.Country;
                customerUpdate.Phone = customer.Phone;

                context.SaveChanges();
            }
            catch(Exception)
            {
                throw new CustomException("INGRESO DE DATOS ERRONEOS");
            }                       
        }

        public bool IdExists(string id)
        {
            if(context.Customers.Find(id) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }       
    }
}
