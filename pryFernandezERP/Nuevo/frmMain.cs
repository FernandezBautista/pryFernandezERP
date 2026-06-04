using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryFernandezERP
{
    public partial class frmMain : MaterialForm
    {
        public frmMain()
        {
            InitializeComponent();
            MaterialSkinManager.Instance.AddFormToManage(this);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            bool esAdmin = Sesion.Rol == "Administrador";
            bool esRRHH = Sesion.Rol == "Recursos Humanos";

            personalToolStripMenuItem.Visible = esAdmin || esRRHH;
            auditoriaToolStripMenuItem.Visible = esAdmin;

            lblUsuario.Text = "Usuario: " + Sesion.Usuario;
            lblRol.Text = "Rol: " + Sesion.Rol;
            lblHora.Text = "Inicio: " + DateTime.Now.ToString("HH:mm:ss");

            statusStrip1.Items.Clear();
            statusStrip1.Items.Add("● Base de datos conectada");
            statusStrip1.Items[0].ForeColor = Color.FromArgb(34, 139, 34);
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroPersonal frm = new frmRegistroPersonal();
            frm.Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // proximamente
        }

        private void verRegistrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAuditoria frm = new frmAuditoria();
            frm.Show();
        }
    }
}