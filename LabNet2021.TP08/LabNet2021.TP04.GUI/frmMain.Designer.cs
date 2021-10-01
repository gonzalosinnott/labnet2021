
namespace LabNet2021.TP04.GUI
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tbOrdenes = new System.Windows.Forms.TabPage();
            this.BtnModifyOrder = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnDeleteOrder = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnAddOrder = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.tbShippers = new System.Windows.Forms.TabPage();
            this.dgvShippers = new System.Windows.Forms.DataGridView();
            this.BtnModifyShipper = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnDeleteShipper = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnAddShipper = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tbSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.mainTabControl.SuspendLayout();
            this.tbOrdenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.tbShippers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShippers)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tbOrdenes);
            this.mainTabControl.Controls.Add(this.tbShippers);
            this.mainTabControl.Depth = 0;
            this.mainTabControl.Location = new System.Drawing.Point(12, 89);
            this.mainTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(854, 371);
            this.mainTabControl.TabIndex = 0;
            // 
            // tbOrdenes
            // 
            this.tbOrdenes.Controls.Add(this.BtnModifyOrder);
            this.tbOrdenes.Controls.Add(this.BtnDeleteOrder);
            this.tbOrdenes.Controls.Add(this.BtnAddOrder);
            this.tbOrdenes.Controls.Add(this.dgvOrders);
            this.tbOrdenes.Location = new System.Drawing.Point(4, 22);
            this.tbOrdenes.Name = "tbOrdenes";
            this.tbOrdenes.Padding = new System.Windows.Forms.Padding(3);
            this.tbOrdenes.Size = new System.Drawing.Size(846, 345);
            this.tbOrdenes.TabIndex = 0;
            this.tbOrdenes.Text = "ORDENES";
            this.tbOrdenes.UseVisualStyleBackColor = true;
            // 
            // BtnModifyOrder
            // 
            this.BtnModifyOrder.AutoSize = true;
            this.BtnModifyOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnModifyOrder.Depth = 0;
            this.BtnModifyOrder.Icon = null;
            this.BtnModifyOrder.Location = new System.Drawing.Point(300, 303);
            this.BtnModifyOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnModifyOrder.Name = "BtnModifyOrder";
            this.BtnModifyOrder.Primary = true;
            this.BtnModifyOrder.Size = new System.Drawing.Size(141, 36);
            this.BtnModifyOrder.TabIndex = 3;
            this.BtnModifyOrder.Text = "MODIFICAR ORDEN";
            this.BtnModifyOrder.UseVisualStyleBackColor = true;
            this.BtnModifyOrder.Click += new System.EventHandler(this.BtnModifyOrder_Click);
            // 
            // BtnDeleteOrder
            // 
            this.BtnDeleteOrder.AutoSize = true;
            this.BtnDeleteOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnDeleteOrder.Depth = 0;
            this.BtnDeleteOrder.Icon = null;
            this.BtnDeleteOrder.Location = new System.Drawing.Point(153, 303);
            this.BtnDeleteOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnDeleteOrder.Name = "BtnDeleteOrder";
            this.BtnDeleteOrder.Primary = true;
            this.BtnDeleteOrder.Size = new System.Drawing.Size(131, 36);
            this.BtnDeleteOrder.TabIndex = 2;
            this.BtnDeleteOrder.Text = "ELIMINAR ORDEN";
            this.BtnDeleteOrder.UseVisualStyleBackColor = true;
            this.BtnDeleteOrder.Click += new System.EventHandler(this.BtnDeleteOrder_Click);
            // 
            // BtnAddOrder
            // 
            this.BtnAddOrder.AutoSize = true;
            this.BtnAddOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAddOrder.Depth = 0;
            this.BtnAddOrder.Icon = null;
            this.BtnAddOrder.Location = new System.Drawing.Point(7, 303);
            this.BtnAddOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAddOrder.Name = "BtnAddOrder";
            this.BtnAddOrder.Primary = true;
            this.BtnAddOrder.Size = new System.Drawing.Size(131, 36);
            this.BtnAddOrder.TabIndex = 1;
            this.BtnAddOrder.Text = "AGREGAR ORDEN";
            this.BtnAddOrder.UseMnemonic = false;
            this.BtnAddOrder.UseVisualStyleBackColor = true;
            this.BtnAddOrder.Click += new System.EventHandler(this.BtnAddOrder_Click);
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AllowUserToResizeColumns = false;
            this.dgvOrders.AllowUserToResizeRows = false;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(7, 7);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowHeadersVisible = false;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.ShowCellToolTips = false;
            this.dgvOrders.ShowEditingIcon = false;
            this.dgvOrders.Size = new System.Drawing.Size(831, 290);
            this.dgvOrders.TabIndex = 0;
            // 
            // tbShippers
            // 
            this.tbShippers.Controls.Add(this.dgvShippers);
            this.tbShippers.Controls.Add(this.BtnModifyShipper);
            this.tbShippers.Controls.Add(this.BtnDeleteShipper);
            this.tbShippers.Controls.Add(this.BtnAddShipper);
            this.tbShippers.Location = new System.Drawing.Point(4, 22);
            this.tbShippers.Name = "tbShippers";
            this.tbShippers.Padding = new System.Windows.Forms.Padding(3);
            this.tbShippers.Size = new System.Drawing.Size(1063, 345);
            this.tbShippers.TabIndex = 1;
            this.tbShippers.Text = "DISTRIBUIDORES";
            this.tbShippers.UseVisualStyleBackColor = true;
            // 
            // dgvShippers
            // 
            this.dgvShippers.AllowUserToAddRows = false;
            this.dgvShippers.AllowUserToDeleteRows = false;
            this.dgvShippers.AllowUserToResizeColumns = false;
            this.dgvShippers.AllowUserToResizeRows = false;
            this.dgvShippers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvShippers.BackgroundColor = System.Drawing.Color.White;
            this.dgvShippers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvShippers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShippers.Location = new System.Drawing.Point(7, 7);
            this.dgvShippers.Name = "dgvShippers";
            this.dgvShippers.ReadOnly = true;
            this.dgvShippers.RowHeadersVisible = false;
            this.dgvShippers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShippers.ShowCellToolTips = false;
            this.dgvShippers.ShowEditingIcon = false;
            this.dgvShippers.Size = new System.Drawing.Size(1050, 290);
            this.dgvShippers.TabIndex = 7;
            // 
            // BtnModifyShipper
            // 
            this.BtnModifyShipper.AutoSize = true;
            this.BtnModifyShipper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnModifyShipper.Depth = 0;
            this.BtnModifyShipper.Icon = null;
            this.BtnModifyShipper.Location = new System.Drawing.Point(373, 303);
            this.BtnModifyShipper.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnModifyShipper.Name = "BtnModifyShipper";
            this.BtnModifyShipper.Primary = true;
            this.BtnModifyShipper.Size = new System.Drawing.Size(187, 36);
            this.BtnModifyShipper.TabIndex = 6;
            this.BtnModifyShipper.Text = "MODIFICAR DISTRIBUIDOR";
            this.BtnModifyShipper.UseVisualStyleBackColor = true;
            this.BtnModifyShipper.Click += new System.EventHandler(this.BtnModifyShipper_Click);
            // 
            // BtnDeleteShipper
            // 
            this.BtnDeleteShipper.AutoSize = true;
            this.BtnDeleteShipper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnDeleteShipper.Depth = 0;
            this.BtnDeleteShipper.Icon = null;
            this.BtnDeleteShipper.Location = new System.Drawing.Point(190, 303);
            this.BtnDeleteShipper.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnDeleteShipper.Name = "BtnDeleteShipper";
            this.BtnDeleteShipper.Primary = true;
            this.BtnDeleteShipper.Size = new System.Drawing.Size(177, 36);
            this.BtnDeleteShipper.TabIndex = 5;
            this.BtnDeleteShipper.Text = "ELIMINAR DISTRIBUIDOR";
            this.BtnDeleteShipper.UseVisualStyleBackColor = true;
            this.BtnDeleteShipper.Click += new System.EventHandler(this.BtnDeleteShipper_Click);
            // 
            // BtnAddShipper
            // 
            this.BtnAddShipper.AutoSize = true;
            this.BtnAddShipper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAddShipper.Depth = 0;
            this.BtnAddShipper.Icon = null;
            this.BtnAddShipper.Location = new System.Drawing.Point(7, 303);
            this.BtnAddShipper.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAddShipper.Name = "BtnAddShipper";
            this.BtnAddShipper.Primary = true;
            this.BtnAddShipper.Size = new System.Drawing.Size(177, 36);
            this.BtnAddShipper.TabIndex = 4;
            this.BtnAddShipper.Text = "AGREGAR DISTRIBUIDOR";
            this.BtnAddShipper.UseMnemonic = false;
            this.BtnAddShipper.UseVisualStyleBackColor = true;
            this.BtnAddShipper.Click += new System.EventHandler(this.BtnAddShipper_Click);
            // 
            // tbSelector
            // 
            this.tbSelector.BaseTabControl = this.mainTabControl;
            this.tbSelector.Depth = 0;
            this.tbSelector.Location = new System.Drawing.Point(0, 60);
            this.tbSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbSelector.Name = "tbSelector";
            this.tbSelector.Size = new System.Drawing.Size(1251, 23);
            this.tbSelector.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 472);
            this.Controls.Add(this.tbSelector);
            this.Controls.Add(this.mainTabControl);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NORTHWIND SHIPPINGS LOG";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.mainTabControl.ResumeLayout(false);
            this.tbOrdenes.ResumeLayout(false);
            this.tbOrdenes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.tbShippers.ResumeLayout(false);
            this.tbShippers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShippers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl mainTabControl;
        private System.Windows.Forms.TabPage tbOrdenes;
        private System.Windows.Forms.TabPage tbShippers;
        private MaterialSkin.Controls.MaterialTabSelector tbSelector;
        private System.Windows.Forms.DataGridView dgvOrders;
        private MaterialSkin.Controls.MaterialRaisedButton BtnModifyOrder;
        private MaterialSkin.Controls.MaterialRaisedButton BtnDeleteOrder;
        private MaterialSkin.Controls.MaterialRaisedButton BtnAddOrder;
        private MaterialSkin.Controls.MaterialRaisedButton BtnModifyShipper;
        private MaterialSkin.Controls.MaterialRaisedButton BtnDeleteShipper;
        private MaterialSkin.Controls.MaterialRaisedButton BtnAddShipper;
        private System.Windows.Forms.DataGridView dgvShippers;
    }
}

