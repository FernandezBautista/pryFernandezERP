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
            this.btnTodo = new System.Windows.Forms.Button();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lblFechayHora = new System.Windows.Forms.Label();
            this.cmbAccion = new System.Windows.Forms.ComboBox();
            this.lblAccion = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblUsusario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoria)).BeginInit();
            this.grpFiltrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAuditoria
            // 
            this.dgvAuditoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuditoria.Location = new System.Drawing.Point(13, 299);
            this.dgvAuditoria.Name = "dgvAuditoria";
            this.dgvAuditoria.Size = new System.Drawing.Size(317, 174);
            this.dgvAuditoria.TabIndex = 0;
            this.dgvAuditoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAuditoria_CellContentClick);
            // 
            // grpFiltrar
            // 
            this.grpFiltrar.Controls.Add(this.btnTodo);
            this.grpFiltrar.Controls.Add(this.calendario);
            this.grpFiltrar.Controls.Add(this.btnFiltrar);
            this.grpFiltrar.Controls.Add(this.lblFechayHora);
            this.grpFiltrar.Controls.Add(this.cmbAccion);
            this.grpFiltrar.Controls.Add(this.lblAccion);
            this.grpFiltrar.Controls.Add(this.comboBox1);
            this.grpFiltrar.Controls.Add(this.lblUsusario);
            this.grpFiltrar.Location = new System.Drawing.Point(13, 13);
            this.grpFiltrar.Name = "grpFiltrar";
            this.grpFiltrar.Size = new System.Drawing.Size(317, 280);
            this.grpFiltrar.TabIndex = 1;
            this.grpFiltrar.TabStop = false;
            this.grpFiltrar.Text = "Filtrar";
            this.grpFiltrar.Enter += new System.EventHandler(this.grpFiltrar_Enter);
            // 
            // btnTodo
            // 
            this.btnTodo.Location = new System.Drawing.Point(6, 251);
            this.btnTodo.Name = "btnTodo";
            this.btnTodo.Size = new System.Drawing.Size(119, 23);
            this.btnTodo.TabIndex = 8;
            this.btnTodo.Text = "Mostrar todo";
            this.btnTodo.UseVisualStyleBackColor = true;
            this.btnTodo.Click += new System.EventHandler(this.btnTodo_Click);
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(120, 79);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 7;
            this.calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(198, 253);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(114, 23);
            this.btnFiltrar.TabIndex = 6;
            this.btnFiltrar.Text = "Buscar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
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
            this.cmbAccion.Size = new System.Drawing.Size(103, 21);
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
            this.comboBox1.Size = new System.Drawing.Size(103, 21);
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
            // frmAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 485);
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
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lblFechayHora;
        private System.Windows.Forms.ComboBox cmbAccion;
        private System.Windows.Forms.Label lblAccion;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.Button btnTodo;
    }
}