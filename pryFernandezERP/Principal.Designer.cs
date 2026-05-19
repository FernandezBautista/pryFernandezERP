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
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblEConexion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(126, 428);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(77, 13);
            this.lblEstado.TabIndex = 0;
            this.lblEstado.Text = "Desconectado";
            // 
            // lblEConexion
            // 
            this.lblEConexion.AutoSize = true;
            this.lblEConexion.Location = new System.Drawing.Point(12, 428);
            this.lblEConexion.Name = "lblEConexion";
            this.lblEConexion.Size = new System.Drawing.Size(108, 13);
            this.lblEConexion.TabIndex = 1;
            this.lblEConexion.Text = "Estado Conexion BD:";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEConexion);
            this.Controls.Add(this.lblEstado);
            this.Name = "Principal";
            this.Text = "Main ERP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblEConexion;
    }
}

