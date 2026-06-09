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
        // Almacena el correo original para el WHERE del UPDATE final
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
            ModoEdicion(false); // Bloquea campos hasta que se realice una búsqueda exitosa
        }

        private void ConfigurarGrillas()
        {
            dgvDomicilios.Columns.Clear();
            dgvDomicilios.Columns.Add("Direccion", "Dirección");
            dgvDomicilios.Columns.Add("Provincia", "Provincia");
            dgvDomicilios.Columns.Add("Localidad", "Localidad");

            dgvContactos.Columns.Clear();
            dgvContactos.Columns.Add("Tipo", "Tipo");
            dgvContactos.Columns.Add("Valor", "Valor");
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
                OleDbCommand cmd = new OleDbCommand("SELECT Mail FROM Personal ORDER BY Mail", cn.conexion);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                cmbMail.DisplayMember = "Mail";
                cmbMail.DataSource = dt;
                cmbMail.SelectedIndex = -1;
                cn.conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando correos de búsqueda: " + ex.Message);
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
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbMail.Text.Trim()))
            {
                MessageBox.Show("Por favor, seleccione o ingrese un correo para buscar.", "Aviso");
                return;
            }

            CConexion cn = new CConexion();
            try
            {
                cn.conexion.Open();

                // 1. BUSCAR DATOS PRINCIPALES
                string query = "SELECT DNI, Nombre, Apellido, Telefono, Mail, Direccion, Id_Provincia, Id_Localidad FROM Personal WHERE Mail = ?";
                OleDbCommand cmd = new OleDbCommand(query, cn.conexion);
                cmd.Parameters.AddWithValue("@Mail", cmbMail.Text.Trim());

                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    mailOriginal = reader["Mail"].ToString();
                    string dniEmpleado = reader["DNI"].ToString(); // Guardamos el DNI para buscar en otras tablas

                    // Llenar TextBoxes
                    txtDni.Text = dniEmpleado;
                    txtNombre.Text = reader["Nombre"].ToString();
                    txtApellido.Text = reader["Apellido"].ToString();
                    txtMail.Text = reader["Mail"].ToString();
                    txtTelefono.Text = reader["Telefono"].ToString();
                    txtDireccion.Text = reader["Direccion"].ToString();

                    // Llenar ComboBoxes
                    if (reader["Id_Provincia"] != DBNull.Value)
                        cmbProvincia.SelectedValue = reader["Id_Provincia"];
                    else
                        cmbProvincia.SelectedIndex = -1;

                    if (reader["Id_Localidad"] != DBNull.Value)
                        cmbLocalidad.SelectedValue = reader["Id_Localidad"];
                    else
                        cmbLocalidad.SelectedIndex = -1;

                    // Limpiar grillas
                    dgvDomicilios.Rows.Clear();
                    dgvContactos.Rows.Clear();

                    // --- CARGAR DOMICILIO PRINCIPAL EN LA GRILLA ---
                    if (!string.IsNullOrEmpty(txtDireccion.Text))
                    {
                        // Extraemos el texto real del ComboBox para evitar que se cargue vacío en la grilla
                        string prov = cmbProvincia.SelectedIndex != -1 ? ((DataRowView)cmbProvincia.SelectedItem)["Provincia"].ToString() : "";
                        string loc = cmbLocalidad.SelectedIndex != -1 ? ((DataRowView)cmbLocalidad.SelectedItem)["Localidad"].ToString() : "";

                        dgvDomicilios.Rows.Add(txtDireccion.Text, prov, loc);
                    }

                    // --- CARGAR CONTACTOS PRINCIPALES EN LA GRILLA ---
                    if (!string.IsNullOrEmpty(txtMail.Text))
                        dgvContactos.Rows.Add("Mail", txtMail.Text);

                    if (!string.IsNullOrEmpty(txtTelefono.Text))
                        dgvContactos.Rows.Add("Teléfono", txtTelefono.Text);

                    reader.Close(); // Cerramos el reader principal para poder ejecutar otras consultas

                    // ====================================================================
                    // 2. BUSCAR DATOS ADICIONALES (REDES Y OTROS DOMICILIOS)
                    // ====================================================================
                    // ATENCIÓN: Para que esto funcione, en tu base de datos y en tu frmRegistroPersonal 
                    // tenés que haber creado y guardado datos en tablas como 'ContactoPersonal' o 'Redes'

                    try
                    {
                        // EJEMPLO: Si tenés una tabla "Redes" relacionada por DNI
                        string queryRedes = "SELECT TipoRed, Usuario FROM Redes WHERE DNI = ?";
                        OleDbCommand cmdRedes = new OleDbCommand(queryRedes, cn.conexion);
                        cmdRedes.Parameters.AddWithValue("@DNI", dniEmpleado);

                        OleDbDataReader readerRedes = cmdRedes.ExecuteReader();
                        while (readerRedes.Read())
                        {
                            dgvContactos.Rows.Add(readerRedes["TipoRed"].ToString(), readerRedes["Usuario"].ToString());
                        }
                        readerRedes.Close();
                    }
                    catch (Exception ex)
                    {
                        // Si la tabla no existe aún, ignoramos el error para que no se cuelgue el programa
                        Console.WriteLine("Aviso: No se pudo cargar redes extra. " + ex.Message);
                    }
                    // ====================================================================

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
                {
                    txtTelefono.Text = valor;
                }
                else if (tipo == "Mail")
                {
                    txtMail.Text = valor;
                }
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
                MessageBox.Show("Domicilio actualizado localmente en la tabla.", "Aviso");
            }
        }

        private void btnActualizarMail_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvContactos.Rows)
            {
                if (row.Cells["Tipo"].Value?.ToString() == "Mail")
                {
                    row.Cells["Valor"].Value = txtMail.Text;
                    MessageBox.Show("Mail actualizado localmente en la tabla.", "Aviso");
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
                    MessageBox.Show("Teléfono actualizado localmente en la tabla.", "Aviso");
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
                    MessageBox.Show("Red social actualizada localmente en la tabla.", "Aviso");
                    return;
                }
            }
            dgvContactos.Rows.Add(cmbRedes.Text, txtUsuario.Text);
        }

        private void btnGuardarEdicion_Click_1(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "" || txtApellido.Text.Trim() == "" || txtDni.Text.Trim() == "" || txtMail.Text.Trim() == "")
            {
                MessageBox.Show("Los campos Nombre, Apellido, DNI y Mail son obligatorios.", "Dato faltante");
                return;
            }

            CConexion cn = new CConexion();
            try
            {
                cn.conexion.Open();

                string query = @"UPDATE Personal 
                                 SET DNI = ?, Nombre = ?, Apellido = ?, Telefono = ?, Mail = ?, Direccion = ?, Id_Provincia = ?, Id_Localidad = ? 
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
                cmd.Parameters.AddWithValue("@MailOriginal", mailOriginal);

                cmd.ExecuteNonQuery();
                cn.conexion.Close();

                CAuditoria.Grabar("Modificación de Personal: " + txtNombre.Text + " " + txtApellido.Text);
                MessageBox.Show("Los cambios se guardaron correctamente en la base de datos.", "Éxito");

                LimpiarCampos();
                ModoEdicion(false);
                CargarCorreosBusqueda();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los cambios: " + ex.Message);
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
            cmbRedes.SelectedIndex = -1;
            cmbMail.SelectedIndex = -1;
            cmbMail.Text = "";
            dgvDomicilios.Rows.Clear();
            dgvContactos.Rows.Clear();
            mailOriginal = "";
        }
    }
}