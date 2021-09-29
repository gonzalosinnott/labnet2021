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
    public partial class FrmModifyShipper : MaterialForm
    {
        int id;      
        string name;        
        string phone;
        
        public FrmModifyShipper()
        {
            InitializeComponent();
        }

        public FrmModifyShipper(int id, string name,string phone) : this()
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
        }

        private void FrmModifyEmployee_Load(object sender, EventArgs e)
        {
            txtName.Text = name;
            txtPhone.Text = phone;
        }       

        private void BtnModifyEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                ShippersLogic auxShipper = new ShippersLogic();

                auxShipper.Update(auxShipper.UpdateOrAddShippersData(id, txtName.Text, txtPhone.Text));
                MessageBox.Show($"DISTRIBUIDOR MODIFICADO CON EXITO", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
