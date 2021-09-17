using LabNet2021.TP04.Data;
using LabNet2021.TP04.Logic;
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
    public partial class frmMain : Form
    {
        CustomersLogic data = new CustomersLogic();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            dgvCustomers.DataSource = data.GetAll();
        }
    }
}
