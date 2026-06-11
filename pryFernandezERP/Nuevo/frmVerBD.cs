using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryFernandezERP
{
    public partial class frmVerBD : MaterialForm
    {
        public frmVerBD()
        {
            InitializeComponent();
            MaterialSkinManager.Instance.AddFormToManage(this);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void CargarTablas()
        {
            cmbBD.Items.Clear();
            cmbBD.Items.Add("Personal");
            cmbBD.Items.Add("Provincias");
            cmbBD.Items.Add("Localidad");
            cmbBD.Items.Add("Roles");
            cmbBD.Items.Add("Usuario");
            cmbBD.Items.Add("Auditoria");
            cmbBD.SelectedIndex = -1;
        }

        private void btnBuscarBD_Click_1(object sender, EventArgs e)
        {
            if (cmbBD.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccioná una tabla.", "Aviso");
                return;
            }

            string tabla = cmbBD.SelectedItem.ToString();

            CConexion cn = new CConexion();
            try
            {
                cn.conexion.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM " + tabla, cn.conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBD.DataSource = dt;
                cn.conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando tabla: " + ex.Message);
            }
        }
    }
}