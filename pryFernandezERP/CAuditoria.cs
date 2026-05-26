using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryFernandezERP
{
    public static class CAuditoria
    {
        public static void Grabar(string accion)
        {
            CConexion cn = new CConexion();
            try
            {
                cn.conexion.Open();
                string consulta = "INSERT INTO Auditoria (Usuario, Accion, [Fecha y Hora]) VALUES (?, ?, ?)";
                OleDbCommand cmd = new OleDbCommand(consulta, cn.conexion);
                cmd.Parameters.AddWithValue("@Usuario", Sesion.Usuario ?? "Desconocido");
                cmd.Parameters.AddWithValue("@Accion", accion);
                OleDbParameter paramFecha = new OleDbParameter("@FechaHora", OleDbType.Date);
                paramFecha.Value = DateTime.Now;
                cmd.Parameters.Add(paramFecha);
                cmd.ExecuteNonQuery();
                cn.conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error auditoría: " + ex.Message);
            }
        }
    }
}