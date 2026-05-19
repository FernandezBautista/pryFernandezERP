using System;
using System.Drawing;
using System.Windows.Forms;

namespace pryFernandezERP
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
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
        }
    }
}