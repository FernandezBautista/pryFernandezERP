using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryFernandezERP
{
    public partial class frmRegistroPersonal : MaterialForm
    {
        public frmRegistroPersonal()
        {
            InitializeComponent();
            MaterialSkinManager.Instance.AddFormToManage(this);
        }

        private void frmRegistroPersonal_Load(object sender, EventArgs e)
        {
            CargarProvincias();
            CargarLocalidades();
            cmbLocalidad.Enabled = false;
            txtDni.MaxLength = 8;

            dgvDomicilios.Columns.Clear();
            dgvDomicilios.Columns.Add("Direccion", "Dirección");
            dgvDomicilios.Columns.Add("Provincia", "Provincia");
            dgvDomicilios.Columns.Add("Localidad", "Localidad");
            dgvDomicilios.AllowUserToAddRows = false;
            dgvDomicilios.AllowUserToDeleteRows = false;

            dgvContactos.Columns.Clear();
            dgvContactos.Columns.Add("Tipo", "Tipo");
            dgvContactos.Columns.Add("Valor", "Valor");
            dgvContactos.AllowUserToAddRows = false;
            dgvContactos.AllowUserToDeleteRows = false;
        }

        private void CargarProvincias()
        {
            CConexion cn = new CConexion();
            try
            {
                cn.conexion.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT Id, Provincia FROM Provincias ORDER BY Provincia", cn.conexion);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                cmbProvincia.DisplayMember = "Provincia";
                cmbProvincia.ValueMember = "Id";
                cmbProvincia.DataSource = dt;
                cmbProvincia.SelectedIndex = -1;
                cn.conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando provincias: " + ex.Message);
            }
        }

        private void CargarLocalidades()
        {
            CConexion cn = new CConexion();
            try
            {
                cn.conexion.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT Id, Localidad FROM Localidad ORDER BY Localidad", cn.conexion);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                cmbLocalidad.DisplayMember = "Localidad";
                cmbLocalidad.ValueMember = "Id";
                cmbLocalidad.DataSource = dt;
                cmbLocalidad.SelectedIndex = -1;
                cn.conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando localidades: " + ex.Message);
            }
        }

        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProvincia.SelectedItem == null)
            {
                cmbLocalidad.Enabled = false;
                cmbLocalidad.SelectedIndex = -1;
                return;
            }

            object idProv = cmbProvincia.SelectedValue;

            // Id 5 es Córdoba
            if (idProv != null && idProv.ToString() == "5")
            {
                cmbLocalidad.Enabled = true;
            }
            else
            {
                cmbLocalidad.Enabled = false;
                cmbLocalidad.SelectedIndex = -1;
            }
        }

        private void btnAgregarDomicilio_Click(object sender, EventArgs e)
        {
            if (txtDireccion.Text.Trim() == "")
            {
                MessageBox.Show("Ingresá una dirección antes de agregar.", "Dato faltante");
                return;
            }
            if (cmbProvincia.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccioná una provincia.", "Dato faltante");
                return;
            }

            dgvDomicilios.Rows.Add(
                txtDireccion.Text,
                cmbProvincia.Text,
                cmbLocalidad.Enabled && cmbLocalidad.SelectedIndex != -1 ? cmbLocalidad.Text : ""
            );

            txtDireccion.Text = "";
            cmbProvincia.SelectedIndex = -1;
            cmbLocalidad.SelectedIndex = -1;
            cmbLocalidad.Enabled = false;
        }

        private void btnAgregarTelefono_Click(object sender, EventArgs e)
        {
            if (txtTelefono.Text.Trim() == "")
            {
                MessageBox.Show("Ingresá un teléfono antes de agregar.", "Dato faltante");
                return;
            }

            dgvContactos.Rows.Add("Teléfono", txtTelefono.Text);
            txtTelefono.Text = "";
        }

        private void btnAgregarMail_Click(object sender, EventArgs e)
        {
            if (txtMail.Text.Trim() == "")
            {
                MessageBox.Show("Ingresá un mail antes de agregar.", "Dato faltante");
                return;
            }

            dgvContactos.Rows.Add("Mail", txtMail.Text);
            txtMail.Text = "";
        }

        private void btnCargarRedes_Click(object sender, EventArgs e)
        {
            if (cmbRedes.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccioná una red social.", "Dato faltante");
                return;
            }
            if (txtUsuario.Text.Trim() == "" || txtUsuario.Text == "@usuario")
            {
                MessageBox.Show("Ingresá el usuario de la red social.", "Dato faltante");
                return;
            }

            dgvContactos.Rows.Add(cmbRedes.Text, txtUsuario.Text);
            cmbRedes.SelectedIndex = -1;
            txtUsuario.Text = "@usuario";
        }

        private bool ValidarDNI(string dni)
        {
            if (string.IsNullOrWhiteSpace(dni)) return false;
            if (dni.Length < 7 || dni.Length > 8) return false;
            foreach (char c in dni)
                if (!char.IsDigit(c)) return false;
            return true;
        }

        private bool TieneContactoTipo(string tipo)
        {
            foreach (DataGridViewRow row in dgvContactos.Rows)
                if (row.Cells["Tipo"].Value?.ToString() == tipo) return true;
            return false;
        }

        private void btnCargarNvoPersonal_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("El campo Nombre es obligatorio.", "Dato faltante");
                return;
            }
            if (txtApellido.Text.Trim() == "")
            {
                MessageBox.Show("El campo Apellido es obligatorio.", "Dato faltante");
                return;
            }
            if (!ValidarDNI(txtDni.Text.Trim()))
            {
                MessageBox.Show("El DNI debe tener entre 7 y 8 dígitos numéricos.", "DNI inválido");
                return;
            }
            if (!TieneContactoTipo("Mail"))
            {
                MessageBox.Show("Agregá al menos un mail en contactos.", "Dato faltante");
                return;
            }
            if (!TieneContactoTipo("Teléfono"))
            {
                MessageBox.Show("Agregá al menos un teléfono en contactos.", "Dato faltante");
                return;
            }

            // Mail principal
            string mailPrincipal = "";
            foreach (DataGridViewRow row in dgvContactos.Rows)
                if (row.Cells["Tipo"].Value?.ToString() == "Mail")
                {
                    mailPrincipal = row.Cells["Valor"].Value?.ToString() ?? "";
                    break;
                }

            // Telefono principal
            string telefono = "";
            foreach (DataGridViewRow row in dgvContactos.Rows)
                if (row.Cells["Tipo"].Value?.ToString() == "Teléfono")
                {
                    telefono = row.Cells["Valor"].Value?.ToString() ?? "";
                    break;
                }

            // Domicilio de la grilla
            string direccion = "";
            object idProvincia = DBNull.Value;
            object idLocalidad = DBNull.Value;

            if (dgvDomicilios.Rows.Count > 0)
            {
                direccion = dgvDomicilios.Rows[0].Cells["Direccion"].Value?.ToString() ?? "";
                string nomProv = dgvDomicilios.Rows[0].Cells["Provincia"].Value?.ToString() ?? "";
                string nomLoc = dgvDomicilios.Rows[0].Cells["Localidad"].Value?.ToString() ?? "";

                if (nomProv != "")
                {
                    CConexion cnP = new CConexion();
                    cnP.conexion.Open();
                    OleDbCommand cmdP = new OleDbCommand("SELECT Id FROM Provincias WHERE Provincia = ?", cnP.conexion);
                    cmdP.Parameters.AddWithValue("@P", nomProv);
                    object res = cmdP.ExecuteScalar();
                    if (res != null) idProvincia = res;
                    cnP.conexion.Close();
                }

                if (nomLoc != "")
                {
                    CConexion cnL = new CConexion();
                    cnL.conexion.Open();
                    OleDbCommand cmdL = new OleDbCommand("SELECT Id FROM Localidad WHERE Localidad = ?", cnL.conexion);
                    cmdL.Parameters.AddWithValue("@L", nomLoc);
                    object res = cmdL.ExecuteScalar();
                    if (res != null) idLocalidad = res;
                    cnL.conexion.Close();
                }
            }

            // Activo
            bool activo = chkActivo.Checked;

            CConexion cn = new CConexion();
            try
            {
                cn.conexion.Open();
                string consulta = @"INSERT INTO Personal 
                                   (DNI, Nombre, Apellido, Telefono, Mail, Direccion, Id_Provincia, Id_Localidad, Activo)
                                   VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";
                OleDbCommand cmd = new OleDbCommand(consulta, cn.conexion);
                cmd.Parameters.AddWithValue("@DNI", txtDni.Text);
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@Mail", mailPrincipal);
                cmd.Parameters.AddWithValue("@Direccion", direccion);
                cmd.Parameters.AddWithValue("@Id_Provincia", idProvincia);
                cmd.Parameters.AddWithValue("@Id_Localidad", idLocalidad);
                cmd.Parameters.AddWithValue("@Activo", activo);
                cmd.ExecuteNonQuery();
                cn.conexion.Close();

                CAuditoria.Grabar("Registro de Personal: " + txtNombre.Text + " " + txtApellido.Text);
                MessageBox.Show("Personal registrado correctamente.");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            txtDireccion.Text = "";
            txtMail.Text = "";
            txtTelefono.Text = "";
            txtUsuario.Text = "@usuario";
            cmbProvincia.SelectedIndex = -1;
            cmbLocalidad.SelectedIndex = -1;
            cmbLocalidad.Enabled = false;
            cmbRedes.SelectedIndex = -1;
            chkActivo.Checked = false;
            dgvDomicilios.Rows.Clear();
            dgvContactos.Rows.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            CAuditoria.Grabar("Cierre de Sesión");
            Sesion.Usuario = "";
            Sesion.Rol = "";
            frmInicioS frm = new frmInicioS();
            frm.Show();
            this.Close();
        }
    }
}