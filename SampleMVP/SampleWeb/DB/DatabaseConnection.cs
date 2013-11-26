using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ManpowerManageWeb.DB
{
    public class DatabaseConnection
    {
        public static string connectionString = string.Empty;
        public static void SetConnectionString(String connString)
        {
            connectionString = connString;
        }
        public static SqlConnection GetConnection()
        {

            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch
            {
                throw;
            }
            return connection;
        }
    }
}