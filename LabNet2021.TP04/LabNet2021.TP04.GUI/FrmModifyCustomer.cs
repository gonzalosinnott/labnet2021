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
    public partial class FrmModifyCustomer : MaterialForm
    {
        string id;
        string companyName;
        string title;
        string contactName;
        string address;
        string city;
        string country;
        string phone;

        public FrmModifyCustomer()
        {
            InitializeComponent();
        }

        public FrmModifyCustomer(string id, string companyName, string title, string contactName, string address, string city, string country, string phone) : this()
        {
            this.id = id;
            this.companyName = companyName;
            this.title = title;
            this.contactName = contactName;
            this.address = address;
            this.city = city;
            this.country = country;
            this.phone = phone;
        }
        private void FrmModifyCustomer_Load(object sender, EventArgs e)
        {
            txtCompanyName.Text = companyName;
            txtTitle.Text = title;
            txtContactName.Text = contactName;
            txtAddress.Text = address;
            txtCity.Text = city;
            txtCountry.Text = country;
            txtPhone.Text = phone;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnModifyCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                CustomersLogic auxCustomer = new CustomersLogic();

                auxCustomer.Update(auxCustomer.AddCustomerData(id, txtCompanyName.Text, txtTitle.Text, txtContactName.Text, txtAddress.Text, txtCity.Text, txtCountry.Text, txtPhone.Text));
                MessageBox.Show($"CLIENTE MODIFICADO CON EXITO", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }            
        }
    }
}
