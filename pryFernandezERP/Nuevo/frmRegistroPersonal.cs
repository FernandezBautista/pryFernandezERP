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

            // columnas dgvDomicilios
            dgvDomicilios.Columns.Clear();
            dgvDomicilios.Columns.Add("Direccion", "Dirección");
            dgvDomicilios.Columns.Add("Provincia", "Provincia");
            dgvDomicilios.Columns.Add("Localidad", "Localidad");

            // columnas dgvContactos
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
            if (cmbLocalidad.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccioná una localidad.", "Dato faltante");
                return;
            }

            dgvDomicilios.Rows.Add(
                txtDireccion.Text,
                cmbProvincia.Text,
                cmbLocalidad.Text
            );

            txtDireccion.Text = "";
            cmbProvincia.SelectedIndex = -1;
            cmbLocalidad.SelectedIndex = -1;
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
            if (txtDni.Text.Trim() == "")
            {
                MessageBox.Show("El campo DNI es obligatorio.", "Dato faltante");
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
                string consulta = @"INSERT INTO Personal 
                                   (DNI, Nombre, Apellido, Telefono, Mail, Direccion, Id_Provincia, Id_Localidad)
                                   VALUES (?, ?, ?, ?, ?, ?, ?, ?)";
                OleDbCommand cmd = new OleDbCommand(consulta, cn.conexion);
                cmd.Parameters.AddWithValue("@DNI", txtDni.Text);
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                cmd.Parameters.AddWithValue("@Mail", txtMail.Text);
                cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                cmd.Parameters.AddWithValue("@Id_Provincia", cmbProvincia.SelectedValue ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Id_Localidad", cmbLocalidad.SelectedValue ?? DBNull.Value);
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
            dgvDomicilios.Rows.Clear();
            dgvContactos.Rows.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
    }
}