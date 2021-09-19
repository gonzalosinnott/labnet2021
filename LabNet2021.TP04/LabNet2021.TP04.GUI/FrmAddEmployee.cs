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
    public partial class FrmAddEmployee :  MaterialForm
    {
        public FrmAddEmployee()
        {
            InitializeComponent();
        }    

        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeesLogic auxEmployee = new EmployeesLogic();

                int id = auxEmployee.GetMaxId();

                auxEmployee.Add(auxEmployee.UpdateOrAddEmployeeData(id, txtLastName.Text, txtName.Text, txtTitle.Text, txtAddress.Text, txtCity.Text, txtCountry.Text, txtPhone.Text));
                MessageBox.Show($"EMPLEADO CARGADO CON EXITO", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
