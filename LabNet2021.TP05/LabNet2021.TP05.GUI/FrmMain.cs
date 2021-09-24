using LabNet2021.TP04.Logic.Exceptions;
using LabNet2021.TP05.GUI.Extensions;
using LabNet2021.TP05.Logic.Clases;
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
            lbQuery.Text = "Seleccione la Consulta a realizar";
        }

        private void btnQuery1_Click(object sender, EventArgs e)
        {
            try
            { 
                lbQuery.Text = "1. Query para devolver objeto customer";
                dgvData.DataSource = data.QueryOne();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvData.DataSource = null;
            }
            finally
            {
                dgvData.RemoveEmptyColumns();
            }
        }

        private void btnQuery2_Click(object sender, EventArgs e)
        {
            try
            { 
                lbQuery.Text = "2. Query para devolver todos los productos sin stock";
                dgvData.DataSource = data.QueryTwo();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvData.DataSource = null;
            }
            finally
            {
                dgvData.RemoveEmptyColumns();
            }
        }

        private void btnQuery3_Click(object sender, EventArgs e)
        {
            try
            { 
                lbQuery.Text = "3. Query para devolver todos los productos que tienen stock y que cuestan más de 3 por unidad";
                dgvData.DataSource = data.QueryThree();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvData.DataSource = null;
            }
            finally
            {
                dgvData.RemoveEmptyColumns();
            }
        }

        private void btnQuery4_Click(object sender, EventArgs e)
        {
            try
            {
                lbQuery.Text = "4. Query para devolver todos los customers de la Región WA";
                dgvData.DataSource = data.QueryFour();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvData.DataSource = null;
            }
            finally
            {
                dgvData.RemoveEmptyColumns();
            }
        }

        private void btnQuery5_Click(object sender, EventArgs e)
        {
            try
            {
                lbQuery.Text = "5. Query para devolver el primer elemento o nulo de una lista de productos donde el ID de producto sea igual a 789";
                dgvData.DataSource = data.QueryFive();                
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvData.DataSource = null;
            }
            finally
            {
                dgvData.RemoveEmptyColumns();
            }
        }

        private void btnQuery6_Click(object sender, EventArgs e)
        {
            try
            {
                lbQuery.Text = "6. Query para devolver los nombre de los Customers. Mostrarlos en Mayuscula y en Minuscula.";
                dgvData.DataSource = data.QuerySix();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvData.DataSource = null;
            }
            finally
            {
                dgvData.RemoveEmptyColumns();
            }
        }

        private void btnQuery7_Click(object sender, EventArgs e)
        {
            try
            {
                lbQuery.Text = "7. Query para devolver Join entre Customers y Orders donde los customers sean de la Región WA y la fecha de orden sea mayor a 1/1/1997.";
                dgvData.DataSource = data.QuerySeven();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvData.DataSource = null;
            }
            finally
            {
                dgvData.RemoveEmptyColumns();
            }
        }

        private void btnQuery8_Click(object sender, EventArgs e)
        {
            try
            {
                lbQuery.Text = "8. Query para devolver los primeros 3 Customers de la Región WA";
                dgvData.DataSource = data.QueryEigth();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvData.DataSource = null;
            }
            finally
            {
                dgvData.RemoveEmptyColumns();
            }
        }

        private void btnQuery9_Click(object sender, EventArgs e)
        {
            try
            {
                lbQuery.Text = "9. Query para devolver lista de productos ordenados por nombre";
                dgvData.DataSource = data.QueryNine();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvData.DataSource = null;
            }
            finally
            {
                dgvData.RemoveEmptyColumns();
            }
        }

        private void btnQuery10_Click(object sender, EventArgs e)
        {
            try
            {
                lbQuery.Text = "10. Query para devolver lista de productos ordenados por unit in stock de mayor a menor.";
                dgvData.DataSource = data.QueryTen();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvData.DataSource = null;
            }
            finally
            {
                dgvData.RemoveEmptyColumns();
            }
        }

        private void btnQuery11_Click(object sender, EventArgs e)
        {
            try
            {
                lbQuery.Text = "11. Query para devolver las distintas categorías asociadas a los productos";
                dgvData.DataSource = data.QueryEleven();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvData.DataSource = null;
            }
            finally
            {
                dgvData.RemoveEmptyColumns();
            }
        }

        private void btnQuery12_Click(object sender, EventArgs e)
        {
            try
            {
                lbQuery.Text = "12. Query para devolver el primer elemento de una lista de productos.";
                dgvData.DataSource = data.QueryTwelve();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvData.DataSource = null;
            }
            finally
            {
                dgvData.RemoveEmptyColumns();
            }
        }

        private void btnQuery13_Click(object sender, EventArgs e)
        {
            try
            {
                lbQuery.Text = "13. Query para devolver los customer con la cantidad de ordenes asociadas.";
                dgvData.DataSource = data.QueryThirteen();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvData.DataSource = null;
            }
            finally
            {
                dgvData.RemoveEmptyColumns();
            }
        }
    }
}