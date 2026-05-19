using System.Data.OleDb;

namespace pryFernandezERP
{
    internal class CConexion
    {
        public OleDbConnection conexion;

        public CConexion()
        {
            conexion = new OleDbConnection(
                @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BD\Fernandez.accdb"
            );
        }
    }
}