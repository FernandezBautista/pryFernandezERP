namespace pryFernandezERP
{
    partial class frmEditarPersonal
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
            this.lblBuscar = new MaterialSkin.Controls.MaterialLabel();
            this.cmbMail = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new MaterialSkin.Controls.MaterialButton();
            this.lblTyR = new System.Windows.Forms.Label();
            this.dgvContactos = new System.Windows.Forms.DataGridView();
            this.dgvDomicilios = new System.Windows.Forms.DataGridView();
            this.lblDomicilios = new System.Windows.Forms.Label();
            this.grpContacto = new System.Windows.Forms.GroupBox();
            this.btnActualizarTel = new MaterialSkin.Controls.MaterialButton();
            this.btnActualizarMail = new MaterialSkin.Controls.MaterialButton();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.grpRedes = new System.Windows.Forms.GroupBox();
            this.btnActualizarRed = new MaterialSkin.Controls.MaterialButton();
            this.cmbRedes = new System.Windows.Forms.ComboBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.Domicilio = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new MaterialSkin.Controls.MaterialButton();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnGuardarEdicion = new MaterialSkin.Controls.MaterialButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDomicilios)).BeginInit();
            this.grpContacto.SuspendLayout();
            this.grpRedes.SuspendLayout();
            this.Domicilio.SuspendLayout();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Depth = 0;
            this.lblBuscar.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblBuscar.Location = new System.Drawing.Point(20, 96);
            this.lblBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(129, 19);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar por correo:";
            // 
            // cmbMail
            // 
            this.cmbMail.FormattingEnabled = true;
            this.cmbMail.Location = new System.Drawing.Point(177, 96);
            this.cmbMail.Name = "cmbMail";
            this.cmbMail.Size = new System.Drawing.Size(273, 21);
            this.cmbMail.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSize = false;
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscar.Depth = 0;
            this.btnBuscar.HighEmphasis = true;
            this.btnBuscar.Icon = null;
            this.btnBuscar.Location = new System.Drawing.Point(457, 96);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuscar.Size = new System.Drawing.Size(134, 21);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscar.UseAccentColor = false;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // lblTyR
            // 
            this.lblTyR.AutoSize = true;
            this.lblTyR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTyR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(61)))), ((int)(((byte)(46)))));
            this.lblTyR.Location = new System.Drawing.Point(347, 419);
            this.lblTyR.Name = "lblTyR";
            this.lblTyR.Size = new System.Drawing.Size(117, 13);
            this.lblTyR.TabIndex = 29;
            this.lblTyR.Text = "Telefonos y Redes:";
            // 
            // dgvContactos
            // 
            this.dgvContactos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(242)))));
            this.dgvContactos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactos.Location = new System.Drawing.Point(350, 435);
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.Size = new System.Drawing.Size(274, 174);
            this.dgvContactos.TabIndex = 28;
            // 
            // dgvDomicilios
            // 
            this.dgvDomicilios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(242)))));
            this.dgvDomicilios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDomicilios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDomicilios.Location = new System.Drawing.Point(262, 271);
            this.dgvDomicilios.Name = "dgvDomicilios";
            this.dgvDomicilios.Size = new System.Drawing.Size(362, 142);
            this.dgvDomicilios.TabIndex = 27;
            // 
            // lblDomicilios
            // 
            this.lblDomicilios.AutoSize = true;
            this.lblDomicilios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(61)))), ((int)(((byte)(46)))));
            this.lblDomicilios.Location = new System.Drawing.Point(259, 255);
            this.lblDomicilios.Name = "lblDomicilios";
            this.lblDomicilios.Size = new System.Drawing.Size(68, 13);
            this.lblDomicilios.TabIndex = 25;
            this.lblDomicilios.Text = "Domicilios:";
            // 
            // grpContacto
            // 
            this.grpContacto.Controls.Add(this.btnActualizarTel);
            this.grpContacto.Controls.Add(this.btnActualizarMail);
            this.grpContacto.Controls.Add(this.lblTelefono);
            this.grpContacto.Controls.Add(this.lblMail);
            this.grpContacto.Controls.Add(this.grpRedes);
            this.grpContacto.Controls.Add(this.txtTelefono);
            this.grpContacto.Controls.Add(this.txtMail);
            this.grpContacto.Location = new System.Drawing.Point(13, 419);
            this.grpContacto.Name = "grpContacto";
            this.grpContacto.Size = new System.Drawing.Size(314, 227);
            this.grpContacto.TabIndex = 26;
            this.grpContacto.TabStop = false;
            this.grpContacto.Text = "Contacto";
            // 
            // btnActualizarTel
            // 
            this.btnActualizarTel.AutoSize = false;
            this.btnActualizarTel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizarTel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnActualizarTel.Depth = 0;
            this.btnActualizarTel.HighEmphasis = true;
            this.btnActualizarTel.Icon = null;
            this.btnActualizarTel.Location = new System.Drawing.Point(198, 83);
            this.btnActualizarTel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnActualizarTel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarTel.Name = "btnActualizarTel";
            this.btnActualizarTel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnActualizarTel.Size = new System.Drawing.Size(102, 37);
            this.btnActualizarTel.TabIndex = 31;
            this.btnActualizarTel.Text = "Actualizar Tel...";
            this.btnActualizarTel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnActualizarTel.UseAccentColor = false;
            this.btnActualizarTel.UseVisualStyleBackColor = true;
            this.btnActualizarTel.Click += new System.EventHandler(this.btnActualizarTel_Click_1);
            // 
            // btnActualizarMail
            // 
            this.btnActualizarMail.AutoSize = false;
            this.btnActualizarMail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizarMail.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnActualizarMail.Depth = 0;
            this.btnActualizarMail.HighEmphasis = true;
            this.btnActualizarMail.Icon = null;
            this.btnActualizarMail.Location = new System.Drawing.Point(17, 83);
            this.btnActualizarMail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnActualizarMail.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarMail.Name = "btnActualizarMail";
            this.btnActualizarMail.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnActualizarMail.Size = new System.Drawing.Size(101, 37);
            this.btnActualizarMail.TabIndex = 32;
            this.btnActualizarMail.Text = "Actualizar Mail";
            this.btnActualizarMail.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnActualizarMail.UseAccentColor = false;
            this.btnActualizarMail.UseVisualStyleBackColor = true;
            this.btnActualizarMail.Click += new System.EventHandler(this.btnActualizarMail_Click_1);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(61)))), ((int)(((byte)(46)))));
            this.lblTelefono.Location = new System.Drawing.Point(10, 57);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(61, 13);
            this.lblTelefono.TabIndex = 14;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(61)))), ((int)(((byte)(46)))));
            this.lblMail.Location = new System.Drawing.Point(11, 24);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(34, 13);
            this.lblMail.TabIndex = 13;
            this.lblMail.Text = "Mail:";
            // 
            // grpRedes
            // 
            this.grpRedes.Controls.Add(this.btnActualizarRed);
            this.grpRedes.Controls.Add(this.cmbRedes);
            this.grpRedes.Controls.Add(this.txtUsuario);
            this.grpRedes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRedes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(61)))), ((int)(((byte)(46)))));
            this.grpRedes.Location = new System.Drawing.Point(10, 129);
            this.grpRedes.Name = "grpRedes";
            this.grpRedes.Size = new System.Drawing.Size(298, 79);
            this.grpRedes.TabIndex = 10;
            this.grpRedes.TabStop = false;
            this.grpRedes.Text = "Redes";
            // 
            // btnActualizarRed
            // 
            this.btnActualizarRed.AutoSize = false;
            this.btnActualizarRed.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizarRed.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnActualizarRed.Depth = 0;
            this.btnActualizarRed.HighEmphasis = true;
            this.btnActualizarRed.Icon = null;
            this.btnActualizarRed.Location = new System.Drawing.Point(8, 50);
            this.btnActualizarRed.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnActualizarRed.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarRed.Name = "btnActualizarRed";
            this.btnActualizarRed.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnActualizarRed.Size = new System.Drawing.Size(284, 22);
            this.btnActualizarRed.TabIndex = 31;
            this.btnActualizarRed.Text = "Actualizar usuario";
            this.btnActualizarRed.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnActualizarRed.UseAccentColor = false;
            this.btnActualizarRed.UseVisualStyleBackColor = true;
            this.btnActualizarRed.Click += new System.EventHandler(this.btnActualizarRed_Click_1);
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
            this.cmbRedes.Location = new System.Drawing.Point(6, 19);
            this.cmbRedes.Name = "cmbRedes";
            this.cmbRedes.Size = new System.Drawing.Size(102, 21);
            this.cmbRedes.TabIndex = 15;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(114, 19);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(176, 20);
            this.txtUsuario.TabIndex = 14;
            this.txtUsuario.Text = "@usuario";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(78, 55);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(223, 20);
            this.txtTelefono.TabIndex = 4;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(78, 21);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(223, 20);
            this.txtMail.TabIndex = 3;
            // 
            // Domicilio
            // 
            this.Domicilio.Controls.Add(this.btnActualizar);
            this.Domicilio.Controls.Add(this.txtDireccion);
            this.Domicilio.Controls.Add(this.cmbLocalidad);
            this.Domicilio.Controls.Add(this.cmbProvincia);
            this.Domicilio.Controls.Add(this.lblDireccion);
            this.Domicilio.Controls.Add(this.lblLocalidad);
            this.Domicilio.Controls.Add(this.lblProvincia);
            this.Domicilio.Location = new System.Drawing.Point(17, 257);
            this.Domicilio.Name = "Domicilio";
            this.Domicilio.Size = new System.Drawing.Size(209, 156);
            this.Domicilio.TabIndex = 24;
            this.Domicilio.TabStop = false;
            this.Domicilio.Text = "Domicilio:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = false;
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.HighEmphasis = true;
            this.btnActualizar.Icon = null;
            this.btnActualizar.Location = new System.Drawing.Point(10, 120);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnActualizar.Size = new System.Drawing.Size(189, 24);
            this.btnActualizar.TabIndex = 31;
            this.btnActualizar.Text = "Actualizar domicilio";
            this.btnActualizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnActualizar.UseAccentColor = false;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_1);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(78, 25);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(121, 20);
            this.txtDireccion.TabIndex = 11;
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(78, 90);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(121, 21);
            this.cmbLocalidad.TabIndex = 10;
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(78, 59);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(121, 21);
            this.cmbProvincia.TabIndex = 9;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(61)))), ((int)(((byte)(46)))));
            this.lblDireccion.Location = new System.Drawing.Point(11, 28);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(65, 13);
            this.lblDireccion.TabIndex = 8;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(61)))), ((int)(((byte)(46)))));
            this.lblLocalidad.Location = new System.Drawing.Point(10, 94);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(62, 13);
            this.lblLocalidad.TabIndex = 7;
            this.lblLocalidad.Text = "Localidad";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(61)))), ((int)(((byte)(46)))));
            this.lblProvincia.Location = new System.Drawing.Point(10, 62);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(64, 13);
            this.lblProvincia.TabIndex = 6;
            this.lblProvincia.Text = "Provincia:";
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.lblDni);
            this.grpDatos.Controls.Add(this.lblApellido);
            this.grpDatos.Controls.Add(this.lblNombre);
            this.grpDatos.Controls.Add(this.txtDni);
            this.grpDatos.Controls.Add(this.txtApellido);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Location = new System.Drawing.Point(17, 138);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(209, 113);
            this.grpDatos.TabIndex = 23;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos Personales";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(61)))), ((int)(((byte)(46)))));
            this.lblDni.Location = new System.Drawing.Point(7, 83);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(33, 13);
            this.lblDni.TabIndex = 8;
            this.lblDni.Text = "DNI:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(61)))), ((int)(((byte)(46)))));
            this.lblApellido.Location = new System.Drawing.Point(7, 57);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(56, 13);
            this.lblApellido.TabIndex = 7;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(61)))), ((int)(((byte)(46)))));
            this.lblNombre.Location = new System.Drawing.Point(7, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(67, 83);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(128, 20);
            this.txtDni.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(67, 57);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(128, 20);
            this.txtApellido.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(67, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(128, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // btnGuardarEdicion
            // 
            this.btnGuardarEdicion.AutoSize = false;
            this.btnGuardarEdicion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardarEdicion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuardarEdicion.Depth = 0;
            this.btnGuardarEdicion.HighEmphasis = true;
            this.btnGuardarEdicion.Icon = null;
            this.btnGuardarEdicion.Location = new System.Drawing.Point(383, 655);
            this.btnGuardarEdicion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuardarEdicion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardarEdicion.Name = "btnGuardarEdicion";
            this.btnGuardarEdicion.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGuardarEdicion.Size = new System.Drawing.Size(241, 35);
            this.btnGuardarEdicion.TabIndex = 30;
            this.btnGuardarEdicion.Text = "Guardar edicion";
            this.btnGuardarEdicion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuardarEdicion.UseAccentColor = false;
            this.btnGuardarEdicion.UseVisualStyleBackColor = true;
            this.btnGuardarEdicion.Click += new System.EventHandler(this.btnGuardarEdicion_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = false;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(13, 655);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(241, 35);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // frmEditarPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 699);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarEdicion);
            this.Controls.Add(this.lblTyR);
            this.Controls.Add(this.dgvContactos);
            this.Controls.Add(this.dgvDomicilios);
            this.Controls.Add(this.lblDomicilios);
            this.Controls.Add(this.grpContacto);
            this.Controls.Add(this.Domicilio);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmbMail);
            this.Controls.Add(this.lblBuscar);
            this.Name = "frmEditarPersonal";
            this.Text = "frmEditarPersonal";
            this.Load += new System.EventHandler(this.frmEditarPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDomicilios)).EndInit();
            this.grpContacto.ResumeLayout(false);
            this.grpContacto.PerformLayout();
            this.grpRedes.ResumeLayout(false);
            this.grpRedes.PerformLayout();
            this.Domicilio.ResumeLayout(false);
            this.Domicilio.PerformLayout();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblBuscar;
        private System.Windows.Forms.ComboBox cmbMail;
        private MaterialSkin.Controls.MaterialButton btnBuscar;
        private System.Windows.Forms.Label lblTyR;
        private System.Windows.Forms.DataGridView dgvContactos;
        private System.Windows.Forms.DataGridView dgvDomicilios;
        private System.Windows.Forms.Label lblDomicilios;
        private System.Windows.Forms.GroupBox grpContacto;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.GroupBox grpRedes;
        private System.Windows.Forms.ComboBox cmbRedes;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.GroupBox Domicilio;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private MaterialSkin.Controls.MaterialButton btnGuardarEdicion;
        private MaterialSkin.Controls.MaterialButton btnActualizarMail;
        private MaterialSkin.Controls.MaterialButton btnActualizarRed;
        private MaterialSkin.Controls.MaterialButton btnActualizar;
        private MaterialSkin.Controls.MaterialButton btnActualizarTel;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
    }
}