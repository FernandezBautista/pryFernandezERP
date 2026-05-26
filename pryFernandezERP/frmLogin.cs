using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pryFernandezERP
{
    public partial class frmLogin : Form
    {
        int intentos = 3;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblUsuarioLogin_Click(object sender, EventArgs e)
        {

        }

        private void lblContraseñaLogin_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            CConexion cn = new CConexion();

            try
            {
                cn.conexion.Open();

                string consulta = "SELECT Roles FROM Roles";

                OleDbCommand comando = new OleDbCommand(consulta, cn.conexion);

                OleDbDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    cmbPerfil.Items.Add(lector["Roles"].ToString());
                }

                cn.conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIniciarSesion_Click_1(object sender, EventArgs e)
        {
            CConexion cn = new CConexion();

            try
            {
                cn.conexion.Open();

                string consulta = @"SELECT Usuario.Nombre, Perfil.Nombre AS Rol
                                    FROM (Usuario
                                    INNER JOIN [Usuario-Perfil]
                                    ON Usuario.Id_Usuario = [Usuario-Perfil].Id_Usuario)
                                    INNER JOIN Perfil
                                    ON [Usuario-Perfil].Id_Perfil = Perfil.Id_Perfil
                                    WHERE Mail = ? AND Contraseña = ?";

                OleDbCommand comando = new OleDbCommand(consulta, cn.conexion);

                comando.Parameters.AddWithValue("@Mail", txtUsuarioLogin.Text);

                comando.Parameters.AddWithValue("@Contraseña", txtContraseñaLogin.Text);

                OleDbDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    string usuario = lector["Nombre"].ToString();
                    string rol = lector["Rol"].ToString();

                    Sesion.Usuario = lector["Rol"].ToString();
                    Sesion.Rol = rol;

                    CAuditoria.Grabar("Inicio de Sesión");

                    string perfilSeleccionado = cmbPerfil.Text;

                    MessageBox.Show("Bienvenido");

                    if (perfilSeleccionado == "Recursos Humanos")
                    {
                        frmPersonal frm = new frmPersonal();

                        frm.Show();

                        this.Hide();
                    }
                    else if (perfilSeleccionado == "Administrador")
                    {
                        Principal frm = new Principal(usuario, rol);

                        frm.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Perfil sin formulario asignado");
                    }
                }
                else
                {
                    intentos--;

                    MessageBox.Show("Usuario o contraseña incorrectos\nIntentos restantes: " + intentos);

                    if (intentos == 0)
                    {
                        MessageBox.Show("Se agotaron los intentos");

                        btnIniciarSesion.Enabled = false;
                    }
                }

                cn.conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}