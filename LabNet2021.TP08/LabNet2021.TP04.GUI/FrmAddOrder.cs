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
    public partial class FrmAddOrder : MaterialForm
    {
        public FrmAddOrder()
        {
            InitializeComponent();
        }

        private void FrmAddOrder_Load(object sender, EventArgs e)
        {
            ShippersDTO auxShippers = new ShippersDTO();
            List<ShippersDTO> shippers = auxShippers.GetShippersList();
            cmbShippers.DataSource = shippers;
            cmbShippers.DisplayMember = "CompanyName";
            cmbShippers.ValueMember = "ShipperId";
        }

        private void BtnAddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                OrdersLogic auxOrder = new OrdersLogic();
                ShippersLogic auxShipper = new ShippersLogic();
                int id = auxOrder.GetMaxId();
                int shipperId = auxShipper.GetId(cmbShippers.Text);

                auxOrder.Add(auxOrder.UpdateOrAddOrdersData(id, dtpShipedDate.Value, shipperId, txtShipName.Text, txtAddress.Text, txtCity.Text, txtCountry.Text));
                MessageBox.Show($"ORDEN CARGADA CON EXITO", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
                
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
