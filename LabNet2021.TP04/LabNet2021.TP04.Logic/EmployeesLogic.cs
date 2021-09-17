using LabNet2021.TP04.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.TP04.Logic
{
    class EmployeesLogic :BaseLogic, IABMLogic<Employees>
    {
        public List<Employees> GetAll()
        {
            return context.Employees.ToList();
        }

        public void Add(Employees newEmployee)
        {
            context.Employees.Add(newEmployee);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var employeeToDelete = context.Employees.Find(id);

            context.Employees.Remove(employeeToDelete);

            context.SaveChanges();
        }

        public void Update(Employees employee)
        {
            var employeeUpdate = context.Employees.Find(employee.EmployeeID);

            employeeUpdate.FirstName = employee.FirstName;

            context.SaveChanges();
        }
    }
}
