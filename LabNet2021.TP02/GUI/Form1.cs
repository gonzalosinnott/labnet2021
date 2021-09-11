using Entities.Clases;
using System;
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
                result = Operations.DivideOperation(txbNumber1.Text, txbNumber2.Text);
                MessageBox.Show($"Resultado {result}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DivideByZeroException)
            {
                ChuckNorrisAlert();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChuckNorrisAlert()
        {            
            ChuckAlert frm = new ChuckAlert();
            frm.ShowDialog();
        }

        private void btnDivideby0_Click(object sender, EventArgs e)
        {
            try
            {
                Operations.DivideZero(nud1.Value);
            }            
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}", $"{ex.GetType()}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show($"OPERACION TERMINADA", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSystemException_Click(object sender, EventArgs e)
        {
            try
            {
                Operations.SystemException();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}", $"{ex.GetType()}", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnCustomException_Click(object sender, EventArgs e)
        {
            try
            {
                Operations.CustomException();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.GetType()} \n{ex.Message}", $"LA TAREA FALLO CON EXITO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
