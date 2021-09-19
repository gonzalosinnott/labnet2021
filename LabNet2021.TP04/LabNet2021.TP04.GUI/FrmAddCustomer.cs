using LabNet2021.TP04.Logic;
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
    public partial class FrmAddCustomer : MaterialForm
    {
        public FrmAddCustomer()
        {
            InitializeComponent();
        }

        private void BtnAddCustomer_Click_1(object sender, EventArgs e)
        {
            try
            {
                CustomersLogic auxCustomer = new CustomersLogic();
                string id = txtId.Text.ToUpper();
                if (auxCustomer.IdExists(id) == true)
                {
                    throw new CustomException("ID YA EXISTENTE, INGRESE OTRO");
                }
                else
                {
                    auxCustomer.Add(auxCustomer.AddCustomerData(id, txtCompanyName.Text, txtTitle.Text, txtContactName.Text, txtAddress.Text, txtCity.Text, txtCountry.Text, txtPhone.Text));
                    MessageBox.Show($"CLIENTE CARGADO CON EXITO", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
