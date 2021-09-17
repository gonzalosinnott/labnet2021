
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
            this.btnModifyClient = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnDeleteCustomer = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAddCustomer = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnModifyEmployee = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnDeleteEmployee = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAddEmployee = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
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
            this.tabPage1.Controls.Add(this.btnModifyClient);
            this.tabPage1.Controls.Add(this.btnDeleteCustomer);
            this.tabPage1.Controls.Add(this.btnAddCustomer);
            this.tabPage1.Controls.Add(this.dgvCustomers);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1063, 345);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnModifyClient
            // 
            this.btnModifyClient.AutoSize = true;
            this.btnModifyClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModifyClient.Depth = 0;
            this.btnModifyClient.Icon = null;
            this.btnModifyClient.Location = new System.Drawing.Point(300, 303);
            this.btnModifyClient.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModifyClient.Name = "btnModifyClient";
            this.btnModifyClient.Primary = true;
            this.btnModifyClient.Size = new System.Drawing.Size(151, 36);
            this.btnModifyClient.TabIndex = 3;
            this.btnModifyClient.Text = "MODIFICAR CLIENTE";
            this.btnModifyClient.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.AutoSize = true;
            this.btnDeleteCustomer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteCustomer.Depth = 0;
            this.btnDeleteCustomer.Icon = null;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(153, 303);
            this.btnDeleteCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Primary = true;
            this.btnDeleteCustomer.Size = new System.Drawing.Size(141, 36);
            this.btnDeleteCustomer.TabIndex = 2;
            this.btnDeleteCustomer.Text = "ELIMINAR CLIENTE";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.AutoSize = true;
            this.btnAddCustomer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddCustomer.Depth = 0;
            this.btnAddCustomer.Icon = null;
            this.btnAddCustomer.Location = new System.Drawing.Point(7, 303);
            this.btnAddCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Primary = true;
            this.btnAddCustomer.Size = new System.Drawing.Size(140, 36);
            this.btnAddCustomer.TabIndex = 1;
            this.btnAddCustomer.Text = "AGREGAR CLIENTE";
            this.btnAddCustomer.UseMnemonic = false;
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
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
            this.tabPage2.Controls.Add(this.btnModifyEmployee);
            this.tabPage2.Controls.Add(this.btnDeleteEmployee);
            this.tabPage2.Controls.Add(this.btnAddEmployee);
            this.tabPage2.Controls.Add(this.dgvEmployees);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1063, 345);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Employees";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnModifyEmployee
            // 
            this.btnModifyEmployee.AutoSize = true;
            this.btnModifyEmployee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModifyEmployee.Depth = 0;
            this.btnModifyEmployee.Icon = null;
            this.btnModifyEmployee.Location = new System.Drawing.Point(335, 303);
            this.btnModifyEmployee.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModifyEmployee.Name = "btnModifyEmployee";
            this.btnModifyEmployee.Primary = true;
            this.btnModifyEmployee.Size = new System.Drawing.Size(168, 36);
            this.btnModifyEmployee.TabIndex = 6;
            this.btnModifyEmployee.Text = "MODIFICAR EMPLEADO";
            this.btnModifyEmployee.UseVisualStyleBackColor = true;
            this.btnModifyEmployee.Click += new System.EventHandler(this.btnModifyEmployee_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.AutoSize = true;
            this.btnDeleteEmployee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteEmployee.Depth = 0;
            this.btnDeleteEmployee.Icon = null;
            this.btnDeleteEmployee.Location = new System.Drawing.Point(171, 303);
            this.btnDeleteEmployee.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Primary = true;
            this.btnDeleteEmployee.Size = new System.Drawing.Size(158, 36);
            this.btnDeleteEmployee.TabIndex = 5;
            this.btnDeleteEmployee.Text = "ELIMINAR EMPELADO";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.AutoSize = true;
            this.btnAddEmployee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddEmployee.Depth = 0;
            this.btnAddEmployee.Icon = null;
            this.btnAddEmployee.Location = new System.Drawing.Point(7, 303);
            this.btnAddEmployee.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Primary = true;
            this.btnAddEmployee.Size = new System.Drawing.Size(158, 36);
            this.btnAddEmployee.TabIndex = 4;
            this.btnAddEmployee.Text = "AGREGAR EMPLEADO";
            this.btnAddEmployee.UseMnemonic = false;
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
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
            this.dgvEmployees.Location = new System.Drawing.Point(7, 6);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.ShowCellToolTips = false;
            this.dgvEmployees.ShowEditingIcon = false;
            this.dgvEmployees.Size = new System.Drawing.Size(1050, 291);
            this.dgvEmployees.TabIndex = 1;
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
        private System.Windows.Forms.DataGridView dgvEmployees;
        private MaterialSkin.Controls.MaterialRaisedButton btnModifyClient;
        private MaterialSkin.Controls.MaterialRaisedButton btnDeleteCustomer;
        private MaterialSkin.Controls.MaterialRaisedButton btnAddCustomer;
        private MaterialSkin.Controls.MaterialRaisedButton btnModifyEmployee;
        private MaterialSkin.Controls.MaterialRaisedButton btnDeleteEmployee;
        private MaterialSkin.Controls.MaterialRaisedButton btnAddEmployee;
    }
}

