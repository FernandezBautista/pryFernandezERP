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
using System.Net.Http;
using System.Web.Script.Serialization;

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
        }

        private void CargarProvincias()
        {
            CConexion cn = new CConexion();

            try
            {
                cn.conexion.Open();

                string consulta = "SELECT Id, Provincia FROM Provincias";

                OleDbCommand cmd = new OleDbCommand(consulta, cn.conexion);

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
                MessageBox.Show("Error al cargar provincias: " + ex.Message);
            }
        }

        private void CargarLocalidades()
        {
            CConexion cn = new CConexion();

            try
            {
                cn.conexion.Open();

                string consulta = "SELECT Id, Localidad FROM Localidad";

                OleDbCommand cmd = new OleDbCommand(consulta, cn.conexion);

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
                MessageBox.Show("Error al cargar localidades: " + ex.Message);
            }
        }

        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProvincia.SelectedItem == null) return;

            ComboItem seleccionado = (ComboItem)cmbProvincia.SelectedItem;

            string provincia = seleccionado.Text;

            if (provincia == "Córdoba")
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

        private async void txtDireccion_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDireccion.Text)) return;

            string direccion = txtDireccion.Text.Trim();

            if (cmbProvincia.SelectedItem != null)
            {
                ComboItem prov = (ComboItem)cmbProvincia.SelectedItem;

                direccion += ", " + prov.Text + ", Argentina";
            }
            else
            {
                direccion += ", Argentina";
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            CConexion cn = new CConexion();

            try
            {
                cn.conexion.Open();

                ComboItem provSeleccionada = (ComboItem)cmbProvincia.SelectedItem;

                int idProvincia = provSeleccionada.Value;

                int idLocalidad = 0;

                if (cmbLocalidad.SelectedItem != null)
                {
                    ComboItem localSeleccionada = (ComboItem)cmbLocalidad.SelectedItem;

                    idLocalidad = localSeleccionada.Value;
                }

                string consulta = @"INSERT INTO Personal
                                    (DNI, Nombre, Apellido, Direccion, Id_Provincia, Id_Localidad)
                                    VALUES (?, ?, ?, ?, ?, ?)";

                OleDbCommand cmd = new OleDbCommand(consulta, cn.conexion);

                cmd.Parameters.AddWithValue("@DNI", txtDni.Text.Trim());

                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());

                cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text.Trim());

                cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text.Trim());

                cmd.Parameters.AddWithValue("@Id_Provincia", idProvincia);

                cmd.Parameters.AddWithValue("@Id_Localidad", idLocalidad);

                cmd.ExecuteNonQuery();

                cmd = new OleDbCommand("SELECT @@IDENTITY", cn.conexion);

                Sesion.IdPersonal = Convert.ToInt32(cmd.ExecuteScalar());

                cn.conexion.Close();

                MessageBox.Show("Personal cargado correctamente.");

                frmContacto frm = new frmContacto();

                frm.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtDni.Text))
            {
                MessageBox.Show("Ingrese el DNI.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el Nombre.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Ingrese el Apellido.");
                return false;
            }

            if (cmbProvincia.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una Provincia.");
                return false;
            }

            if (cmbLocalidad.Enabled && cmbLocalidad.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una Localidad.");
                return false;
            }

            return true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();

            frm.Show();

            this.Close();
        }
    }
}