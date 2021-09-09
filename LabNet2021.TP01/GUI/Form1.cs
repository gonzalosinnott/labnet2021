using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Entities.Clases;

namespace GUI
{
    public partial class frmMain : Form
    {
        Garage garage = new Garage();
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (garage.Vehiculos.Count < 10)
            {
                AddData();
            }
            else
            {
                MessageBox.Show($"GARAGE COMPLETO", "Error", MessageBoxButtons.OK);
            }

            RefreshData();
        }

        private void AddData()
        {
            if (rbTaxi.Checked is true)
            {
                if(garage.CheckSpace("Taxi") < 5)
                {
                    addTaxi();
                }
                else
                {
                    MessageBox.Show($"ESPACIO PARA TAXIS COMPLETO", "Error", MessageBoxButtons.OK);
                }
            }                    
            else if (rbOmnibus.Checked is true)
            {
                if (garage.CheckSpace("Omnibus") < 5)
                {
                    addOmnibus();
                }
                else
                {
                    MessageBox.Show($"ESPACIO PARA OMNIBUS COMPLETO", "Error", MessageBoxButtons.OK);
                }
            }            
            else
            {
                MessageBox.Show($"SELECCIONE UN TIPO DE VEHICULO Y CANTIDAD DE PASAJEROS", "Error", MessageBoxButtons.OK);
            }
        }
        

        private void addTaxi()
        {
            int count = Convert.ToInt32(nudPasajeros.Value);

            if (nudPasajeros.Value > 0 && nudPasajeros.Value < 5)
            {
                garage.AddVehiculo(count, rbTaxi.Text);
            }
            else
            {
                MessageBox.Show($"INGRESE UN NUMERO VALIDO DE PASAJEROS (1-4)", "Error", MessageBoxButtons.OK);

            }
        }

        private void addOmnibus()
        {
            int count = Convert.ToInt32(nudPasajeros.Value);

            if (nudPasajeros.Value > 0 && nudPasajeros.Value < 60)
            {
                garage.AddVehiculo(count, rbOmnibus.Text);
            }
            else
            {
                MessageBox.Show($"INGRESE UN NUMERO VALIDO DE PASAJEROS (1-61)", "Error", MessageBoxButtons.OK);

            }
        }

        public void RefreshData()
        {
            if(!garage.Vehiculos.Any())
            {
                rtbInfo.Text= "NO EXISTEN VEHICULOS CARGADOS";
            }
                else
            {
                rtbInfo.Text = garage.ToString();
            }
        }
    }
}
