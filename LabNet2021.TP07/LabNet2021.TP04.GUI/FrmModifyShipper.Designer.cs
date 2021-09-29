
namespace LabNet2021.TP04.GUI
{
    partial class FrmModifyShipper
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
            this.BtnModifyShipper = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPhone = new MetroFramework.Controls.MetroLabel();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Location = new System.Drawing.Point(12, 70);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(219, 19);
            this.lblFormTitle.TabIndex = 36;
            this.lblFormTitle.Text = "ESCRIBA LOS DATOS A MODIFICAR";
            // 
            // BtnCancel
            // 
            this.BtnCancel.AutoSize = true;
            this.BtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCancel.Depth = 0;
            this.BtnCancel.Icon = null;
            this.BtnCancel.Location = new System.Drawing.Point(303, 297);
            this.BtnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Primary = true;
            this.BtnCancel.Size = new System.Drawing.Size(91, 36);
            this.BtnCancel.TabIndex = 35;
            this.BtnCancel.Text = "CANCELAR";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnModifyShipper
            // 
            this.BtnModifyShipper.AutoSize = true;
            this.BtnModifyShipper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnModifyShipper.Depth = 0;
            this.BtnModifyShipper.Icon = null;
            this.BtnModifyShipper.Location = new System.Drawing.Point(156, 297);
            this.BtnModifyShipper.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnModifyShipper.Name = "BtnModifyShipper";
            this.BtnModifyShipper.Primary = true;
            this.BtnModifyShipper.Size = new System.Drawing.Size(141, 36);
            this.BtnModifyShipper.TabIndex = 34;
            this.BtnModifyShipper.Text = "MODIFICAR DATOS";
            this.BtnModifyShipper.UseVisualStyleBackColor = true;
            this.BtnModifyShipper.Click += new System.EventHandler(this.BtnModifyEmployee_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Location = new System.Drawing.Point(163, 125);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(231, 20);
            this.txtPhone.TabIndex = 33;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(163, 99);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(231, 20);
            this.txtName.TabIndex = 29;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(11, 125);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(58, 19);
            this.lblPhone.TabIndex = 26;
            this.lblPhone.Text = "Telefono";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(11, 100);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 19);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "Nombre";
            // 
            // FrmModifyShipper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 346);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnModifyShipper);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblName);
            this.Name = "FrmModifyShipper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MODIFICAR DATOS DE DISTRIBUIDOR";
            this.Load += new System.EventHandler(this.FrmModifyEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblFormTitle;
        private MaterialSkin.Controls.MaterialRaisedButton BtnCancel;
        private MaterialSkin.Controls.MaterialRaisedButton BtnModifyShipper;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private MetroFramework.Controls.MetroLabel lblPhone;
        private MetroFramework.Controls.MetroLabel lblName;
    }
}