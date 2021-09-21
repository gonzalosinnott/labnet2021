
namespace LabNet2021.TP04.GUI
{
    partial class FrmAddShipper
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
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblFormTitle = new MetroFramework.Controls.MetroLabel();
            this.BtnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnAddEmployee = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPhone = new MetroFramework.Controls.MetroLabel();
            this.lblShipperName = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Location = new System.Drawing.Point(171, 143);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(231, 20);
            this.txtPhone.TabIndex = 56;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Location = new System.Drawing.Point(12, 76);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(295, 19);
            this.lblFormTitle.TabIndex = 55;
            this.lblFormTitle.Text = "ESCRIBA LOS DATOS DEL NUEVO DISTRIBUIDOR";
            // 
            // BtnCancel
            // 
            this.BtnCancel.AutoSize = true;
            this.BtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCancel.Depth = 0;
            this.BtnCancel.Icon = null;
            this.BtnCancel.Location = new System.Drawing.Point(305, 289);
            this.BtnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Primary = true;
            this.BtnCancel.Size = new System.Drawing.Size(91, 36);
            this.BtnCancel.TabIndex = 54;
            this.BtnCancel.Text = "CANCELAR";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnAddEmployee
            // 
            this.BtnAddEmployee.AutoSize = true;
            this.BtnAddEmployee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAddEmployee.Depth = 0;
            this.BtnAddEmployee.Icon = null;
            this.BtnAddEmployee.Location = new System.Drawing.Point(119, 289);
            this.BtnAddEmployee.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAddEmployee.Name = "BtnAddEmployee";
            this.BtnAddEmployee.Primary = true;
            this.BtnAddEmployee.Size = new System.Drawing.Size(180, 36);
            this.BtnAddEmployee.TabIndex = 53;
            this.BtnAddEmployee.Text = "INGRESAR DISTRIBUIDOR";
            this.BtnAddEmployee.UseVisualStyleBackColor = true;
            this.BtnAddEmployee.Click += new System.EventHandler(this.BtnAddShipper_Click);
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(171, 117);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(231, 20);
            this.txtName.TabIndex = 48;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(12, 136);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(58, 19);
            this.lblPhone.TabIndex = 45;
            this.lblPhone.Text = "Telefono";
            // 
            // lblShipperName
            // 
            this.lblShipperName.AutoSize = true;
            this.lblShipperName.Location = new System.Drawing.Point(12, 117);
            this.lblShipperName.Name = "lblShipperName";
            this.lblShipperName.Size = new System.Drawing.Size(157, 19);
            this.lblShipperName.TabIndex = 41;
            this.lblShipperName.Text = "Nombre de la Compañia";
            // 
            // FrmAddShipper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 352);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAddEmployee);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblShipperName);
            this.Name = "FrmAddShipper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CARGAR DISTRIBUIDOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPhone;
        private MetroFramework.Controls.MetroLabel lblFormTitle;
        private MaterialSkin.Controls.MaterialRaisedButton BtnCancel;
        private MaterialSkin.Controls.MaterialRaisedButton BtnAddEmployee;
        private System.Windows.Forms.TextBox txtName;
        private MetroFramework.Controls.MetroLabel lblPhone;
        private MetroFramework.Controls.MetroLabel lblShipperName;
    }
}