using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class SqlClient
    {
        /*public SqlConnection Conecction { get; }

        public SqlClient(string connectionString)
        {
            Conecction = new SqlConnection(connectionString);
        }*/

        private static SqlConnection Conecction { get; set; }
        private static SqlClient _sqlClient;

        private SqlClient(string connectionString)
        {
            Conecction = new SqlConnection(connectionString);
        }

        public static SqlClient GetSqlClient(string connectionString)
        {
            if(Conecction == null)
            {
                _sqlClient = new SqlClient(connectionString);
            }
            return _sqlClient;
        }

        public SqlConnection GetConnection()
        {
            return Conecction;
        }
        public bool Open()
        {
            try
            {
                Conecction.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Close()
        {
            try
            {
                if (Conecction.State == System.Data.ConnectionState.Open)
                    Conecction.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
