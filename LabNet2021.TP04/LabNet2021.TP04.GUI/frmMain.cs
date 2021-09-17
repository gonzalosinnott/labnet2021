using LabNet2021.TP04.Data;
using LabNet2021.TP04.Entities;
using LabNet2021.TP04.Logic;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabNet2021.TP04.GUI
{
    public partial class FrmMain : MaterialForm
    {
        MainLogic main = new MainLogic();
        CustomersLogic customers = new CustomersLogic();
        EmployeesLogic employees = new EmployeesLogic();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            RefreshInfo();
        }

        private void RefreshInfo()
        {
            GetCustomersMainInfo();
            GetEmployeeMainInfo();

        }

        public void GetCustomersMainInfo()
        {
            List<Customers> customersList = customers.GetAll();
            
            var newList = customersList.Select(l => new
            {
                l.CustomerID,
                l.CompanyName,
                l.ContactTitle,
                l.ContactName,                
                l.Address,
                l.City,
                l.Country,
                l.Phone                
            });

            dgvCustomers.DataSource = newList.ToList();
        }

        public void GetEmployeeMainInfo()
        {
            List<Employees> employeesList = employees.GetAll();

            var newList = employeesList.Select(l => new
            {
                l.EmployeeID,
                l.FirstName,
                l.LastName,
                l.Address,
                l.City,
                l.Country,
                l.HomePhone                
            });

            dgvEmployees.DataSource = newList.ToList();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btnModifyEmployee_Click(object sender, EventArgs e)
        {

        }
    }
}
