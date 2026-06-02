namespace pryFernandezERP
{
    partial class frmPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonal));
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.grpDomicilio = new System.Windows.Forms.GroupBox();
            this.btnCargarDomicilio = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.grpContacto = new System.Windows.Forms.GroupBox();
            this.grpRedes = new System.Windows.Forms.GroupBox();
            this.dgvRedes = new System.Windows.Forms.DataGridView();
            this.btnCargarRedes = new System.Windows.Forms.Button();
            this.cmbRedes = new System.Windows.Forms.ComboBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.dgvDomicilio = new System.Windows.Forms.DataGridView();
            this.grpDomicilio.SuspendLayout();
            this.grpContacto.SuspendLayout();
            this.grpRedes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRedes)).BeginInit();
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDomicilio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(12, 31);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(29, 13);
            this.lblDNI.TabIndex = 0;
            this.lblDNI.Text = "DNI:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 59);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(12, 87);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // grpDomicilio
            // 
            this.grpDomicilio.Controls.Add(this.btnCargarDomicilio);
            this.grpDomicilio.Controls.Add(this.txtDireccion);
            this.grpDomicilio.Controls.Add(this.cmbLocalidad);
            this.grpDomicilio.Controls.Add(this.cmbProvincia);
            this.grpDomicilio.Controls.Add(this.lblProvincia);
            this.grpDomicilio.Controls.Add(this.lblLocalidad);
            this.grpDomicilio.Controls.Add(this.lblDireccion);
            this.grpDomicilio.Location = new System.Drawing.Point(13, 158);
            this.grpDomicilio.Name = "grpDomicilio";
            this.grpDomicilio.Size = new System.Drawing.Size(251, 136);
            this.grpDomicilio.TabIndex = 3;
            this.grpDomicilio.TabStop = false;
            this.grpDomicilio.Text = "Domicilio";
            // 
            // btnCargarDomicilio
            // 
            this.btnCargarDomicilio.Location = new System.Drawing.Point(6, 107);
            this.btnCargarDomicilio.Name = "btnCargarDomicilio";
            this.btnCargarDomicilio.Size = new System.Drawing.Size(239, 23);
            this.btnCargarDomicilio.TabIndex = 20;
            this.btnCargarDomicilio.Text = "Agregar domicilio";
            this.btnCargarDomicilio.UseVisualStyleBackColor = true;
            this.btnCargarDomicilio.Click += new System.EventHandler(this.btnCargarDomicilio_Click_1);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(72, 23);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(115, 20);
            this.txtDireccion.TabIndex = 11;
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(94, 76);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(93, 21);
            this.cmbLocalidad.TabIndex = 9;
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(94, 49);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(93, 21);
            this.cmbProvincia.TabIndex = 8;
            this.cmbProvincia.SelectedIndexChanged += new System.EventHandler(this.cmbProvincia_SelectedIndexChanged);
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(7, 53);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(54, 13);
            this.lblProvincia.TabIndex = 7;
            this.lblProvincia.Text = "Provincia:";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(6, 80);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(56, 13);
            this.lblLocalidad.TabIndex = 6;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(6, 26);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Direccion:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(73, 28);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(115, 20);
            this.txtDni.TabIndex = 12;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(73, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(115, 20);
            this.txtNombre.TabIndex = 13;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(73, 84);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(115, 20);
            this.txtApellido.TabIndex = 14;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(319, 392);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(189, 23);
            this.btnCargar.TabIndex = 15;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(50, 392);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(187, 23);
            this.btnVolver.TabIndex = 16;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // grpContacto
            // 
            this.grpContacto.Controls.Add(this.grpRedes);
            this.grpContacto.Controls.Add(this.txtTelefono);
            this.grpContacto.Controls.Add(this.txtMail);
            this.grpContacto.Controls.Add(this.lblTelefono);
            this.grpContacto.Controls.Add(this.lblMail);
            this.grpContacto.Location = new System.Drawing.Point(282, 19);
            this.grpContacto.Name = "grpContacto";
            this.grpContacto.Size = new System.Drawing.Size(314, 303);
            this.grpContacto.TabIndex = 17;
            this.grpContacto.TabStop = false;
            this.grpContacto.Text = "Contacto";
            // 
            // grpRedes
            // 
            this.grpRedes.Controls.Add(this.dgvRedes);
            this.grpRedes.Controls.Add(this.btnCargarRedes);
            this.grpRedes.Controls.Add(this.cmbRedes);
            this.grpRedes.Controls.Add(this.txtUsuario);
            this.grpRedes.Location = new System.Drawing.Point(8, 84);
            this.grpRedes.Name = "grpRedes";
            this.grpRedes.Size = new System.Drawing.Size(298, 204);
            this.grpRedes.TabIndex = 10;
            this.grpRedes.TabStop = false;
            this.grpRedes.Text = "Redes";
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
            // 
            // btnCargarRedes
            // 
            this.btnCargarRedes.Location = new System.Drawing.Point(230, 19);
            this.btnCargarRedes.Name = "btnCargarRedes";
            this.btnCargarRedes.Size = new System.Drawing.Size(61, 21);
            this.btnCargarRedes.TabIndex = 16;
            this.btnCargarRedes.Text = "Cargar";
            this.btnCargarRedes.UseVisualStyleBackColor = true;
            this.btnCargarRedes.Click += new System.EventHandler(this.btnCargarRedes_Click_1);
            // 
            // cmbRedes
            // 
            this.cmbRedes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(115, 20);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(109, 20);
            this.txtUsuario.TabIndex = 14;
            this.txtUsuario.Text = "@usuario";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(71, 46);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(110, 20);
            this.txtTelefono.TabIndex = 4;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(71, 19);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(226, 20);
            this.txtMail.TabIndex = 3;
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
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActivo.Location = new System.Drawing.Point(282, 328);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkActivo.Size = new System.Drawing.Size(80, 28);
            this.chkActivo.TabIndex = 15;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.txtApellido);
            this.grpDatos.Controls.Add(this.lblDNI);
            this.grpDatos.Controls.Add(this.lblNombre);
            this.grpDatos.Controls.Add(this.lblApellido);
            this.grpDatos.Controls.Add(this.txtDni);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Location = new System.Drawing.Point(12, 19);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(252, 133);
            this.grpDatos.TabIndex = 18;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos personales";
            // 
            // dgvDomicilio
            // 
            this.dgvDomicilio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDomicilio.Location = new System.Drawing.Point(13, 303);
            this.dgvDomicilio.Name = "dgvDomicilio";
            this.dgvDomicilio.Size = new System.Drawing.Size(251, 83);
            this.dgvDomicilio.TabIndex = 19;
            // 
            // frmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 427);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.dgvDomicilio);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.grpContacto);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.grpDomicilio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal";
            this.Load += new System.EventHandler(this.frmPersonal_Load);
            this.grpDomicilio.ResumeLayout(false);
            this.grpDomicilio.PerformLayout();
            this.grpContacto.ResumeLayout(false);
            this.grpContacto.PerformLayout();
            this.grpRedes.ResumeLayout(false);
            this.grpRedes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRedes)).EndInit();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDomicilio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.GroupBox grpDomicilio;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox grpContacto;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.GroupBox grpRedes;
        private System.Windows.Forms.DataGridView dgvRedes;
        private System.Windows.Forms.Button btnCargarRedes;
        private System.Windows.Forms.ComboBox cmbRedes;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.DataGridView dgvDomicilio;
        private System.Windows.Forms.Button btnCargarDomicilio;
    }
}