using Entities.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                double result;
                result = Logic.DivideOperation(txbNumber1.Text, txbNumber2.Text);
                MessageBox.Show($"Resultado {result}", "", MessageBoxButtons.OK);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "", MessageBoxButtons.OK);
            }
        }

        private void btnDivideby0_Click(object sender, EventArgs e)
        {

        }
    }
}
