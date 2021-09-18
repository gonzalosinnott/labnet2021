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
    public partial class FrmModifyEmployee : MaterialForm
    {
        int id;
        string lastName;
        string name;
        string title;
        string address;
        string city;
        string country;
        string phone;
        public FrmModifyEmployee()
        {
            InitializeComponent();
        }

        public FrmModifyEmployee(int id, string lastName, string name, string title, string address, string city, string country, string phone) : this()
        {
            this.id = id;
            this.lastName = lastName;
            this.name = name;
            this.title = title;
            this.address = address;
            this.city = city;
            this.country = country;
            this.phone = phone;
        }

        private void FrmModifyEmployee_Load(object sender, EventArgs e)
        {
            txtLastName.Text = lastName;
            txtName.Text = name;
            txtTitle.Text = title;
            txtAddress.Text = address;
            txtCity.Text = city;
            txtCountry.Text = country;
            txtPhone.Text = phone;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnModifyCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeesLogic auxEmployee = new EmployeesLogic();

                auxEmployee.Update(auxEmployee.UpdateEmployeeData(id, txtLastName.Text, txtName.Text, txtTitle.Text, txtAddress.Text, txtCity.Text, txtCountry.Text, txtPhone.Text));

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
