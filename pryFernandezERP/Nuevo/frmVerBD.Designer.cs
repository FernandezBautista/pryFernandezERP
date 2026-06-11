namespace pryFernandezERP
{
    partial class frmVerBD
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerBD));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dgvBD = new System.Windows.Forms.DataGridView();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.cmbBD = new System.Windows.Forms.ComboBox();
            this.btnBuscarBD = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBD)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(185)))), ((int)(((byte)(154)))));
            this.statusStrip1.Location = new System.Drawing.Point(3, 368);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(629, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dgvBD
            // 
            this.dgvBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBD.Location = new System.Drawing.Point(6, 103);
            this.dgvBD.Name = "dgvBD";
            this.dgvBD.Size = new System.Drawing.Size(623, 262);
            this.dgvBD.TabIndex = 2;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(6, 78);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(58, 13);
            this.lblBuscar.TabIndex = 4;
            this.lblBuscar.Text = "Buscar BD";
            // 
            // cmbBD
            // 
            this.cmbBD.FormattingEnabled = true;
            this.cmbBD.Location = new System.Drawing.Point(93, 75);
            this.cmbBD.Name = "cmbBD";
            this.cmbBD.Size = new System.Drawing.Size(156, 21);
            this.cmbBD.TabIndex = 5;
            // 
            // btnBuscarBD
            // 
            this.btnBuscarBD.AutoSize = false;
            this.btnBuscarBD.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscarBD.Depth = 0;
            this.btnBuscarBD.HighEmphasis = true;
            this.btnBuscarBD.Icon = null;
            this.btnBuscarBD.Location = new System.Drawing.Point(256, 75);
            this.btnBuscarBD.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscarBD.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarBD.Name = "btnBuscarBD";
            this.btnBuscarBD.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuscarBD.Size = new System.Drawing.Size(98, 21);
            this.btnBuscarBD.TabIndex = 13;
            this.btnBuscarBD.Text = "Buscar";
            this.btnBuscarBD.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscarBD.UseAccentColor = false;
            this.btnBuscarBD.UseVisualStyleBackColor = true;
            this.btnBuscarBD.Click += new System.EventHandler(this.btnBuscarBD_Click_1);
            // 
            // frmVerBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(635, 393);
            this.Controls.Add(this.btnBuscarBD);
            this.Controls.Add(this.cmbBD);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.dgvBD);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVerBD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fernández ERP";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView dgvBD;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.ComboBox cmbBD;
        private MaterialSkin.Controls.MaterialButton btnBuscarBD;
    }
}