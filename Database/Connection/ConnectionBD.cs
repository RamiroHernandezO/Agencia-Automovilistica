using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Connection
{
    public class ConnectionBD
    {
        private SqlConnection conn = new SqlConnection("Data Source=FRIJOLITOLOL\\SQLEXPRESS;Initial Catalog=AgenciaAutomoviles;Integrated Security=True");


        public SqlConnection OpenConecction()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            return conn;

        }
        public SqlConnection CloseConecction()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            return conn;

        }
    }

}
