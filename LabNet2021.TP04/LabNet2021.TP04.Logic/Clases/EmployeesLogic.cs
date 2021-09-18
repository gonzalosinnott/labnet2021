using LabNet2021.TP04.Entities;
using LabNet2021.TP04.Logic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.TP04.Logic
{
    public class EmployeesLogic : BaseDbClasesLogic, IABMLogic<Employees>
    {
        public List<Employees> GetAll()
        {
            return context.Employees.ToList();
        }

        public Employees UpdateEmployeeData(int id, string lastName, string name, string title, string address, string city, string country, string phone)
        {
            Employees employee = new Employees();

            if (lastName.LongCount() == 0)
            {
                throw new CustomException("El campo APELLIDO es OBLIGATORIO");
            }
            else if (name.LongCount() == 0)
            {
                throw new CustomException("El campo NOMBRE es OBLIGATORIO");
            }
            else
            {
                employee.EmployeeID = id;
                employee.LastName = lastName;
                employee.FirstName = name;
                employee.Title = title;
                employee.Address = address;
                employee.City = city;
                employee.Country = country;
                employee.HomePhone = phone;

                return employee;
            }
        }

        public Employees AddEmployeeData(string lastName, string name, string title, string address, string city, string country, string phone)
        {
            Employees employee = new Employees();

            int id = GetMaxId();

            if (lastName.LongCount() == 0)
            {
                throw new CustomException("El campo APELLIDO es OBLIGATORIO");
            }
            else if (name.LongCount() == 0)
            {
                throw new CustomException("El campo NOMBRE es OBLIGATORIO");
            }
            else
            {
                employee.EmployeeID = id;
                employee.LastName = lastName;
                employee.FirstName = name;
                employee.Title = title;
                employee.Address = address;
                employee.City = city;
                employee.Country = country;
                employee.HomePhone = phone;

                return employee;
            }
        }

        public int GetMaxId()
        {
            int maxId = context.Employees.Select(x => x.EmployeeID).Max();

            return maxId + 1;
        }

        public void Add(Employees newEmployee)
        {
            context.Employees.Add(newEmployee);
            context.SaveChanges();
        }

        
        public void Delete(int id)
        {
            try
            {
                var employeeToDelete = context.Employees.Find(id);

                context.Employees.Remove(employeeToDelete);

                context.SaveChanges();
            }
            catch (Exception)
            {
                throw new CustomException("Para que funcione hay que eliminar todas las FK que afecten a la tabla Employees");
            }
        }

        

        public void Update(Employees employee)
        {
            try
            {
                var employeeUpdate = context.Employees.Find(employee.EmployeeID);

                employeeUpdate.LastName = employee.LastName;
                employeeUpdate.FirstName = employee.FirstName;
                employeeUpdate.Title = employee.Title;
                employeeUpdate.Address = employee.Address;
                employeeUpdate.City = employee.City;
                employeeUpdate.Country = employee.Country;
                employeeUpdate.HomePhone = employee.HomePhone;

                context.SaveChanges();
            }
            catch (Exception)
            {
                throw new CustomException("INGRESO DE DATOS ERRONEOS");
            }
        }
    }
}
