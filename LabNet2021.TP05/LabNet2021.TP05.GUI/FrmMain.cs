using LabNet2021.TP05.GUI.Extensions;
using MaterialSkin.Controls;
using System;

namespace LabNet2021.TP05.GUI
{
    public partial class FrmMain : MaterialForm
    {
        MainLogic data = new MainLogic();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnQuery1_Click(object sender, EventArgs e)
        {
            lbQuery.Text = "1. Query para devolver objeto customer";
            dgvData.DataSource = data.QueryOne();
            dgvData.RemoveEmptyColumns();
        }

        private void btnQuery2_Click(object sender, EventArgs e)
        {
            lbQuery.Text = "2. Query para devolver todos los productos sin stock";
            dgvData.DataSource = data.QueryTwo();
            dgvData.RemoveEmptyColumns();
        }

        private void btnQuery3_Click(object sender, EventArgs e)
        {            
            lbQuery.Text = "3. Query para devolver todos los productos que tienen stock y que cuestan más de 3 por unidad";
            dgvData.DataSource = data.QueryThree();
            dgvData.RemoveEmptyColumns();
        }

        private void btnQuery4_Click(object sender, EventArgs e)
        {
            lbQuery.Text = "4. Query para devolver todos los customers de la Región WA";
            dgvData.DataSource = data.QueryThree();
            dgvData.RemoveEmptyColumns();
        }
    }
}
