using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ManpowerManageWeb.DB;

namespace ManpowerManageWeb.DAS
{
    public class DataLogin 
    {
        //public DataTable Select()
        //{
        //    return ExecuteDataTable("SP_MMS_MAS_LOGIN_INFO");
        //}

        #region "Login By Srithar"
        public static DataTable GetLoginDetail()
         {
            SqlConnection connection = null;
            SqlCommand command = null;          
            try
            {
                connection = DatabaseConnection.GetConnection();
                command = new SqlCommand();
                string sqlQuery = "SP_MMS_MAS_LOGIN_INFO";

                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = sqlQuery;
                // Add Date Parameter            

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                using (DataTable busDetails = new DataTable())
                {
                    adapter.Fill(busDetails);
                    return busDetails;
                }
            }
            catch
            {
                return new DataTable();
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    connection.Dispose();
                    connection = null;
                }
                if (command != null)
                    command.Dispose();
            }
        }
        #endregion
    }
}
