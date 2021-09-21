
namespace LabNet2021.TP04.GUI
{
    partial class FrmModifyOrder
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
            this.lblShippedDate = new MetroFramework.Controls.MetroLabel();
            this.lblShipName = new MetroFramework.Controls.MetroLabel();
            this.lblShipper = new MetroFramework.Controls.MetroLabel();
            this.lblAddress = new MetroFramework.Controls.MetroLabel();
            this.lblCity = new MetroFramework.Controls.MetroLabel();
            this.lblCountry = new MetroFramework.Controls.MetroLabel();
            this.txtShipName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.BtnModifyOrder = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblFormTitle = new MetroFramework.Controls.MetroLabel();
            this.dtpShippedDate = new System.Windows.Forms.DateTimePicker();
            this.cmbShippers = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblShippedDate
            // 
            this.lblShippedDate.AutoSize = true;
            this.lblShippedDate.Location = new System.Drawing.Point(17, 105);
            this.lblShippedDate.Name = "lblShippedDate";
            this.lblShippedDate.Size = new System.Drawing.Size(97, 19);
            this.lblShippedDate.TabIndex = 1;
            this.lblShippedDate.Text = "Fecha de Envio";
            // 
            // lblShipName
            // 
            this.lblShipName.AutoSize = true;
            this.lblShipName.Location = new System.Drawing.Point(17, 156);
            this.lblShipName.Name = "lblShipName";
            this.lblShipName.Size = new System.Drawing.Size(147, 19);
            this.lblShipName.TabIndex = 2;
            this.lblShipName.Text = "Nombre del Transporte";
            // 
            // lblShipper
            // 
            this.lblShipper.AutoSize = true;
            this.lblShipper.Location = new System.Drawing.Point(17, 131);
            this.lblShipper.Name = "lblShipper";
            this.lblShipper.Size = new System.Drawing.Size(77, 19);
            this.lblShipper.TabIndex = 3;
            this.lblShipper.Text = "Distribuidor";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(19, 183);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(63, 19);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Direccion";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(19, 209);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(51, 19);
            this.lblCity.TabIndex = 5;
            this.lblCity.Text = "Ciudad";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(19, 235);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(31, 19);
            this.lblCountry.TabIndex = 6;
            this.lblCountry.Text = "Pais";
            // 
            // txtShipName
            // 
            this.txtShipName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtShipName.Location = new System.Drawing.Point(170, 156);
            this.txtShipName.Name = "txtShipName";
            this.txtShipName.Size = new System.Drawing.Size(231, 20);
            this.txtShipName.TabIndex = 11;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Location = new System.Drawing.Point(170, 183);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(231, 20);
            this.txtAddress.TabIndex = 13;
            // 
            // txtCity
            // 
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCity.Location = new System.Drawing.Point(170, 208);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(231, 20);
            this.txtCity.TabIndex = 14;
            // 
            // txtCountry
            // 
            this.txtCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCountry.Location = new System.Drawing.Point(170, 235);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(231, 20);
            this.txtCountry.TabIndex = 15;
            // 
            // BtnModifyOrder
            // 
            this.BtnModifyOrder.AutoSize = true;
            this.BtnModifyOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnModifyOrder.Depth = 0;
            this.BtnModifyOrder.Icon = null;
            this.BtnModifyOrder.Location = new System.Drawing.Point(163, 303);
            this.BtnModifyOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnModifyOrder.Name = "BtnModifyOrder";
            this.BtnModifyOrder.Primary = true;
            this.BtnModifyOrder.Size = new System.Drawing.Size(141, 36);
            this.BtnModifyOrder.TabIndex = 17;
            this.BtnModifyOrder.Text = "MODIFICAR DATOS";
            this.BtnModifyOrder.UseVisualStyleBackColor = true;
            this.BtnModifyOrder.Click += new System.EventHandler(this.BtnModifyOrder_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.AutoSize = true;
            this.BtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCancel.Depth = 0;
            this.BtnCancel.Icon = null;
            this.BtnCancel.Location = new System.Drawing.Point(310, 303);
            this.BtnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Primary = true;
            this.BtnCancel.Size = new System.Drawing.Size(91, 36);
            this.BtnCancel.TabIndex = 18;
            this.BtnCancel.Text = "CANCELAR";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Location = new System.Drawing.Point(19, 76);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(219, 19);
            this.lblFormTitle.TabIndex = 19;
            this.lblFormTitle.Text = "ESCRIBA LOS DATOS A MODIFICAR";
            // 
            // dtpShippedDate
            // 
            this.dtpShippedDate.Location = new System.Drawing.Point(170, 103);
            this.dtpShippedDate.Name = "dtpShippedDate";
            this.dtpShippedDate.Size = new System.Drawing.Size(231, 20);
            this.dtpShippedDate.TabIndex = 20;
            // 
            // cmbShippers
            // 
            this.cmbShippers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShippers.FormattingEnabled = true;
            this.cmbShippers.Location = new System.Drawing.Point(170, 129);
            this.cmbShippers.Name = "cmbShippers";
            this.cmbShippers.Size = new System.Drawing.Size(231, 21);
            this.cmbShippers.TabIndex = 21;
            // 
            // FrmModifyOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 356);
            this.Controls.Add(this.cmbShippers);
            this.Controls.Add(this.dtpShippedDate);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnModifyOrder);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtShipName);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblShipper);
            this.Controls.Add(this.lblShipName);
            this.Controls.Add(this.lblShippedDate);
            this.Name = "FrmModifyOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MODIFICAR INFORMACION DE LA ORDEN";
            this.Load += new System.EventHandler(this.FrmModifyOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lblShippedDate;
        private MetroFramework.Controls.MetroLabel lblShipName;
        private MetroFramework.Controls.MetroLabel lblShipper;
        private MetroFramework.Controls.MetroLabel lblAddress;
        private MetroFramework.Controls.MetroLabel lblCity;
        private MetroFramework.Controls.MetroLabel lblCountry;
        private System.Windows.Forms.TextBox txtShipName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtCountry;
        private MaterialSkin.Controls.MaterialRaisedButton BtnModifyOrder;
        private MaterialSkin.Controls.MaterialRaisedButton BtnCancel;
        private MetroFramework.Controls.MetroLabel lblFormTitle;
        private System.Windows.Forms.DateTimePicker dtpShippedDate;
        private System.Windows.Forms.ComboBox cmbShippers;
    }
}