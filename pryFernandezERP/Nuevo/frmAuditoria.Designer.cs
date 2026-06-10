namespace pryFernandezERP
{
    partial class frmAuditoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAuditoria));
            this.dgvAuditoria = new System.Windows.Forms.DataGridView();
            this.grpFiltrar = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new MaterialSkin.Controls.MaterialButton();
            this.btnTodo = new MaterialSkin.Controls.MaterialButton();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.lblFechayHora = new System.Windows.Forms.Label();
            this.cmbAccion = new System.Windows.Forms.ComboBox();
            this.lblAccion = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblUsusario = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoria)).BeginInit();
            this.grpFiltrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAuditoria
            // 
            this.dgvAuditoria.Location = new System.Drawing.Point(6, 382);
            this.dgvAuditoria.Name = "dgvAuditoria";
            this.dgvAuditoria.Size = new System.Drawing.Size(591, 174);
            this.dgvAuditoria.TabIndex = 0;
            this.dgvAuditoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAuditoria_CellContentClick);
            // 
            // grpFiltrar
            // 
            this.grpFiltrar.Controls.Add(this.btnBuscar);
            this.grpFiltrar.Controls.Add(this.btnTodo);
            this.grpFiltrar.Controls.Add(this.calendario);
            this.grpFiltrar.Controls.Add(this.lblFechayHora);
            this.grpFiltrar.Controls.Add(this.cmbAccion);
            this.grpFiltrar.Controls.Add(this.lblAccion);
            this.grpFiltrar.Controls.Add(this.comboBox1);
            this.grpFiltrar.Controls.Add(this.lblUsusario);
            this.grpFiltrar.Location = new System.Drawing.Point(6, 67);
            this.grpFiltrar.Name = "grpFiltrar";
            this.grpFiltrar.Size = new System.Drawing.Size(368, 307);
            this.grpFiltrar.TabIndex = 1;
            this.grpFiltrar.TabStop = false;
            this.grpFiltrar.Text = "Filtrar";
            this.grpFiltrar.Enter += new System.EventHandler(this.grpFiltrar_Enter);
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSize = false;
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscar.Depth = 0;
            this.btnBuscar.HighEmphasis = true;
            this.btnBuscar.Icon = null;
            this.btnBuscar.Location = new System.Drawing.Point(203, 262);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuscar.Size = new System.Drawing.Size(158, 36);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscar.UseAccentColor = false;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // btnTodo
            // 
            this.btnTodo.AutoSize = false;
            this.btnTodo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTodo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTodo.Depth = 0;
            this.btnTodo.HighEmphasis = true;
            this.btnTodo.Icon = null;
            this.btnTodo.Location = new System.Drawing.Point(11, 262);
            this.btnTodo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTodo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTodo.Name = "btnTodo";
            this.btnTodo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTodo.Size = new System.Drawing.Size(150, 36);
            this.btnTodo.TabIndex = 9;
            this.btnTodo.Text = "Mostrar todo";
            this.btnTodo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTodo.UseAccentColor = false;
            this.btnTodo.UseVisualStyleBackColor = true;
            this.btnTodo.Click += new System.EventHandler(this.btnTodo_Click_1);
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(120, 79);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 7;
            this.calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lblFechayHora
            // 
            this.lblFechayHora.AutoSize = true;
            this.lblFechayHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechayHora.Location = new System.Drawing.Point(8, 74);
            this.lblFechayHora.Name = "lblFechayHora";
            this.lblFechayHora.Size = new System.Drawing.Size(91, 16);
            this.lblFechayHora.TabIndex = 4;
            this.lblFechayHora.Text = "Fecha y Hora:";
            // 
            // cmbAccion
            // 
            this.cmbAccion.FormattingEnabled = true;
            this.cmbAccion.Location = new System.Drawing.Point(120, 46);
            this.cmbAccion.Name = "cmbAccion";
            this.cmbAccion.Size = new System.Drawing.Size(189, 21);
            this.cmbAccion.TabIndex = 3;
            this.cmbAccion.SelectedIndexChanged += new System.EventHandler(this.cmbAccion_SelectedIndexChanged);
            // 
            // lblAccion
            // 
            this.lblAccion.AutoSize = true;
            this.lblAccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccion.Location = new System.Drawing.Point(8, 47);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Size = new System.Drawing.Size(51, 16);
            this.lblAccion.TabIndex = 2;
            this.lblAccion.Text = "Accion:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(120, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblUsusario
            // 
            this.lblUsusario.AutoSize = true;
            this.lblUsusario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsusario.Location = new System.Drawing.Point(8, 20);
            this.lblUsusario.Name = "lblUsusario";
            this.lblUsusario.Size = new System.Drawing.Size(57, 16);
            this.lblUsusario.TabIndex = 0;
            this.lblUsusario.Text = "Usuario:";
            this.lblUsusario.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.IndianRed;
            this.btnCerrar.Location = new System.Drawing.Point(495, 33);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(102, 23);
            this.btnCerrar.TabIndex = 34;
            this.btnCerrar.Text = "Cerrar Sesion";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 562);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.grpFiltrar);
            this.Controls.Add(this.dgvAuditoria);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAuditoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auditoria";
            this.Load += new System.EventHandler(this.frmInformacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoria)).EndInit();
            this.grpFiltrar.ResumeLayout(false);
            this.grpFiltrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAuditoria;
        private System.Windows.Forms.GroupBox grpFiltrar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblUsusario;
        private System.Windows.Forms.Label lblFechayHora;
        private System.Windows.Forms.ComboBox cmbAccion;
        private System.Windows.Forms.Label lblAccion;
        private System.Windows.Forms.MonthCalendar calendario;
        private MaterialSkin.Controls.MaterialButton btnTodo;
        private MaterialSkin.Controls.MaterialButton btnBuscar;
        private System.Windows.Forms.Button btnCerrar;
    }
}