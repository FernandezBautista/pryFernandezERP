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
    public partial class frmContacto : Form
    {
        public frmContacto()
        {
            InitializeComponent();
        }

        private void frmContacto_Load(object sender, EventArgs e)
        {
            CAuditoria.Grabar("Ingreso a Contacto");

            dgvRedes.Columns.Clear();

            dgvRedes.Columns.Add("Red", "Red");

            dgvRedes.Columns.Add("Usuario", "Usuario");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grpRedes_Enter(object sender, EventArgs e)
        {

        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbRedes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCargarRedes_Click(object sender, EventArgs e)
        {
            if (cmbRedes.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una red.");

                return;
            }

            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Ingrese un usuario.");

                return;
            }

            string red = cmbRedes.Text;

            string usuario = txtUsuario.Text.Trim();

            dgvRedes.Rows.Add(red, usuario);

            txtUsuario.Clear();
        }

        private void dgvRedes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chkActivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPersonal frm = new frmPersonal();

            frm.Show();

            this.Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMail.Text))
            {
                MessageBox.Show("Ingrese el mail.");

                return;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Ingrese el teléfono.");

                return;
            }

            string redes = "";

            foreach (DataGridViewRow fila in dgvRedes.Rows)
            {
                if (fila.Cells[0].Value != null)
                {
                    redes += fila.Cells[0].Value.ToString()
                           + ": "
                           + fila.Cells[1].Value.ToString()
                           + Environment.NewLine;
                }
            }

            CConexion cn = new CConexion();

            try
            {
                cn.conexion.Open();

                string consulta = @"UPDATE Personal
                                    SET Mail = ?,
                                        Telefono = ?,
                                        Redes = ?,
                                        Activo = ?
                                    WHERE Id_Personal = ?";

                OleDbCommand cmd = new OleDbCommand(consulta, cn.conexion);

                cmd.Parameters.AddWithValue("@Mail", txtMail.Text.Trim());

                cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text.Trim());

                cmd.Parameters.AddWithValue("@Redes", redes);

                cmd.Parameters.AddWithValue("@Activo", chkActivo.Checked);

                cmd.Parameters.AddWithValue("@Id_Personal", Sesion.IdPersonal);

                cmd.ExecuteNonQuery();

                cn.conexion.Close();

                MessageBox.Show("Contacto guardado correctamente.");

                Principal frm = new Principal(Sesion.Usuario, Sesion.Rol);

                frm.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar contacto: " + ex.Message);
            }
        }
    }
}