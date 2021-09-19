
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnModifyCostumer = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnDeleteCustomer = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnAddCustomer = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.BtnModifyEmployee = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnDeleteEmployee = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnAddEmployee = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tbSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.mainTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tabPage1);
            this.mainTabControl.Controls.Add(this.tabPage2);
            this.mainTabControl.Depth = 0;
            this.mainTabControl.Location = new System.Drawing.Point(12, 89);
            this.mainTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1071, 371);
            this.mainTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnModifyCostumer);
            this.tabPage1.Controls.Add(this.BtnDeleteCustomer);
            this.tabPage1.Controls.Add(this.BtnAddCustomer);
            this.tabPage1.Controls.Add(this.dgvCustomers);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1063, 345);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CLIENTES";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnModifyCostumer
            // 
            this.BtnModifyCostumer.AutoSize = true;
            this.BtnModifyCostumer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnModifyCostumer.Depth = 0;
            this.BtnModifyCostumer.Icon = null;
            this.BtnModifyCostumer.Location = new System.Drawing.Point(300, 303);
            this.BtnModifyCostumer.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnModifyCostumer.Name = "BtnModifyCostumer";
            this.BtnModifyCostumer.Primary = true;
            this.BtnModifyCostumer.Size = new System.Drawing.Size(151, 36);
            this.BtnModifyCostumer.TabIndex = 3;
            this.BtnModifyCostumer.Text = "MODIFICAR CLIENTE";
            this.BtnModifyCostumer.UseVisualStyleBackColor = true;
            this.BtnModifyCostumer.Click += new System.EventHandler(this.BtnModifyCostumer_Click);
            // 
            // BtnDeleteCustomer
            // 
            this.BtnDeleteCustomer.AutoSize = true;
            this.BtnDeleteCustomer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnDeleteCustomer.Depth = 0;
            this.BtnDeleteCustomer.Icon = null;
            this.BtnDeleteCustomer.Location = new System.Drawing.Point(153, 303);
            this.BtnDeleteCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnDeleteCustomer.Name = "BtnDeleteCustomer";
            this.BtnDeleteCustomer.Primary = true;
            this.BtnDeleteCustomer.Size = new System.Drawing.Size(141, 36);
            this.BtnDeleteCustomer.TabIndex = 2;
            this.BtnDeleteCustomer.Text = "ELIMINAR CLIENTE";
            this.BtnDeleteCustomer.UseVisualStyleBackColor = true;
            this.BtnDeleteCustomer.Click += new System.EventHandler(this.BtnDeleteCustomer_Click);
            // 
            // BtnAddCustomer
            // 
            this.BtnAddCustomer.AutoSize = true;
            this.BtnAddCustomer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAddCustomer.Depth = 0;
            this.BtnAddCustomer.Icon = null;
            this.BtnAddCustomer.Location = new System.Drawing.Point(7, 303);
            this.BtnAddCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAddCustomer.Name = "BtnAddCustomer";
            this.BtnAddCustomer.Primary = true;
            this.BtnAddCustomer.Size = new System.Drawing.Size(140, 36);
            this.BtnAddCustomer.TabIndex = 1;
            this.BtnAddCustomer.Text = "AGREGAR CLIENTE";
            this.BtnAddCustomer.UseMnemonic = false;
            this.BtnAddCustomer.UseVisualStyleBackColor = true;
            this.BtnAddCustomer.Click += new System.EventHandler(this.BtnAddCustomer_Click);
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AllowUserToResizeColumns = false;
            this.dgvCustomers.AllowUserToResizeRows = false;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCustomers.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(7, 7);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.ShowCellToolTips = false;
            this.dgvCustomers.ShowEditingIcon = false;
            this.dgvCustomers.Size = new System.Drawing.Size(1050, 290);
            this.dgvCustomers.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvEmployees);
            this.tabPage2.Controls.Add(this.BtnModifyEmployee);
            this.tabPage2.Controls.Add(this.BtnDeleteEmployee);
            this.tabPage2.Controls.Add(this.BtnAddEmployee);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1063, 345);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "EMPLEADOS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.AllowUserToResizeColumns = false;
            this.dgvEmployees.AllowUserToResizeRows = false;
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(7, 7);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.ShowCellToolTips = false;
            this.dgvEmployees.ShowEditingIcon = false;
            this.dgvEmployees.Size = new System.Drawing.Size(1050, 290);
            this.dgvEmployees.TabIndex = 7;
            // 
            // BtnModifyEmployee
            // 
            this.BtnModifyEmployee.AutoSize = true;
            this.BtnModifyEmployee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnModifyEmployee.Depth = 0;
            this.BtnModifyEmployee.Icon = null;
            this.BtnModifyEmployee.Location = new System.Drawing.Point(335, 303);
            this.BtnModifyEmployee.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnModifyEmployee.Name = "BtnModifyEmployee";
            this.BtnModifyEmployee.Primary = true;
            this.BtnModifyEmployee.Size = new System.Drawing.Size(168, 36);
            this.BtnModifyEmployee.TabIndex = 6;
            this.BtnModifyEmployee.Text = "MODIFICAR EMPLEADO";
            this.BtnModifyEmployee.UseVisualStyleBackColor = true;
            this.BtnModifyEmployee.Click += new System.EventHandler(this.BtnModifyEmployee_Click);
            // 
            // BtnDeleteEmployee
            // 
            this.BtnDeleteEmployee.AutoSize = true;
            this.BtnDeleteEmployee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnDeleteEmployee.Depth = 0;
            this.BtnDeleteEmployee.Icon = null;
            this.BtnDeleteEmployee.Location = new System.Drawing.Point(171, 303);
            this.BtnDeleteEmployee.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnDeleteEmployee.Name = "BtnDeleteEmployee";
            this.BtnDeleteEmployee.Primary = true;
            this.BtnDeleteEmployee.Size = new System.Drawing.Size(158, 36);
            this.BtnDeleteEmployee.TabIndex = 5;
            this.BtnDeleteEmployee.Text = "ELIMINAR EMPLEADO";
            this.BtnDeleteEmployee.UseVisualStyleBackColor = true;
            this.BtnDeleteEmployee.Click += new System.EventHandler(this.BtnDeleteEmployee_Click);
            // 
            // BtnAddEmployee
            // 
            this.BtnAddEmployee.AutoSize = true;
            this.BtnAddEmployee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAddEmployee.Depth = 0;
            this.BtnAddEmployee.Icon = null;
            this.BtnAddEmployee.Location = new System.Drawing.Point(7, 303);
            this.BtnAddEmployee.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAddEmployee.Name = "BtnAddEmployee";
            this.BtnAddEmployee.Primary = true;
            this.BtnAddEmployee.Size = new System.Drawing.Size(158, 36);
            this.BtnAddEmployee.TabIndex = 4;
            this.BtnAddEmployee.Text = "AGREGAR EMPLEADO";
            this.BtnAddEmployee.UseMnemonic = false;
            this.BtnAddEmployee.UseVisualStyleBackColor = true;
            this.BtnAddEmployee.Click += new System.EventHandler(this.BtnAddEmployee_Click);
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
            this.ClientSize = new System.Drawing.Size(1096, 472);
            this.Controls.Add(this.tbSelector);
            this.Controls.Add(this.mainTabControl);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NORTHWIND CONTACTS MANAGER";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.mainTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl mainTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector tbSelector;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private MaterialSkin.Controls.MaterialRaisedButton BtnModifyCostumer;
        private MaterialSkin.Controls.MaterialRaisedButton BtnDeleteCustomer;
        private MaterialSkin.Controls.MaterialRaisedButton BtnAddCustomer;
        private MaterialSkin.Controls.MaterialRaisedButton BtnModifyEmployee;
        private MaterialSkin.Controls.MaterialRaisedButton BtnDeleteEmployee;
        private MaterialSkin.Controls.MaterialRaisedButton BtnAddEmployee;
        private System.Windows.Forms.DataGridView dgvEmployees;
    }
}

