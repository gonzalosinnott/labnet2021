
namespace LabNet2021.TP04.GUI
{
    partial class FrmAddOrder
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
            this.lblFormTitle = new MetroFramework.Controls.MetroLabel();
            this.BtnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnAddOrder = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtShipName = new System.Windows.Forms.TextBox();
            this.lblCountry = new MetroFramework.Controls.MetroLabel();
            this.lblCity = new MetroFramework.Controls.MetroLabel();
            this.lblAddress = new MetroFramework.Controls.MetroLabel();
            this.lblShipper = new MetroFramework.Controls.MetroLabel();
            this.lblShipName = new MetroFramework.Controls.MetroLabel();
            this.lblShippedDate = new MetroFramework.Controls.MetroLabel();
            this.dtpShipedDate = new System.Windows.Forms.DateTimePicker();
            this.cmbShippers = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Location = new System.Drawing.Point(12, 72);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(266, 19);
            this.lblFormTitle.TabIndex = 36;
            this.lblFormTitle.Text = "ESCRIBA LOS DATOS DE LA NUEVA ORDEN";
            // 
            // BtnCancel
            // 
            this.BtnCancel.AutoSize = true;
            this.BtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCancel.Depth = 0;
            this.BtnCancel.Icon = null;
            this.BtnCancel.Location = new System.Drawing.Point(306, 303);
            this.BtnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Primary = true;
            this.BtnCancel.Size = new System.Drawing.Size(91, 36);
            this.BtnCancel.TabIndex = 35;
            this.BtnCancel.Text = "CANCELAR";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click_1);
            // 
            // BtnAddOrder
            // 
            this.BtnAddOrder.AutoSize = true;
            this.BtnAddOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAddOrder.Depth = 0;
            this.BtnAddOrder.Icon = null;
            this.BtnAddOrder.Location = new System.Drawing.Point(165, 303);
            this.BtnAddOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAddOrder.Name = "BtnAddOrder";
            this.BtnAddOrder.Primary = true;
            this.BtnAddOrder.Size = new System.Drawing.Size(134, 36);
            this.BtnAddOrder.TabIndex = 34;
            this.BtnAddOrder.Text = "INGRESAR ORDEN";
            this.BtnAddOrder.UseVisualStyleBackColor = true;
            this.BtnAddOrder.Click += new System.EventHandler(this.BtnAddOrder_Click);
            // 
            // txtCountry
            // 
            this.txtCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCountry.Location = new System.Drawing.Point(165, 229);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(231, 20);
            this.txtCountry.TabIndex = 33;
            // 
            // txtCity
            // 
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCity.Location = new System.Drawing.Point(165, 204);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(231, 20);
            this.txtCity.TabIndex = 32;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Location = new System.Drawing.Point(165, 177);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(231, 20);
            this.txtAddress.TabIndex = 31;
            // 
            // txtShipName
            // 
            this.txtShipName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtShipName.Location = new System.Drawing.Point(165, 152);
            this.txtShipName.Name = "txtShipName";
            this.txtShipName.Size = new System.Drawing.Size(231, 20);
            this.txtShipName.TabIndex = 30;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(14, 230);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(31, 19);
            this.lblCountry.TabIndex = 25;
            this.lblCountry.Text = "Pais";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(14, 204);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(51, 19);
            this.lblCity.TabIndex = 24;
            this.lblCity.Text = "Ciudad";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(14, 178);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(63, 19);
            this.lblAddress.TabIndex = 23;
            this.lblAddress.Text = "Direccion";
            // 
            // lblShipper
            // 
            this.lblShipper.AutoSize = true;
            this.lblShipper.Location = new System.Drawing.Point(12, 126);
            this.lblShipper.Name = "lblShipper";
            this.lblShipper.Size = new System.Drawing.Size(77, 19);
            this.lblShipper.TabIndex = 22;
            this.lblShipper.Text = "Distribuidor";
            // 
            // lblShipName
            // 
            this.lblShipName.AutoSize = true;
            this.lblShipName.Location = new System.Drawing.Point(12, 151);
            this.lblShipName.Name = "lblShipName";
            this.lblShipName.Size = new System.Drawing.Size(147, 19);
            this.lblShipName.TabIndex = 21;
            this.lblShipName.Text = "Nombre del Transporte";
            // 
            // lblShippedDate
            // 
            this.lblShippedDate.AutoSize = true;
            this.lblShippedDate.Location = new System.Drawing.Point(12, 100);
            this.lblShippedDate.Name = "lblShippedDate";
            this.lblShippedDate.Size = new System.Drawing.Size(97, 19);
            this.lblShippedDate.TabIndex = 20;
            this.lblShippedDate.Text = "Fecha de Envio";
            // 
            // dtpShipedDate
            // 
            this.dtpShipedDate.Location = new System.Drawing.Point(165, 100);
            this.dtpShipedDate.Name = "dtpShipedDate";
            this.dtpShipedDate.Size = new System.Drawing.Size(231, 20);
            this.dtpShipedDate.TabIndex = 38;
            // 
            // cmbShippers
            // 
            this.cmbShippers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShippers.FormattingEnabled = true;
            this.cmbShippers.Location = new System.Drawing.Point(165, 127);
            this.cmbShippers.Name = "cmbShippers";
            this.cmbShippers.Size = new System.Drawing.Size(231, 21);
            this.cmbShippers.Sorted = true;
            this.cmbShippers.TabIndex = 39;
            // 
            // FrmAddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 354);
            this.Controls.Add(this.cmbShippers);
            this.Controls.Add(this.dtpShipedDate);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAddOrder);
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
            this.Name = "FrmAddOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INGRESO DE NUEVA ORDEN";
            this.Load += new System.EventHandler(this.FrmAddOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblFormTitle;
        private MaterialSkin.Controls.MaterialRaisedButton BtnCancel;
        private MaterialSkin.Controls.MaterialRaisedButton BtnAddOrder;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtShipName;
        private MetroFramework.Controls.MetroLabel lblCountry;
        private MetroFramework.Controls.MetroLabel lblCity;
        private MetroFramework.Controls.MetroLabel lblAddress;
        private MetroFramework.Controls.MetroLabel lblShipper;
        private MetroFramework.Controls.MetroLabel lblShipName;
        private MetroFramework.Controls.MetroLabel lblShippedDate;
        private System.Windows.Forms.DateTimePicker dtpShipedDate;
        private System.Windows.Forms.ComboBox cmbShippers;
    }
}