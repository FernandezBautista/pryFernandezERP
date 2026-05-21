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
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtGeo = new System.Windows.Forms.TextBox();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblGeo = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.grpDomicilio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(19, 19);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(29, 13);
            this.lblDNI.TabIndex = 0;
            this.lblDNI.Text = "DNI:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(19, 47);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(19, 75);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // grpDomicilio
            // 
            this.grpDomicilio.Controls.Add(this.txtDireccion);
            this.grpDomicilio.Controls.Add(this.txtGeo);
            this.grpDomicilio.Controls.Add(this.cmbLocalidad);
            this.grpDomicilio.Controls.Add(this.cmbProvincia);
            this.grpDomicilio.Controls.Add(this.lblProvincia);
            this.grpDomicilio.Controls.Add(this.lblLocalidad);
            this.grpDomicilio.Controls.Add(this.lblGeo);
            this.grpDomicilio.Controls.Add(this.lblDireccion);
            this.grpDomicilio.Location = new System.Drawing.Point(13, 107);
            this.grpDomicilio.Name = "grpDomicilio";
            this.grpDomicilio.Size = new System.Drawing.Size(200, 137);
            this.grpDomicilio.TabIndex = 3;
            this.grpDomicilio.TabStop = false;
            this.grpDomicilio.Text = "Domicilio";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(67, 23);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(115, 20);
            this.txtDireccion.TabIndex = 11;
            // 
            // txtGeo
            // 
            this.txtGeo.Location = new System.Drawing.Point(67, 52);
            this.txtGeo.Name = "txtGeo";
            this.txtGeo.Size = new System.Drawing.Size(115, 20);
            this.txtGeo.TabIndex = 10;
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(89, 104);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(93, 21);
            this.cmbLocalidad.TabIndex = 9;
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(89, 78);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(93, 21);
            this.cmbProvincia.TabIndex = 8;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(7, 82);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(54, 13);
            this.lblProvincia.TabIndex = 7;
            this.lblProvincia.Text = "Provincia:";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(6, 109);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(56, 13);
            this.lblLocalidad.TabIndex = 6;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // lblGeo
            // 
            this.lblGeo.AutoSize = true;
            this.lblGeo.Location = new System.Drawing.Point(7, 52);
            this.lblGeo.Name = "lblGeo";
            this.lblGeo.Size = new System.Drawing.Size(30, 13);
            this.lblGeo.TabIndex = 5;
            this.lblGeo.Text = "Geo:";
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
            this.txtDni.Location = new System.Drawing.Point(80, 16);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(115, 20);
            this.txtDni.TabIndex = 12;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(80, 44);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(115, 20);
            this.txtNombre.TabIndex = 13;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(80, 72);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(115, 20);
            this.txtApellido.TabIndex = 14;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(137, 259);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 15;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 259);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 16;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 294);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.grpDomicilio);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDNI);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPersonal";
            this.Text = "Personal";
            this.grpDomicilio.ResumeLayout(false);
            this.grpDomicilio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.GroupBox grpDomicilio;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblGeo;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtGeo;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnVolver;
    }
}