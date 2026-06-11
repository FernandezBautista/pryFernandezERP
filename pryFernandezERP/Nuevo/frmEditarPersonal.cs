using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryFernandezERP
{
    public partial class frmEditarPersonal : MaterialForm
    {
        private string mailOriginal = "";

        public frmEditarPersonal()
        {
            InitializeComponent();
            MaterialSkinManager.Instance.AddFormToManage(this);
        }

        private void frmEditarPersonal_Load(object sender, EventArgs e)
        {
            CargarProvincias();
            CargarLocalidades();
            CargarCorreosBusqueda();
            ConfigurarGrillas();
            cmbLocalidad.Enabled = false;
            txtDni.MaxLength = 8;
            ModoEdicion(false);
        }

        private void ConfigurarGrillas()
        {
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

        private void CargarCorreosBusqueda()
        {
            CConexion cn = new CConexion();
            try
            {
                cn.conexion.Open();
                OleDbCommand cmd = new OleDbCommand(
                    "SELECT Mail, DNI & ' - ' & Nombre & ' ' & Apellido AS NombreCompleto FROM Personal ORDER BY Apellido",
                    cn.conexion);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                cmbMail.DisplayMember = "NombreCompleto";
                cmbMail.ValueMember = "Mail";
                cmbMail.DataSource = dt;
                cmbMail.SelectedIndex = -1;
                cn.conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando personal: " + ex.Message);
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
            if (idProv != null && idProv.ToString() == "5")
                cmbLocalidad.Enabled = true;
            else
            {
                cmbLocalidad.Enabled = false;
                cmbLocalidad.SelectedIndex = -1;
            }
        }

        private void ModoEdicion(bool activado)
        {
            grpDatos.Enabled = activado;
            Domicilio.Enabled = activado;
            grpContacto.Enabled = activado;
            dgvDomicilios.Enabled = activado;
            dgvContactos.Enabled = activado;
            btnGuardarEdicion.Enabled = activado;
            chkActivo.Enabled = activado;
        }

        private bool ValidarDNI(string dni)
        {
            if (string.IsNullOrWhiteSpace(dni)) return false;
            if (dni.Length < 7 || dni.Length > 8) return false;
            foreach (char c in dni)
                if (!char.IsDigit(c)) return false;
            return true;
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbMail.Text.Trim()))
            {
                MessageBox.Show("Seleccioná o ingresá un correo para buscar.", "Aviso");
                return;
            }

            CConexion cn = new CConexion();
            try
            {
                cn.conexion.Open();

                string query = "SELECT DNI, Nombre, Apellido, Telefono, Mail, Direccion, Id_Provincia, Id_Localidad, Activo FROM Personal WHERE Mail = ?";
                OleDbCommand cmd = new OleDbCommand(query, cn.conexion);
                cmd.Parameters.AddWithValue("@Mail", cmbMail.SelectedValue?.ToString().Trim());
                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    mailOriginal = reader["Mail"].ToString();

                    txtDni.Text = reader["DNI"].ToString();
                    txtNombre.Text = reader["Nombre"].ToString();
                    txtApellido.Text = reader["Apellido"].ToString();
                    txtMail.Text = reader["Mail"].ToString();
                    txtTelefono.Text = reader["Telefono"].ToString();
                    txtDireccion.Text = reader["Direccion"].ToString();

                    chkActivo.Checked = reader["Activo"] != DBNull.Value && (bool)reader["Activo"];

                    string idProv = reader["Id_Provincia"] != DBNull.Value ? reader["Id_Provincia"].ToString() : "";
                    string idLoc = reader["Id_Localidad"] != DBNull.Value ? reader["Id_Localidad"].ToString() : "";

                    if (reader["Id_Provincia"] != DBNull.Value)
                        cmbProvincia.SelectedValue = reader["Id_Provincia"];
                    else
                        cmbProvincia.SelectedIndex = -1;

                    if (reader["Id_Localidad"] != DBNull.Value)
                        cmbLocalidad.SelectedValue = reader["Id_Localidad"];
                    else
                        cmbLocalidad.SelectedIndex = -1;

                    string direccion = reader["Direccion"].ToString();
                    string mail = reader["Mail"].ToString();
                    string tel = reader["Telefono"].ToString();

                    reader.Close();

                    string nomProvincia = "";
                    string nomLocalidad = "";

                    if (idProv != "")
                    {
                        OleDbCommand cmdProv = new OleDbCommand("SELECT Provincia FROM Provincias WHERE Id = ?", cn.conexion);
                        cmdProv.Parameters.AddWithValue("@Id", idProv);
                        object resProv = cmdProv.ExecuteScalar();
                        if (resProv != null) nomProvincia = resProv.ToString();
                    }

                    if (idLoc != "")
                    {
                        OleDbCommand cmdLoc = new OleDbCommand("SELECT Localidad FROM Localidad WHERE Id = ?", cn.conexion);
                        cmdLoc.Parameters.AddWithValue("@Id", idLoc);
                        object resLoc = cmdLoc.ExecuteScalar();
                        if (resLoc != null) nomLocalidad = resLoc.ToString();
                    }

                    dgvDomicilios.Rows.Clear();
                    dgvContactos.Rows.Clear();

                    if (!string.IsNullOrEmpty(direccion))
                        dgvDomicilios.Rows.Add(direccion, nomProvincia, nomLocalidad);

                    if (!string.IsNullOrEmpty(mail))
                        dgvContactos.Rows.Add("Mail", mail);

                    if (!string.IsNullOrEmpty(tel))
                        dgvContactos.Rows.Add("Teléfono", tel);

                    if (dgvDomicilios.Rows.Count > 0)
                        dgvDomicilios.Rows[0].Selected = true;

                    if (dgvContactos.Rows.Count > 0)
                        dgvContactos.Rows[0].Selected = true;

                    ModoEdicion(true);
                }
                else
                {
                    MessageBox.Show("No se encontró ningún personal con ese correo.", "Sin resultados");
                    ModoEdicion(false);
                    LimpiarCampos();
                }

                cn.conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private void dgvDomicilios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDomicilios.CurrentRow != null && e.RowIndex >= 0)
            {
                txtDireccion.Text = dgvDomicilios.CurrentRow.Cells["Direccion"].Value?.ToString();
                cmbProvincia.Text = dgvDomicilios.CurrentRow.Cells["Provincia"].Value?.ToString();
                cmbLocalidad.Text = dgvDomicilios.CurrentRow.Cells["Localidad"].Value?.ToString();
            }
        }

        private void dgvContactos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvContactos.CurrentRow != null && e.RowIndex >= 0)
            {
                string tipo = dgvContactos.CurrentRow.Cells["Tipo"].Value?.ToString();
                string valor = dgvContactos.CurrentRow.Cells["Valor"].Value?.ToString();

                if (tipo == "Teléfono")
                    txtTelefono.Text = valor;
                else if (tipo == "Mail")
                    txtMail.Text = valor;
                else
                {
                    cmbRedes.Text = tipo;
                    txtUsuario.Text = valor;
                }
            }
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            if (dgvDomicilios.CurrentRow != null)
            {
                dgvDomicilios.CurrentRow.Cells["Direccion"].Value = txtDireccion.Text;
                dgvDomicilios.CurrentRow.Cells["Provincia"].Value = cmbProvincia.Text;
                dgvDomicilios.CurrentRow.Cells["Localidad"].Value = cmbLocalidad.Text;
                MessageBox.Show("Domicilio actualizado.", "Aviso");
            }
        }

        private void btnActualizarMail_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvContactos.Rows)
            {
                if (row.Cells["Tipo"].Value?.ToString() == "Mail")
                {
                    row.Cells["Valor"].Value = txtMail.Text;
                    MessageBox.Show("Mail actualizado.", "Aviso");
                    return;
                }
            }
            dgvContactos.Rows.Add("Mail", txtMail.Text);
        }

        private void btnActualizarTel_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvContactos.Rows)
            {
                if (row.Cells["Tipo"].Value?.ToString() == "Teléfono")
                {
                    row.Cells["Valor"].Value = txtTelefono.Text;
                    MessageBox.Show("Teléfono actualizado.", "Aviso");
                    return;
                }
            }
            dgvContactos.Rows.Add("Teléfono", txtTelefono.Text);
        }

        private void btnActualizarRed_Click_1(object sender, EventArgs e)
        {
            if (cmbRedes.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccioná una red social.", "Dato faltante");
                return;
            }

            foreach (DataGridViewRow row in dgvContactos.Rows)
            {
                if (row.Cells["Tipo"].Value?.ToString() == cmbRedes.Text)
                {
                    row.Cells["Valor"].Value = txtUsuario.Text;
                    MessageBox.Show("Red social actualizada.", "Aviso");
                    return;
                }
            }
            dgvContactos.Rows.Add(cmbRedes.Text, txtUsuario.Text);
        }

        private void btnGuardarEdicion_Click_1(object sender, EventArgs e)
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
            if (txtMail.Text.Trim() == "")
            {
                MessageBox.Show("El campo Mail es obligatorio.", "Dato faltante");
                return;
            }

            CConexion cn = new CConexion();
            try
            {
                cn.conexion.Open();

                string query = @"UPDATE Personal 
                                 SET DNI = ?, Nombre = ?, Apellido = ?, Telefono = ?, Mail = ?, Direccion = ?, Id_Provincia = ?, Id_Localidad = ?, Activo = ?
                                 WHERE Mail = ?";

                OleDbCommand cmd = new OleDbCommand(query, cn.conexion);
                cmd.Parameters.AddWithValue("@DNI", txtDni.Text);
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                cmd.Parameters.AddWithValue("@Mail", txtMail.Text);
                cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                cmd.Parameters.AddWithValue("@Id_Provincia", cmbProvincia.SelectedValue ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Id_Localidad", cmbLocalidad.SelectedValue ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Activo", chkActivo.Checked);
                cmd.Parameters.AddWithValue("@MailOriginal", mailOriginal);

                cmd.ExecuteNonQuery();
                cn.conexion.Close();

                CAuditoria.Grabar("Modificación de Personal: " + txtNombre.Text + " " + txtApellido.Text);
                MessageBox.Show("Cambios guardados correctamente.", "Éxito");

                LimpiarCampos();
                ModoEdicion(false);
                CargarCorreosBusqueda();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
            ModoEdicion(false);
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
            cmbMail.SelectedIndex = -1;
            cmbMail.Text = "";
            chkActivo.Checked = false;
            dgvDomicilios.Rows.Clear();
            dgvContactos.Rows.Clear();
            mailOriginal = "";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            CAuditoria.Grabar("Cierre de Sesión");
            Sesion.Usuario = "";
            Sesion.Rol = "";
            frmInicioS frm = new frmInicioS();
            frm.Show();
            this.Close();
        }

        private void cmbMail_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}