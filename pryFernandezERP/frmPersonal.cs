using System;
using System.Data.OleDb;
using System.Net.Http;
using System.Windows.Forms;

namespace pryFernandezERP
{
    public partial class frmPersonal : Form
    {
        private static readonly HttpClient httpClient = new HttpClient();

        public frmPersonal()
        {
            InitializeComponent();
        }

        private void frmPersonal_Load(object sender, EventArgs e)
        {
            CargarProvincias();
            cmbLocalidad.Enabled = false;
            CAuditoria.Grabar("Ingreso a Personal");
            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "pryFernandezERP/1.0");

            dgvRedes.Columns.Clear();
            dgvRedes.Columns.Add("Red", "Red");
            dgvRedes.Columns.Add("Usuario", "Usuario");

            dgvDomicilio.Columns.Clear();
            dgvDomicilio.Columns.Add("Direccion", "Dirección");
            dgvDomicilio.Columns.Add("Provincia", "Provincia");
            dgvDomicilio.Columns.Add("Localidad", "Localidad");
            dgvDomicilio.Columns.Add("IdProvincia", "IdProvincia");
            dgvDomicilio.Columns["IdProvincia"].Visible = false;
            dgvDomicilio.Columns.Add("IdLocalidad", "IdLocalidad");
            dgvDomicilio.Columns["IdLocalidad"].Visible = false;
        }

        private void CargarProvincias()
        {
            CConexion cn = new CConexion();
            try
            {
                cn.conexion.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT Id, Provincia FROM Provincias", cn.conexion);
                OleDbDataReader lector = cmd.ExecuteReader();
                cmbProvincia.Items.Clear();
                while (lector.Read())
                {
                    ComboItem item = new ComboItem();
                    item.Text = lector["Provincia"].ToString();
                    item.Value = Convert.ToInt32(lector["Id"]);
                    cmbProvincia.Items.Add(item);
                }
                cn.conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarLocalidades()
        {
            CConexion cn = new CConexion();
            try
            {
                cn.conexion.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT Id, Localidad FROM Localidad", cn.conexion);
                OleDbDataReader lector = cmd.ExecuteReader();
                cmbLocalidad.Items.Clear();
                while (lector.Read())
                {
                    ComboItem item = new ComboItem();
                    item.Text = lector["Localidad"].ToString();
                    item.Value = Convert.ToInt32(lector["Id"]);
                    cmbLocalidad.Items.Add(item);
                }
                cn.conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProvincia.SelectedItem == null) return;
            if (((ComboItem)cmbProvincia.SelectedItem).Text == "Córdoba")
            {
                cmbLocalidad.Enabled = true;
                CargarLocalidades();
            }
            else
            {
                cmbLocalidad.Enabled = false;
                cmbLocalidad.Items.Clear();
            }
        }

        private void btnCargarDomicilio_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDireccion.Text) || cmbProvincia.SelectedItem == null || (cmbLocalidad.Enabled && cmbLocalidad.SelectedItem == null)) return;

            string direccion = txtDireccion.Text.Trim();
            string provincia = ((ComboItem)cmbProvincia.SelectedItem).Text;
            int idProvincia = ((ComboItem)cmbProvincia.SelectedItem).Value;
            string localidad = cmbLocalidad.SelectedItem != null ? ((ComboItem)cmbLocalidad.SelectedItem).Text : "";
            int idLocalidad = cmbLocalidad.SelectedItem != null ? ((ComboItem)cmbLocalidad.SelectedItem).Value : 0;

            dgvDomicilio.Rows.Add(direccion, provincia, localidad, idProvincia, idLocalidad);

            txtDireccion.Clear();
            cmbProvincia.SelectedIndex = -1;
            cmbLocalidad.Items.Clear();
            cmbLocalidad.Enabled = false;
        }

        private void btnCargarRedes_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbRedes.Text) || string.IsNullOrWhiteSpace(txtUsuario.Text)) return;
            dgvRedes.Rows.Add(cmbRedes.Text, txtUsuario.Text.Trim());
            txtUsuario.Clear();
        }

        private void btnCargar_Click_1(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            string redes = "";
            foreach (DataGridViewRow fila in dgvRedes.Rows)
            {
                if (fila.Cells[0].Value != null)
                {
                    redes += fila.Cells[0].Value.ToString() + ": " + fila.Cells[1].Value.ToString() + Environment.NewLine;
                }
            }

            string direcciones = "";
            int idProvinciaPrincipal = 0;
            int idLocalidadPrincipal = 0;

            if (dgvDomicilio.Rows.Count > 0)
            {
                idProvinciaPrincipal = Convert.ToInt32(dgvDomicilio.Rows[0].Cells[3].Value);
                idLocalidadPrincipal = Convert.ToInt32(dgvDomicilio.Rows[0].Cells[4].Value);

                foreach (DataGridViewRow fila in dgvDomicilio.Rows)
                {
                    if (fila.Cells[0].Value != null)
                    {
                        direcciones += fila.Cells[0].Value.ToString() + ", " + fila.Cells[1].Value.ToString() + " " + fila.Cells[2].Value.ToString() + Environment.NewLine;
                    }
                }
            }

            CConexion cn = new CConexion();
            try
            {
                cn.conexion.Open();

                string consulta = @"INSERT INTO Personal (DNI, Nombre, Apellido, Direccion, Id_Provincia, Id_Localidad, Mail, Telefono, Redes, Activo) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
                OleDbCommand cmd = new OleDbCommand(consulta, cn.conexion);

                cmd.Parameters.AddWithValue("@DNI", txtDni.Text.Trim());
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());
                cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text.Trim());
                cmd.Parameters.AddWithValue("@Direccion", direcciones.Trim());
                cmd.Parameters.AddWithValue("@Id_Provincia", idProvinciaPrincipal);
                cmd.Parameters.AddWithValue("@Id_Localidad", idLocalidadPrincipal);
                cmd.Parameters.AddWithValue("@Mail", txtMail.Text.Trim());
                cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text.Trim());
                cmd.Parameters.AddWithValue("@Redes", redes);
                cmd.Parameters.AddWithValue("@Activo", chkActivo.Checked);

                cmd.ExecuteNonQuery();

                cmd = new OleDbCommand("SELECT @@IDENTITY", cn.conexion);
                Sesion.IdPersonal = Convert.ToInt32(cmd.ExecuteScalar());

                cn.conexion.Close();

                MessageBox.Show("Datos guardados correctamente.");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtDni.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtMail.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                dgvDomicilio.Rows.Count == 0)
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return false;
            }
            return true;
        }

        private void LimpiarCampos()
        {
            txtDni.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtMail.Clear();
            txtTelefono.Clear();
            txtUsuario.Clear();
            cmbProvincia.SelectedIndex = -1;
            cmbLocalidad.Items.Clear();
            cmbLocalidad.Enabled = false;
            cmbRedes.SelectedIndex = -1;
            dgvRedes.Rows.Clear();
            dgvDomicilio.Rows.Clear();
            chkActivo.Checked = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Close();
        }
    }
}