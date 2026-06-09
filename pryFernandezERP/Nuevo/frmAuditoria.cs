using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace pryFernandezERP
{
    public partial class frmAuditoria : MaterialForm
    {
        public frmAuditoria()
        {
            InitializeComponent();
            MaterialSkinManager.Instance.AddFormToManage(this);
        }

        private void frmInformacion_Load(object sender, EventArgs e)
        {
            CAuditoria.Grabar("Ingreso a Auditoria");
            CargarUsuarios();
            CargarAcciones();
            MostrarTodo();
        }

        private void CargarUsuarios()
        {
            CConexion cn = new CConexion();
            try
            {
                cn.conexion.Open();
                OleDbCommand cmd = new OleDbCommand(
                    "SELECT DISTINCT Usuario FROM Auditoria ORDER BY Usuario", cn.conexion);
                OleDbDataReader lector = cmd.ExecuteReader();
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Todos");
                while (lector.Read())
                    comboBox1.Items.Add(lector["Usuario"].ToString());
                comboBox1.SelectedIndex = 0;
                cn.conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando usuarios: " + ex.Message);
            }
        }

        private void CargarAcciones()
        {
            CConexion cn = new CConexion();
            try
            {
                cn.conexion.Open();
                OleDbCommand cmd = new OleDbCommand(
                    "SELECT DISTINCT Accion FROM Auditoria ORDER BY Accion", cn.conexion);
                OleDbDataReader lector = cmd.ExecuteReader();
                cmbAccion.Items.Clear();
                cmbAccion.Items.Add("Todas");
                while (lector.Read())
                    cmbAccion.Items.Add(lector["Accion"].ToString());
                cmbAccion.SelectedIndex = 0;
                cn.conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando acciones: " + ex.Message);
            }
        }

        private void MostrarTodo()
        {
            CConexion cn = new CConexion();
            try
            {
                cn.conexion.Open();
                OleDbDataAdapter da = new OleDbDataAdapter(
                    "SELECT Id_Auditoria, Usuario, Accion, [Fecha y Hora] FROM Auditoria ORDER BY [Fecha y Hora] DESC",
                    cn.conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAuditoria.DataSource = dt;
                cn.conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando auditoría: " + ex.Message);
            }
        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            cmbAccion.SelectedIndex = 0;
            MostrarTodo();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string usuario = comboBox1.SelectedItem?.ToString();
            string accion = cmbAccion.SelectedItem?.ToString();
            DateTime fecha = calendario.SelectionStart.Date;

            string where = "WHERE 1=1";
            if (usuario != "Todos" && usuario != null)
                where += " AND Usuario = '" + usuario + "'";
            if (accion != "Todas" && accion != null)
                where += " AND Accion = '" + accion + "'";
            where += " AND DateValue([Fecha y Hora]) = #" + fecha.ToString("MM/dd/yyyy") + "#";

            CConexion cn = new CConexion();
            try
            {
                cn.conexion.Open();
                OleDbDataAdapter da = new OleDbDataAdapter(
                    "SELECT Id_Auditoria, Usuario, Accion, [Fecha y Hora] FROM Auditoria " + where +
                    " ORDER BY [Fecha y Hora] DESC", cn.conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAuditoria.DataSource = dt;
                if (dt.Rows.Count == 0)
                    MessageBox.Show("No se encontraron registros.");
                cn.conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void grpFiltrar_Enter(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbAccion_SelectedIndexChanged(object sender, EventArgs e) { }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e) { }
        private void dgvAuditoria_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void btnTodo_Click_1(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            cmbAccion.SelectedIndex = 0;
            MostrarTodo();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            string usuario = comboBox1.SelectedItem?.ToString();
            string accion = cmbAccion.SelectedItem?.ToString();
            DateTime fecha = calendario.SelectionStart.Date;

            string where = "WHERE 1=1";
            if (usuario != "Todos" && usuario != null)
                where += " AND Usuario = '" + usuario + "'";
            if (accion != "Todas" && accion != null)
                where += " AND Accion = '" + accion + "'";
            where += " AND DateValue([Fecha y Hora]) = #" + fecha.ToString("MM/dd/yyyy") + "#";

            CConexion cn = new CConexion();
            try
            {
                cn.conexion.Open();
                OleDbDataAdapter da = new OleDbDataAdapter(
                    "SELECT Id_Auditoria, Usuario, Accion, [Fecha y Hora] FROM Auditoria " + where +
                    " ORDER BY [Fecha y Hora] DESC", cn.conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAuditoria.DataSource = dt;
                if (dt.Rows.Count == 0)
                    MessageBox.Show("No se encontraron registros.");
                cn.conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }
    }
}