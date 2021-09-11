
namespace GUI
{
    partial class frmMain
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
            this.btnDivideby0 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nud1 = new System.Windows.Forms.NumericUpDown();
            this.txbNumber1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCustomException = new System.Windows.Forms.Button();
            this.btnSystemException = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbNumber2 = new System.Windows.Forms.TextBox();
            this.btnDividir = new System.Windows.Forms.Button();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDivideby0
            // 
            this.btnDivideby0.Location = new System.Drawing.Point(61, 3);
            this.btnDivideby0.Name = "btnDivideby0";
            this.btnDivideby0.Size = new System.Drawing.Size(132, 27);
            this.btnDivideby0.TabIndex = 0;
            this.btnDivideby0.Text = "DIVIDIR POR 0";
            this.btnDivideby0.UseVisualStyleBackColor = true;
            this.btnDivideby0.Click += new System.EventHandler(this.btnDivideby0_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.nud1);
            this.panel1.Controls.Add(this.btnDivideby0);
            this.panel1.Location = new System.Drawing.Point(12, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 42);
            this.panel1.TabIndex = 2;
            // 
            // nud1
            // 
            this.nud1.Location = new System.Drawing.Point(6, 8);
            this.nud1.Name = "nud1";
            this.nud1.Size = new System.Drawing.Size(49, 20);
            this.nud1.TabIndex = 1;
            // 
            // txbNumber1
            // 
            this.txbNumber1.Location = new System.Drawing.Point(3, 21);
            this.txbNumber1.Name = "txbNumber1";
            this.txbNumber1.Size = new System.Drawing.Size(49, 20);
            this.txbNumber1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnCustomException);
            this.panel2.Controls.Add(this.btnSystemException);
            this.panel2.Location = new System.Drawing.Point(230, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 126);
            this.panel2.TabIndex = 4;
            // 
            // btnCustomException
            // 
            this.btnCustomException.Location = new System.Drawing.Point(98, 8);
            this.btnCustomException.Name = "btnCustomException";
            this.btnCustomException.Size = new System.Drawing.Size(122, 110);
            this.btnCustomException.TabIndex = 10;
            this.btnCustomException.Text = "EXCEPCION PERSONALIZADA";
            this.btnCustomException.UseVisualStyleBackColor = true;
            this.btnCustomException.Click += new System.EventHandler(this.btnCustomException_Click);
            // 
            // btnSystemException
            // 
            this.btnSystemException.Location = new System.Drawing.Point(3, 7);
            this.btnSystemException.Name = "btnSystemException";
            this.btnSystemException.Size = new System.Drawing.Size(89, 110);
            this.btnSystemException.TabIndex = 9;
            this.btnSystemException.Text = "EXCEPCION DE SISTEMA";
            this.btnSystemException.UseVisualStyleBackColor = true;
            this.btnSystemException.Click += new System.EventHandler(this.btnSystemException_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txbNumber2);
            this.panel4.Controls.Add(this.btnDividir);
            this.panel4.Controls.Add(this.lblNumber2);
            this.panel4.Controls.Add(this.lblNumber1);
            this.panel4.Controls.Add(this.txbNumber1);
            this.panel4.Location = new System.Drawing.Point(12, 105);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 54);
            this.panel4.TabIndex = 3;
            // 
            // txbNumber2
            // 
            this.txbNumber2.Location = new System.Drawing.Point(58, 21);
            this.txbNumber2.Name = "txbNumber2";
            this.txbNumber2.Size = new System.Drawing.Size(49, 20);
            this.txbNumber2.TabIndex = 11;
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(113, 14);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(75, 27);
            this.btnDividir.TabIndex = 10;
            this.btnDividir.Text = "DIVIDIR";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // lblNumber2
            // 
            this.lblNumber2.AutoSize = true;
            this.lblNumber2.Location = new System.Drawing.Point(55, 5);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(28, 13);
            this.lblNumber2.TabIndex = 8;
            this.lblNumber2.Text = "N° 2";
            // 
            // lblNumber1
            // 
            this.lblNumber1.AutoSize = true;
            this.lblNumber1.Location = new System.Drawing.Point(3, 5);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(28, 13);
            this.lblNumber1.TabIndex = 7;
            this.lblNumber1.Text = "N° 1";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(13, 14);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(95, 13);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "Test Division por 0";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(12, 89);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(68, 13);
            this.lbl2.TabIndex = 6;
            this.lbl2.Text = "Test Division";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(227, 9);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(92, 13);
            this.lbl3.TabIndex = 7;
            this.lbl3.Text = "Test Excepciones";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 175);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP02";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDivideby0;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbNumber1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSystemException;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Button btnCustomException;
        private System.Windows.Forms.TextBox txbNumber2;
        private System.Windows.Forms.NumericUpDown nud1;
    }
}

