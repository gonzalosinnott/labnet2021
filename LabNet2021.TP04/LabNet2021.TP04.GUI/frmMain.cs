using LabNet2021.TP04.Data;
using LabNet2021.TP04.Entities;
using LabNet2021.TP04.Logic;
using LabNet2021.TP04.Logic.Clases;
using LabNet2021.TP04.Logic.Exceptions;
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
    public partial class FrmMain : MaterialForm
    {
        readonly OrdersDTO orders = new OrdersDTO();
        readonly ShippersDTO shippers = new ShippersDTO();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            RefreshInfo();
        }

        private void RefreshInfo()
        {
            GetOrdersMainInfo();
            GetShippersMainInfo();
        }

        public void GetOrdersMainInfo()
        {
            List<OrdersDTO> orderslist = orders.GetCustomInfo();
            dgvOrders.DataSource = orderslist;
            dgvOrders.ClearSelection();
        }

        public void GetShippersMainInfo()
        {
            List<ShippersDTO> shippersList = shippers.GetCustomInfo();
            dgvShippers.DataSource = shippersList;
            dgvShippers.ClearSelection();
        }

        private void BtnAddOrder_Click(object sender, EventArgs e)
        {
            FrmAddOrder frm = new FrmAddOrder();
            frm.ShowDialog();           
            RefreshInfo();        
        }

        private void BtnDeleteOrder_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Desea elminiar la orden seleccionada?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.No)
            {
                try
                {
                    if (this.dgvOrders.CurrentRow.Selected != false)
                    {
                        OrdersDTO order = dgvOrders.CurrentRow.DataBoundItem as OrdersDTO;
                        OrdersDetailsLogic orderDetails = new OrdersDetailsLogic();
                                                
                        orderDetails.DeleteAllRelatedId(order.Id);
                        order.Delete(order.Id); 
                        MessageBox.Show($"ORDEN ELIMINADA CON EXITO", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"SELECCIONE UNA ORDEN A ELIMINAR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (CustomException ex)
                {
                    MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show($"NO HAY ORDENES PARA ELIMINAR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    RefreshInfo();
                }
            }            
        }

        private void BtnModifyOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvOrders.CurrentRow.Selected != false)
                {
                    OrdersDTO order = dgvOrders.CurrentRow.DataBoundItem as OrdersDTO;
                    FrmModifyOrder frm = new FrmModifyOrder(order.Id, order.ShippedDate, order.ShipVia, order.ShipName, order.Address, order.City, order.Country);
                    frm.ShowDialog();                  
                }
                else
                {
                    MessageBox.Show($"SELECCIONE UNA ORDEN A MODIFICAR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception)
            {
                MessageBox.Show($"NO HAY CLIENTES PARA MODIFICAR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                RefreshInfo();
            }
        }

        private void BtnAddShipper_Click(object sender, EventArgs e)
        {
            FrmAddShipper frm = new FrmAddShipper();
            frm.ShowDialog();
            RefreshInfo();
        }

        private void BtnDeleteShipper_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Desea elminiar el distribuidor seleccionado?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.No)
            {
                try
                {
                    if (this.dgvShippers.CurrentRow.Selected != false)
                    {
                        ShippersDTO shipper = dgvShippers.CurrentRow.DataBoundItem as ShippersDTO;
                        shipper.Delete(shipper.ShipperID);
                        MessageBox.Show($"DISTRIBUIDOR ELIMINADO CON EXITO", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"SELECCIONE UN DISTRIBUIDOR A ELIMINAR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (CustomException ex)
                {
                    MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show($"NO HAY DISTRIBUIDORES PARA ELIMINAR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    RefreshInfo();
                }
            }
        }

        private void BtnModifyShipper_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvShippers.CurrentRow.Selected != false)
                {
                    ShippersDTO shipper = dgvShippers.CurrentRow.DataBoundItem as ShippersDTO;
                    FrmModifyShipper frm = new FrmModifyShipper(shipper.ShipperID, shipper.CompanyName, shipper.Phone);
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show($"SELECCIONE UN DISTRIBUIDOR A MODIFICAR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"NO HAY DISTRIBUIDORES PARA MODIFICAR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                RefreshInfo();
            }
        }   
    }
}
