
namespace LabNet2021.TP05.GUI
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
            this.btnQuery1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbQuery = new MaterialSkin.Controls.MaterialLabel();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnQuery2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnQuery3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnQuery4 = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuery1
            // 
            this.btnQuery1.AutoSize = true;
            this.btnQuery1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQuery1.Depth = 0;
            this.btnQuery1.Icon = null;
            this.btnQuery1.Location = new System.Drawing.Point(27, 381);
            this.btnQuery1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnQuery1.Name = "btnQuery1";
            this.btnQuery1.Primary = true;
            this.btnQuery1.Size = new System.Drawing.Size(75, 36);
            this.btnQuery1.TabIndex = 1;
            this.btnQuery1.Text = "QUERY 1";
            this.btnQuery1.UseVisualStyleBackColor = true;
            this.btnQuery1.Click += new System.EventHandler(this.btnQuery1_Click);
            // 
            // lbQuery
            // 
            this.lbQuery.AutoSize = true;
            this.lbQuery.Depth = 0;
            this.lbQuery.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbQuery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbQuery.Location = new System.Drawing.Point(27, 85);
            this.lbQuery.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbQuery.Name = "lbQuery";
            this.lbQuery.Size = new System.Drawing.Size(0, 19);
            this.lbQuery.TabIndex = 2;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeColumns = false;
            this.dgvData.AllowUserToResizeRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvData.Location = new System.Drawing.Point(27, 108);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.Size = new System.Drawing.Size(1125, 267);
            this.dgvData.TabIndex = 3;
            // 
            // btnQuery2
            // 
            this.btnQuery2.AutoSize = true;
            this.btnQuery2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQuery2.Depth = 0;
            this.btnQuery2.Icon = null;
            this.btnQuery2.Location = new System.Drawing.Point(108, 381);
            this.btnQuery2.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnQuery2.Name = "btnQuery2";
            this.btnQuery2.Primary = true;
            this.btnQuery2.Size = new System.Drawing.Size(75, 36);
            this.btnQuery2.TabIndex = 4;
            this.btnQuery2.Text = "QUERY 2";
            this.btnQuery2.UseVisualStyleBackColor = true;
            this.btnQuery2.Click += new System.EventHandler(this.btnQuery2_Click);
            // 
            // btnQuery3
            // 
            this.btnQuery3.AutoSize = true;
            this.btnQuery3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQuery3.Depth = 0;
            this.btnQuery3.Icon = null;
            this.btnQuery3.Location = new System.Drawing.Point(189, 381);
            this.btnQuery3.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnQuery3.Name = "btnQuery3";
            this.btnQuery3.Primary = true;
            this.btnQuery3.Size = new System.Drawing.Size(75, 36);
            this.btnQuery3.TabIndex = 5;
            this.btnQuery3.Text = "QUERY 3";
            this.btnQuery3.UseVisualStyleBackColor = true;
            this.btnQuery3.Click += new System.EventHandler(this.btnQuery3_Click);
            // 
            // btnQuery4
            // 
            this.btnQuery4.AutoSize = true;
            this.btnQuery4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQuery4.Depth = 0;
            this.btnQuery4.Icon = null;
            this.btnQuery4.Location = new System.Drawing.Point(270, 381);
            this.btnQuery4.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnQuery4.Name = "btnQuery4";
            this.btnQuery4.Primary = true;
            this.btnQuery4.Size = new System.Drawing.Size(75, 36);
            this.btnQuery4.TabIndex = 6;
            this.btnQuery4.Text = "QUERY 4";
            this.btnQuery4.UseVisualStyleBackColor = true;
            this.btnQuery4.Click += new System.EventHandler(this.btnQuery4_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 521);
            this.Controls.Add(this.btnQuery4);
            this.Controls.Add(this.btnQuery3);
            this.Controls.Add(this.btnQuery2);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.lbQuery);
            this.Controls.Add(this.btnQuery1);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton btnQuery1;
        private MaterialSkin.Controls.MaterialLabel lbQuery;
        private System.Windows.Forms.DataGridView dgvData;
        private MaterialSkin.Controls.MaterialRaisedButton btnQuery2;
        private MaterialSkin.Controls.MaterialRaisedButton btnQuery3;
        private MaterialSkin.Controls.MaterialRaisedButton btnQuery4;
    }
}