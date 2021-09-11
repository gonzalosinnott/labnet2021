using Entities.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
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
            System.Media.SoundPlayer p = new System.Media.SoundPlayer(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\walkertexasranger.wav");
            p.PlayLooping();
            ChuckAlert frm = new ChuckAlert();
            frm.ShowDialog();
            p.Stop();
        }

        private void btnDivideby0_Click(object sender, EventArgs e)
        {
            try
            {
                Logic.DivideZero(nud1.Value);
            }            
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Logic.SystemException();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnCustomException_Click(object sender, EventArgs e)
        {
            try
            {
                Logic.CustomException();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "LA TAREA FALLO CON EXITO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
