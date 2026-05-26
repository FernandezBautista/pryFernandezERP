namespace pryFernandezERP
{
    partial class frmContacto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContacto));
            this.grpContacto = new System.Windows.Forms.GroupBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.grpRedes = new System.Windows.Forms.GroupBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.cmbRedes = new System.Windows.Forms.ComboBox();
            this.btnCargarRedes = new System.Windows.Forms.Button();
            this.dgvRedes = new System.Windows.Forms.DataGridView();
            this.grpContacto.SuspendLayout();
            this.grpRedes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRedes)).BeginInit();
            this.SuspendLayout();
            // 
            // grpContacto
            // 
            this.grpContacto.Controls.Add(this.btnVolver);
            this.grpContacto.Controls.Add(this.btnCargar);
            this.grpContacto.Controls.Add(this.chkActivo);
            this.grpContacto.Controls.Add(this.grpRedes);
            this.grpContacto.Controls.Add(this.txtTelefono);
            this.grpContacto.Controls.Add(this.txtMail);
            this.grpContacto.Controls.Add(this.lblTelefono);
            this.grpContacto.Controls.Add(this.lblMail);
            this.grpContacto.Location = new System.Drawing.Point(13, 13);
            this.grpContacto.Name = "grpContacto";
            this.grpContacto.Size = new System.Drawing.Size(310, 356);
            this.grpContacto.TabIndex = 0;
            this.grpContacto.TabStop = false;
            this.grpContacto.Text = "Contacto";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(11, 327);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(104, 23);
            this.btnVolver.TabIndex = 17;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(191, 327);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(102, 23);
            this.btnCargar.TabIndex = 16;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(13, 282);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkActivo.Size = new System.Drawing.Size(56, 17);
            this.chkActivo.TabIndex = 15;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            this.chkActivo.CheckedChanged += new System.EventHandler(this.chkActivo_CheckedChanged);
            // 
            // grpRedes
            // 
            this.grpRedes.Controls.Add(this.dgvRedes);
            this.grpRedes.Controls.Add(this.btnCargarRedes);
            this.grpRedes.Controls.Add(this.cmbRedes);
            this.grpRedes.Controls.Add(this.txtUsuario);
            this.grpRedes.Location = new System.Drawing.Point(6, 72);
            this.grpRedes.Name = "grpRedes";
            this.grpRedes.Size = new System.Drawing.Size(298, 204);
            this.grpRedes.TabIndex = 10;
            this.grpRedes.TabStop = false;
            this.grpRedes.Text = "Redes";
            this.grpRedes.Enter += new System.EventHandler(this.grpRedes_Enter);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(115, 20);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(109, 20);
            this.txtUsuario.TabIndex = 14;
            this.txtUsuario.Text = "@usuario";
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(71, 46);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(110, 20);
            this.txtTelefono.TabIndex = 4;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(71, 19);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(226, 20);
            this.txtMail.TabIndex = 3;
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(6, 49);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 1;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(7, 22);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(29, 13);
            this.lblMail.TabIndex = 0;
            this.lblMail.Text = "Mail:";
            // 
            // cmbRedes
            // 
            this.cmbRedes.FormattingEnabled = true;
            this.cmbRedes.Items.AddRange(new object[] {
            "Facebook",
            "Instagram",
            "Twitter",
            "Telegram",
            "TikTok",
            "Otro"});
            this.cmbRedes.Location = new System.Drawing.Point(7, 20);
            this.cmbRedes.Name = "cmbRedes";
            this.cmbRedes.Size = new System.Drawing.Size(102, 21);
            this.cmbRedes.TabIndex = 15;
            this.cmbRedes.SelectedIndexChanged += new System.EventHandler(this.cmbRedes_SelectedIndexChanged);
            // 
            // btnCargarRedes
            // 
            this.btnCargarRedes.Location = new System.Drawing.Point(230, 19);
            this.btnCargarRedes.Name = "btnCargarRedes";
            this.btnCargarRedes.Size = new System.Drawing.Size(61, 21);
            this.btnCargarRedes.TabIndex = 16;
            this.btnCargarRedes.Text = "Cargar";
            this.btnCargarRedes.UseVisualStyleBackColor = true;
            this.btnCargarRedes.Click += new System.EventHandler(this.btnCargarRedes_Click);
            // 
            // dgvRedes
            // 
            this.dgvRedes.AllowUserToDeleteRows = false;
            this.dgvRedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRedes.Location = new System.Drawing.Point(7, 47);
            this.dgvRedes.Name = "dgvRedes";
            this.dgvRedes.ReadOnly = true;
            this.dgvRedes.Size = new System.Drawing.Size(280, 144);
            this.dgvRedes.TabIndex = 18;
            this.dgvRedes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRedes_CellContentClick);
            // 
            // frmContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 381);
            this.Controls.Add(this.grpContacto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmContacto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contacto";
            this.Load += new System.EventHandler(this.frmContacto_Load);
            this.grpContacto.ResumeLayout(false);
            this.grpContacto.PerformLayout();
            this.grpRedes.ResumeLayout(false);
            this.grpRedes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRedes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpContacto;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.GroupBox grpRedes;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnCargarRedes;
        private System.Windows.Forms.ComboBox cmbRedes;
        private System.Windows.Forms.DataGridView dgvRedes;
    }
}