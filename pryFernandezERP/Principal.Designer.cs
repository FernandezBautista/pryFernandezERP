namespace pryFernandezERP
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.lblUsuarioE = new System.Windows.Forms.Label();
            this.lblRolPerfilE = new System.Windows.Forms.Label();
            this.lblFechaHoraE = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblRolPerfil = new System.Windows.Forms.Label();
            this.lblFechaYHora = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.grpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslEstado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 145);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(240, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslEstado
            // 
            this.tslEstado.Name = "tslEstado";
            this.tslEstado.Size = new System.Drawing.Size(82, 17);
            this.tslEstado.Text = "Desconectado";
            // 
            // grpMain
            // 
            this.grpMain.Controls.Add(this.lblFechaYHora);
            this.grpMain.Controls.Add(this.lblRolPerfil);
            this.grpMain.Controls.Add(this.lblUsuario);
            this.grpMain.Controls.Add(this.lblFechaHoraE);
            this.grpMain.Controls.Add(this.lblRolPerfilE);
            this.grpMain.Controls.Add(this.lblUsuarioE);
            this.grpMain.Location = new System.Drawing.Point(13, 13);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(215, 115);
            this.grpMain.TabIndex = 1;
            this.grpMain.TabStop = false;
            this.grpMain.Text = "Usuario conectado";
            // 
            // lblUsuarioE
            // 
            this.lblUsuarioE.AutoSize = true;
            this.lblUsuarioE.Location = new System.Drawing.Point(7, 20);
            this.lblUsuarioE.Name = "lblUsuarioE";
            this.lblUsuarioE.Size = new System.Drawing.Size(46, 13);
            this.lblUsuarioE.TabIndex = 0;
            this.lblUsuarioE.Text = "Usuario:";
            // 
            // lblRolPerfilE
            // 
            this.lblRolPerfilE.AutoSize = true;
            this.lblRolPerfilE.Location = new System.Drawing.Point(7, 43);
            this.lblRolPerfilE.Name = "lblRolPerfilE";
            this.lblRolPerfilE.Size = new System.Drawing.Size(52, 13);
            this.lblRolPerfilE.TabIndex = 1;
            this.lblRolPerfilE.Text = "Rol-Perfil:";
            // 
            // lblFechaHoraE
            // 
            this.lblFechaHoraE.AutoSize = true;
            this.lblFechaHoraE.Location = new System.Drawing.Point(7, 68);
            this.lblFechaHoraE.Name = "lblFechaHoraE";
            this.lblFechaHoraE.Size = new System.Drawing.Size(74, 13);
            this.lblFechaHoraE.TabIndex = 2;
            this.lblFechaHoraE.Text = "Fecha y Hora:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(95, 20);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(35, 13);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "label1";
            // 
            // lblRolPerfil
            // 
            this.lblRolPerfil.AutoSize = true;
            this.lblRolPerfil.Location = new System.Drawing.Point(95, 43);
            this.lblRolPerfil.Name = "lblRolPerfil";
            this.lblRolPerfil.Size = new System.Drawing.Size(35, 13);
            this.lblRolPerfil.TabIndex = 4;
            this.lblRolPerfil.Text = "label2";
            // 
            // lblFechaYHora
            // 
            this.lblFechaYHora.AutoSize = true;
            this.lblFechaYHora.Location = new System.Drawing.Point(95, 68);
            this.lblFechaYHora.Name = "lblFechaYHora";
            this.lblFechaYHora.Size = new System.Drawing.Size(35, 13);
            this.lblFechaYHora.TabIndex = 5;
            this.lblFechaYHora.Text = "label3";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 167);
            this.Controls.Add(this.grpMain);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main ERP";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslEstado;
        private System.Windows.Forms.GroupBox grpMain;
        private System.Windows.Forms.Label lblFechaYHora;
        private System.Windows.Forms.Label lblRolPerfil;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblFechaHoraE;
        private System.Windows.Forms.Label lblRolPerfilE;
        private System.Windows.Forms.Label lblUsuarioE;
    }
}

