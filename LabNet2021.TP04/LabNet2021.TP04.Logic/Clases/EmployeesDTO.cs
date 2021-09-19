using LabNet2021.TP04.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.TP04.Logic.Clases
{
    public class EmployeesDTO : EmployeesLogic, IDTO<EmployeesDTO>
    {
        public int Id { get;  set; }
        public string LastName { get;  set; }
        public string FirstName { get;  set; }
        public string Title { get;  set; }
        public string Address { get;  set; }
        public string City { get;  set; }
        public string Country { get;  set; }
        public string Phone { get;  set; }

        public List<EmployeesDTO> GetCustomInfo()
        {
            var query = from e in context.Employees
                        select new EmployeesDTO
                        {
                            Id = e.EmployeeID,
                            LastName = e.LastName,
                            FirstName = e.FirstName,
                            Title = e.Title,
                            Address = e.Address,
                            City = e.City,
                            Country = e.Country,
                            Phone = e.HomePhone
                        };

            return query.ToList();
        }                
    }
}
