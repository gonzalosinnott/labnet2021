using LabNet2021.TP04.Data;
using LabNet2021.TP04.Entities;
using LabNet2021.TP04.Logic;
using LabNet2021.TP04.Logic.Clases;
using LabNet2021.TP04.Logic.Exceptions;
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
        readonly CustomersDTO customers = new CustomersDTO();
        readonly EmployeesDTO employees = new EmployeesDTO();

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
            List<EmployeesDTO> employeesList = employees.GetCustomInfo();
            dgvEmployees.DataSource = employeesList;
            dgvEmployees.ClearSelection();
        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            FrmAddCustomer frm = new FrmAddCustomer();
            frm.ShowDialog();           
            RefreshInfo();        
        }

        private void BtnDeleteCustomer_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Desea elminiar el cliente seleccionado?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.No)
            {
                try
                {
                    if (this.dgvCustomers.CurrentRow.Selected != false)
                    {
                        CustomersDTO customer = dgvCustomers.CurrentRow.DataBoundItem as CustomersDTO;
                        customers.Delete(customer.Id); 
                        MessageBox.Show($"CLIENTE ELIMINADO CON EXITO", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"SELECCIONE UN CLIENTE A ELIMINAR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (CustomException ex)
                {
                    MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show($"NO HAY CLIENTES PARA ELIMINAR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    RefreshInfo();
                }
            }            
        }

        private void BtnModifyCostumer_Click(object sender, EventArgs e)
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
                MessageBox.Show($"NO HAY CLIENTES PARA MODIFICAR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {
            FrmAddEmployee frm = new FrmAddEmployee();
            frm.ShowDialog();
            RefreshInfo();
        }

        private void BtnDeleteEmployee_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Desea elminiar el empleado seleccionado?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.No)
            {
                try
                {
                    if (this.dgvEmployees.CurrentRow.Selected != false)
                    {
                        EmployeesDTO employee = dgvEmployees.CurrentRow.DataBoundItem as EmployeesDTO;
                        employees.Delete(employee.Id);
                        MessageBox.Show($"EMPLEADO ELIMINADO CON EXITO", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"SELECCIONE UN EMPLEADO A ELIMINAR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (CustomException ex)
                {
                    MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show($"NO HAY EMPLEADOS PARA ELIMINAR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    RefreshInfo();
                }
            }
        }

        private void BtnModifyEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvEmployees.CurrentRow.Selected != false)
                {
                    ModifyEmployeeDialog();
                }
                else
                {
                    MessageBox.Show($"SELECCIONE UN EMPLEADO A MODIFICAR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"NO HAY EMPLEADOS PARA MODIFICAR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                RefreshInfo();
            }
        }

        private void ModifyEmployeeDialog()
        {
            int id = (int)dgvEmployees.SelectedRows[0].Cells[0].Value;
            string lastName = (string)dgvEmployees.SelectedRows[0].Cells[1].Value;
            string name = (string)dgvEmployees.SelectedRows[0].Cells[2].Value;
            string title = (string)dgvEmployees.SelectedRows[0].Cells[3].Value;
            string address = (string)dgvEmployees.SelectedRows[0].Cells[4].Value;
            string city = (string)dgvEmployees.SelectedRows[0].Cells[5].Value;
            string country = (string)dgvEmployees.SelectedRows[0].Cells[6].Value;
            string phone = (string)dgvEmployees.SelectedRows[0].Cells[7].Value;
            FrmModifyEmployee frm = new FrmModifyEmployee(id, lastName, name, title, address, city, country, phone);
            frm.ShowDialog();
        }
    }
}
