using LabNet2021.TP04.Entities;
using LabNet2021.TP04.Logic;
using LabNet2021.TP04.Logic.Clases;
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
    public partial class FrmModifyOrder : MaterialForm
    {
        int id;
        DateTime? shippedDate;
        string shipperName;
        string shipName;
        string address;
        string city;
        string country;

        public FrmModifyOrder()
        {
            InitializeComponent();
        }

        public FrmModifyOrder(int id, DateTime? shippedDate, string shipperName, string shipName, string address, string city, string country) : this()
        {
            this.id = id;
            this.shippedDate = shippedDate;
            this.shipperName = shipperName;
            this.shipName = shipName;
            this.address = address;
            this.city = city;
            this.country = country;
        }

        private void FrmModifyOrder_Load(object sender, EventArgs e)
        {
            ShippersDTO auxShippers = new ShippersDTO();
            List<ShippersDTO> shippers = auxShippers.GetShippersList();
            cmbShippers.DataSource = shippers;
            cmbShippers.DisplayMember = "CompanyName";
            cmbShippers.ValueMember = "ShipperId";

            dtpShippedDate.Value = (DateTime)shippedDate;
            cmbShippers.DisplayMember = shipperName;
            txtShipName.Text = shipName;
            txtAddress.Text = address;
            txtCity.Text = city;
            txtCountry.Text = country;          
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnModifyOrder_Click(object sender, EventArgs e)
        {
            try
            {
                OrdersLogic auxOrder = new OrdersLogic();
                ShippersLogic auxShippers = new ShippersLogic();

                int shipperId = auxShippers.GetId(cmbShippers.Text);
                auxOrder.Update(auxOrder.UpdateOrAddOrdersData(id, dtpShippedDate.Value, shipperId, txtShipName.Text, txtAddress.Text, txtCity.Text, txtCountry.Text));
                MessageBox.Show($"ORDEN MODIFICADA CON EXITO", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }            
        }
    }
}
