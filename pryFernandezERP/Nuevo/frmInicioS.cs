using System;
using System.Data.OleDb;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace pryFernandezERP
{
    public partial class frmInicioS : MaterialForm
    {
        int intentos = 3;

        public frmInicioS()
        {
            InitializeComponent();
            MaterialSkinManager.Instance.AddFormToManage(this);
            this.AcceptButton = materialButton2;
        }

        private void frmInicioS_Load(object sender, EventArgs e)
        {
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            CConexion cn = new CConexion();
            try
            {
                cn.conexion.Open();
                string consulta = @"SELECT Perfil.Nombre AS NombrePerfil, Roles.Roles AS NombreRol
                                    FROM ((Usuario
                                    INNER JOIN [Usuario-Perfil] ON Usuario.Id_Usuario = [Usuario-Perfil].Id_Usuario)
                                    INNER JOIN Perfil ON [Usuario-Perfil].Id_Perfil = Perfil.Id_Perfil)
                                    INNER JOIN (UsuarioRol 
                                    INNER JOIN Roles ON UsuarioRol.Id_Rol = Roles.Id_Rol)
                                    ON Usuario.Id_Usuario = UsuarioRol.Id_Usuario
                                    WHERE Usuario.Mail = ? AND Usuario.Contraseña = ?";
                OleDbCommand comando = new OleDbCommand(consulta, cn.conexion);
                comando.Parameters.AddWithValue("@Mail", txtUsuario.Text);
                comando.Parameters.AddWithValue("@Contraseña", txtContraseña.Text);
                OleDbDataReader lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    Sesion.Usuario = lector["NombrePerfil"].ToString();
                    Sesion.Rol = lector["NombreRol"].ToString();
                    CAuditoria.Grabar("Inicio de Sesión");
                    MessageBox.Show("Bienvenido " + Sesion.Usuario);
                    frmMain frm = new frmMain();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    intentos--;
                    MessageBox.Show("Usuario o contraseña incorrectos\nIntentos restantes: " + intentos);
                    if (intentos == 0)
                    {
                        MessageBox.Show("Se agotaron los intentos");
                        materialButton2.Enabled = false;
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

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkContraseña_CheckedChanged(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = !chkContraseña.Checked;
        }
    }
}