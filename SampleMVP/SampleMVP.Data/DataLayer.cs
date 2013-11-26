using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;


namespace ManpowerManage.Data
{
    public class DataLayer
    {
        private static DataLayer instance;

        private SqlDatabase db;

        private DataLayer()
        {
            db = new SqlDatabase(GetConnectionString());
        }

        public static DataLayer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataLayer();
                }

                return instance;
            }
        }

        private string GetConnectionString()
        {
            ConnectionStringSettings setting = ConfigurationManager.ConnectionStrings["ManpowerManageWeb.Properties.Settings.ConnectionString"];

            return setting.ConnectionString;

        }

        private void AddCommandParameters(DbCommand dbc, object[] parameters)
        {
            for (int i = 0; i < parameters.Length; i++)
            {
                SqlParameter sqlp = new SqlParameter();
                sqlp.ParameterName = string.Format("@{0}", i);
                sqlp.Value = parameters[i];

                if (parameters[i] is DateTime)
                {
                    sqlp.SqlDbType = SqlDbType.DateTime;
                    sqlp.Value = ((DateTime)parameters[i]).ToString("yyyy-MM-dd hh:mm:ss");
                }

                dbc.Parameters.Add(sqlp);
            }
        }

        private void AddCommandParameters(DbCommand dbc, KeyValuePair<string, object>[] parameters)
        {
            foreach (KeyValuePair<string, object> kvp in parameters)
            {
                SqlParameter sqlp = new SqlParameter();
                sqlp.ParameterName = kvp.Key;
                sqlp.Value = kvp.Value;
                if (kvp.Value is DateTime)
                {
                    sqlp.SqlDbType = SqlDbType.DateTime;
                    sqlp.Value = ((DateTime)kvp.Value).ToString("yyyy-MM-dd hh:mm:ss");
                }

                dbc.Parameters.Add(sqlp);
            }
        }

        public int ExecuteNonQuery(string query, params object[] parameters)
        {
            DbCommand dbc = db.GetSqlStringCommand(query);
            dbc.CommandType = CommandType.Text;
            AddCommandParameters(dbc, parameters);

            return db.ExecuteNonQuery(dbc);
        }

        public object ExecuteScalar(string query, params object[] parameters)
        {
            DbCommand dbc = db.GetSqlStringCommand(query);
            dbc.CommandType = CommandType.Text;
            AddCommandParameters(dbc, parameters);
            return db.ExecuteScalar(dbc);
        }

        public DataSet ExecuteDataSet(string query, params object[] parameters)
        {
            DbCommand dbc = db.GetSqlStringCommand(query);
            dbc.CommandType = CommandType.Text;
            AddCommandParameters(dbc, parameters);
            return db.ExecuteDataSet(dbc);

        }

        public int ExecuteNonQuerySP(string storedProcedureName, params KeyValuePair<string, object>[] parameters)
        {
            DbCommand dbc = db.GetStoredProcCommand(storedProcedureName);

            AddCommandParameters(dbc, parameters);

            return db.ExecuteNonQuery(dbc);
        }

        public int ExecuteNonQuerySP(string storedProcedureName, params SqlParameter[] parameters)
        {
            DbCommand dbc = db.GetStoredProcCommand(storedProcedureName);

            if (parameters != null && parameters.Length > 0)
                dbc.Parameters.AddRange(parameters);

            return db.ExecuteNonQuery(dbc);
        }

        public object ExecuteScalarSP(string storedProcedureName, params KeyValuePair<string, object>[] parameters)
        {
            DbCommand dbc = db.GetStoredProcCommand(storedProcedureName);

            AddCommandParameters(dbc, parameters);

            return db.ExecuteScalar(dbc);
        }

        public DataSet ExecuteDataSetSP(string storedProcedureName, params KeyValuePair<string, object>[] parameters)
        {
            DbCommand dbc = db.GetStoredProcCommand(storedProcedureName);

            AddCommandParameters(dbc, parameters);

            return db.ExecuteDataSet(dbc);

        }

    }
}
