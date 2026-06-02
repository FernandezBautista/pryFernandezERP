using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryFernandezERP
{
    public partial class frmLogin : Form
    {
        int intentos = 3;

        public frmLogin()
        {
            InitializeComponent();
            this.AcceptButton = btnIniciarSesion;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            CConexion cn = new CConexion();
            try
            {
                cn.conexion.Open();
                OleDbCommand comando = new OleDbCommand("SELECT Roles FROM Roles", cn.conexion);
                OleDbDataReader lector = comando.ExecuteReader();
                cmbPerfil.Items.Clear();
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

                string consulta = @"SELECT Perfil.Nombre AS NombrePerfil
                                    FROM (Usuario
                                    INNER JOIN [Usuario-Perfil] ON Usuario.Id_Usuario = [Usuario-Perfil].Id_Usuario)
                                    INNER JOIN Perfil ON [Usuario-Perfil].Id_Perfil = Perfil.Id_Perfil
                                    WHERE Usuario.Mail = ? AND Usuario.Contraseña = ?";

                OleDbCommand comando = new OleDbCommand(consulta, cn.conexion);
                comando.Parameters.AddWithValue("@Mail", txtUsuarioLogin.Text);
                comando.Parameters.AddWithValue("@Contraseña", txtContraseñaLogin.Text);

                OleDbDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    string nombrePerfil = lector["NombrePerfil"].ToString();
                    string rolSeleccionado = cmbPerfil.Text;

                    Sesion.Usuario = nombrePerfil;
                    Sesion.Rol = rolSeleccionado;

                    CAuditoria.Grabar("Inicio de Sesión");

                    MessageBox.Show("Bienvenido " + nombrePerfil);

                    if (rolSeleccionado == "Recursos Humanos")
                    {
                        frmPersonal frm = new frmPersonal();
                        frm.Show();
                        this.Hide();
                    }
                    else if (rolSeleccionado == "Administrador")
                    {
                        Principal frm = new Principal(nombrePerfil, rolSeleccionado);
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