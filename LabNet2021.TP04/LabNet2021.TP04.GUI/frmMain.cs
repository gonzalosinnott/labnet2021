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
        CustomersDTO customers = new CustomersDTO();
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
            List<CustomersDTO> customersList = customers.GetCustomInfo();
            dgvCustomers.DataSource = customersList;
            dgvCustomers.ClearSelection();
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
            dgvEmployees.ClearSelection();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btnModifyCostumer_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvCustomers.CurrentRow.Selected != false)
                {
                    ModifyCustomersDialog();
                }
                else
                {
                    MessageBox.Show($"SELECCIONE UN CLIENTE A MODIFICAR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception)
            {
                MessageBox.Show($"NO HAY ITEMS PARA ELIMINAR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                RefreshInfo();
            }
        }

        private void ModifyCustomersDialog()
        {
            string id = (string)dgvCustomers.SelectedRows[0].Cells[0].Value;
            string companyName = (string)dgvCustomers.SelectedRows[0].Cells[1].Value;
            string title = (string)dgvCustomers.SelectedRows[0].Cells[2].Value;
            string contactName = (string)dgvCustomers.SelectedRows[0].Cells[3].Value;
            string address = (string)dgvCustomers.SelectedRows[0].Cells[4].Value;
            string city = (string)dgvCustomers.SelectedRows[0].Cells[5].Value;
            string country = (string)dgvCustomers.SelectedRows[0].Cells[6].Value;
            string phone = (string)dgvCustomers.SelectedRows[0].Cells[7].Value;
            FrmModifyCustomer frm = new FrmModifyCustomer(id, companyName, title, contactName, address, city, country, phone);
            frm.ShowDialog();
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
