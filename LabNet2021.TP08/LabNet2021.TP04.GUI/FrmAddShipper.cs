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
    public partial class FrmAddShipper :  MaterialForm
    {
        public FrmAddShipper()
        {
            InitializeComponent();
        }    

        private void BtnAddShipper_Click(object sender, EventArgs e)
        {
            try
            {
                ShippersLogic auxShipper = new ShippersLogic();

                int id = auxShipper.GetMaxId();

                auxShipper.Add(auxShipper.UpdateOrAddShippersData(id, txtName.Text, txtPhone.Text));
                MessageBox.Show($"DISTRIBUIDOR CARGADO CON EXITO", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
