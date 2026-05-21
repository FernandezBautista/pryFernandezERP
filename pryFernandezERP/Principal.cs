using System;
using System.Drawing;
using System.Windows.Forms;

namespace pryFernandezERP
{
    public partial class Principal : Form
    {
        string usuario;
        string rol;

        public Principal(string usuarioLogeado, string rolPerfil)
        {
            InitializeComponent();

            usuario = usuarioLogeado;

            rol = rolPerfil;
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            CConexion cn = new CConexion();

            try
            {
                cn.conexion.Open();

                tslEstado.Text = "Conectado";
                tslEstado.ForeColor = Color.Green;

                cn.conexion.Close();
            }
            catch (Exception ex)
            {
                tslEstado.Text = "Desconectado";
                tslEstado.ForeColor = Color.Red;

                MessageBox.Show(ex.Message);
            }

            lblUsuario.Text = usuario;

            lblRolPerfil.Text = rol;

            lblFechaYHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}