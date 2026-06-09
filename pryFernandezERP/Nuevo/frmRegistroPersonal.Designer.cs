namespace pryFernandezERP
{
    partial class frmRegistroPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroPersonal));
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.btnCargarNvoPersonal = new MaterialSkin.Controls.MaterialButton();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnAgregarDomicilio = new MaterialSkin.Controls.MaterialButton();
            this.Domicilio = new System.Windows.Forms.GroupBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.grpRedes = new System.Windows.Forms.GroupBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.cmbRedes = new System.Windows.Forms.ComboBox();
            this.btnCargarRedes = new System.Windows.Forms.Button();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.btnAgregarTelefono = new System.Windows.Forms.Button();
            this.grpContacto = new System.Windows.Forms.GroupBox();
            this.lblDomicilios = new System.Windows.Forms.Label();
            this.dgvDomicilios = new System.Windows.Forms.DataGridView();
            this.dgvContactos = new System.Windows.Forms.DataGridView();
            this.lblTyR = new System.Windows.Forms.Label();
            this.grpDatos.SuspendLayout();
            this.Domicilio.SuspendLayout();
            this.grpRedes.SuspendLayout();
            this.grpContacto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDomicilios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            this.SuspendLayout();
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(596, 64);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 556);
            this.vScrollBar1.TabIndex = 19;
            // 
            // btnCargarNvoPersonal
            // 
            this.btnCargarNvoPersonal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCargarNvoPersonal.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCargarNvoPersonal.Depth = 0;
            this.btnCargarNvoPersonal.HighEmphasis = true;
            this.btnCargarNvoPersonal.Icon = null;
            this.btnCargarNvoPersonal.Location = new System.Drawing.Point(13, 529);
            this.btnCargarNvoPersonal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCargarNvoPersonal.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCargarNvoPersonal.Name = "btnCargarNvoPersonal";
            this.btnCargarNvoPersonal.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCargarNvoPersonal.Size = new System.Drawing.Size(209, 36);
            this.btnCargarNvoPersonal.TabIndex = 23;
            this.btnCargarNvoPersonal.Text = "Cargar nuevo personal";
            this.btnCargarNvoPersonal.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCargarNvoPersonal.UseAccentColor = false;
            this.btnCargarNvoPersonal.UseVisualStyleBackColor = true;
            this.btnCargarNvoPersonal.Click += new System.EventHandler(this.btnCargarNvoPersonal_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(67, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(128, 20);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(67, 52);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(128, 20);
            this.txtApellido.TabIndex = 4;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(67, 78);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(128, 20);
            this.txtDni.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(61)))), ((int)(((byte)(46)))));
            this.lblNombre.Location = new System.Drawing.Point(7, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(61)))), ((int)(((byte)(46)))));
            this.lblApellido.Location = new System.Drawing.Point(7, 52);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(56, 13);
            this.lblApellido.TabIndex = 7;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(61)))), ((int)(((byte)(46)))));
            this.lblDni.Location = new System.Drawing.Point(7, 78);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(33, 13);
            this.lblDni.TabIndex = 8;
            this.lblDni.Text = "DNI:";
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.lblDni);
            this.grpDatos.Controls.Add(this.lblApellido);
            this.grpDatos.Controls.Add(this.lblNombre);
            this.grpDatos.Controls.Add(this.txtDni);
            this.grpDatos.Controls.Add(this.txtApellido);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Location = new System.Drawing.Point(13, 67);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(209, 113);
            this.grpDatos.TabIndex = 0;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos Personales";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(61)))), ((int)(((byte)(46)))));
            this.lblProvincia.Location = new System.Drawing.Point(10, 57);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(64, 13);
            this.lblProvincia.TabIndex = 6;
            this.lblProvincia.Text = "Provincia:";
            this.lblProvincia.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(61)))), ((int)(((byte)(46)))));
            this.lblLocalidad.Location = new System.Drawing.Point(10, 85);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(62, 13);
            this.lblLocalidad.TabIndex = 7;
            this.lblLocalidad.Text = "Localidad";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(61)))), ((int)(((byte)(46)))));
            this.lblDireccion.Location = new System.Drawing.Point(9, 30);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(65, 13);
            this.lblDireccion.TabIndex = 8;
            this.lblDireccion.Text = "Direccion:";
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(78, 54);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(121, 21);
            this.cmbProvincia.TabIndex = 9;
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(78, 81);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(121, 21);
            this.cmbLocalidad.TabIndex = 10;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(78, 30);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(121, 20);
            this.txtDireccion.TabIndex = 11;
            // 
            // btnAgregarDomicilio
            // 
            this.btnAgregarDomicilio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarDomicilio.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarDomicilio.Depth = 0;
            this.btnAgregarDomicilio.HighEmphasis = true;
            this.btnAgregarDomicilio.Icon = null;
            this.btnAgregarDomicilio.Location = new System.Drawing.Point(22, 107);
            this.btnAgregarDomicilio.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarDomicilio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarDomicilio.Name = "btnAgregarDomicilio";
            this.btnAgregarDomicilio.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarDomicilio.Size = new System.Drawing.Size(165, 36);
            this.btnAgregarDomicilio.TabIndex = 12;
            this.btnAgregarDomicilio.Text = "Agregar Domicilio";
            this.btnAgregarDomicilio.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarDomicilio.UseAccentColor = false;
            this.btnAgregarDomicilio.UseVisualStyleBackColor = true;
            this.btnAgregarDomicilio.Click += new System.EventHandler(this.btnAgregarDomicilio_Click);
            // 
            // Domicilio
            // 
            this.Domicilio.Controls.Add(this.btnAgregarDomicilio);
            this.Domicilio.Controls.Add(this.txtDireccion);
            this.Domicilio.Controls.Add(this.cmbLocalidad);
            this.Domicilio.Controls.Add(this.cmbProvincia);
            this.Domicilio.Controls.Add(this.lblDireccion);
            this.Domicilio.Controls.Add(this.lblLocalidad);
            this.Domicilio.Controls.Add(this.lblProvincia);
            this.Domicilio.Location = new System.Drawing.Point(13, 186);
            this.Domicilio.Name = "Domicilio";
            this.Domicilio.Size = new System.Drawing.Size(209, 152);
            this.Domicilio.TabIndex = 9;
            this.Domicilio.TabStop = false;
            this.Domicilio.Text = "Domicilio:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(78, 16);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(223, 20);
            this.txtMail.TabIndex = 3;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(78, 50);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(110, 20);
            this.txtTelefono.TabIndex = 4;
            // 
            // grpRedes
            // 
            this.grpRedes.Controls.Add(this.btnCargarRedes);
            this.grpRedes.Controls.Add(this.cmbRedes);
            this.grpRedes.Controls.Add(this.txtUsuario);
            this.grpRedes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRedes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(61)))), ((int)(((byte)(46)))));
            this.grpRedes.Location = new System.Drawing.Point(10, 78);
            this.grpRedes.Name = "grpRedes";
            this.grpRedes.Size = new System.Drawing.Size(298, 62);
            this.grpRedes.TabIndex = 10;
            this.grpRedes.TabStop = false;
            this.grpRedes.Text = "Redes";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(115, 20);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(109, 20);
            this.txtUsuario.TabIndex = 14;
            this.txtUsuario.Text = "@usuario";
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
            // btnCargarRedes
            // 
            this.btnCargarRedes.Location = new System.Drawing.Point(230, 19);
            this.btnCargarRedes.Name = "btnCargarRedes";
            this.btnCargarRedes.Size = new System.Drawing.Size(61, 22);
            this.btnCargarRedes.TabIndex = 16;
            this.btnCargarRedes.Text = "Agregar";
            this.btnCargarRedes.UseVisualStyleBackColor = true;
            this.btnCargarRedes.Click += new System.EventHandler(this.btnCargarRedes_Click);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(61)))), ((int)(((byte)(46)))));
            this.lblMail.Location = new System.Drawing.Point(11, 19);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(34, 13);
            this.lblMail.TabIndex = 13;
            this.lblMail.Text = "Mail:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(61)))), ((int)(((byte)(46)))));
            this.lblTelefono.Location = new System.Drawing.Point(10, 52);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(61, 13);
            this.lblTelefono.TabIndex = 14;
            this.lblTelefono.Text = "Telefono:";
            // 
            // btnAgregarTelefono
            // 
            this.btnAgregarTelefono.Location = new System.Drawing.Point(194, 50);
            this.btnAgregarTelefono.Name = "btnAgregarTelefono";
            this.btnAgregarTelefono.Size = new System.Drawing.Size(107, 21);
            this.btnAgregarTelefono.TabIndex = 17;
            this.btnAgregarTelefono.Text = "Agregar telefono";
            this.btnAgregarTelefono.UseVisualStyleBackColor = true;
            this.btnAgregarTelefono.Click += new System.EventHandler(this.btnAgregarTelefono_Click);
            // 
            // grpContacto
            // 
            this.grpContacto.Controls.Add(this.btnAgregarTelefono);
            this.grpContacto.Controls.Add(this.lblTelefono);
            this.grpContacto.Controls.Add(this.lblMail);
            this.grpContacto.Controls.Add(this.grpRedes);
            this.grpContacto.Controls.Add(this.txtTelefono);
            this.grpContacto.Controls.Add(this.txtMail);
            this.grpContacto.Location = new System.Drawing.Point(13, 344);
            this.grpContacto.Name = "grpContacto";
            this.grpContacto.Size = new System.Drawing.Size(314, 163);
            this.grpContacto.TabIndex = 18;
            this.grpContacto.TabStop = false;
            this.grpContacto.Text = "Contacto";
            // 
            // lblDomicilios
            // 
            this.lblDomicilios.AutoSize = true;
            this.lblDomicilios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(61)))), ((int)(((byte)(46)))));
            this.lblDomicilios.Location = new System.Drawing.Point(367, 186);
            this.lblDomicilios.Name = "lblDomicilios";
            this.lblDomicilios.Size = new System.Drawing.Size(68, 13);
            this.lblDomicilios.TabIndex = 13;
            this.lblDomicilios.Text = "Domicilios:";
            // 
            // dgvDomicilios
            // 
            this.dgvDomicilios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(242)))));
            this.dgvDomicilios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDomicilios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDomicilios.Location = new System.Drawing.Point(367, 202);
            this.dgvDomicilios.Name = "dgvDomicilios";
            this.dgvDomicilios.Size = new System.Drawing.Size(220, 127);
            this.dgvDomicilios.TabIndex = 20;
            // 
            // dgvContactos
            // 
            this.dgvContactos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(242)))));
            this.dgvContactos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactos.Location = new System.Drawing.Point(367, 360);
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.Size = new System.Drawing.Size(220, 147);
            this.dgvContactos.TabIndex = 21;
            // 
            // lblTyR
            // 
            this.lblTyR.AutoSize = true;
            this.lblTyR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTyR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(61)))), ((int)(((byte)(46)))));
            this.lblTyR.Location = new System.Drawing.Point(364, 344);
            this.lblTyR.Name = "lblTyR";
            this.lblTyR.Size = new System.Drawing.Size(117, 13);
            this.lblTyR.TabIndex = 22;
            this.lblTyR.Text = "Telefonos y Redes:";
            // 
            // frmRegistroPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(616, 574);
            this.Controls.Add(this.btnCargarNvoPersonal);
            this.Controls.Add(this.lblTyR);
            this.Controls.Add(this.dgvContactos);
            this.Controls.Add(this.dgvDomicilios);
            this.Controls.Add(this.lblDomicilios);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.grpContacto);
            this.Controls.Add(this.Domicilio);
            this.Controls.Add(this.grpDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistroPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Personal";
            this.Load += new System.EventHandler(this.frmRegistroPersonal_Load);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.Domicilio.ResumeLayout(false);
            this.Domicilio.PerformLayout();
            this.grpRedes.ResumeLayout(false);
            this.grpRedes.PerformLayout();
            this.grpContacto.ResumeLayout(false);
            this.grpContacto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDomicilios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private MaterialSkin.Controls.MaterialButton btnCargarNvoPersonal;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.TextBox txtDireccion;
        private MaterialSkin.Controls.MaterialButton btnAgregarDomicilio;
        private System.Windows.Forms.GroupBox Domicilio;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.GroupBox grpRedes;
        private System.Windows.Forms.Button btnCargarRedes;
        private System.Windows.Forms.ComboBox cmbRedes;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Button btnAgregarTelefono;
        private System.Windows.Forms.GroupBox grpContacto;
        private System.Windows.Forms.Label lblDomicilios;
        private System.Windows.Forms.DataGridView dgvDomicilios;
        private System.Windows.Forms.DataGridView dgvContactos;
        private System.Windows.Forms.Label lblTyR;
    }
}