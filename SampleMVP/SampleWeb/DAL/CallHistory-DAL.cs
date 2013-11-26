using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System;
using System.Configuration;
using System.Data;
using System.Data.Common;

namespace ManpowerManageWeb.DAL
{
    public class CallHistory_DAL
    {
        //Database connection string detail
       // public Database objDb = new SqlDatabase("Data Source=Mals-PC;Initial Catalog=MMS_DB;Integrated Security=True");

        public Database objDb = new SqlDatabase(Properties.Settings.Default.ConnectionString);

        /// <summary>
        /// Connecting the DB and add / update the call details
        /// </summary>
        /// <param name="objCalReg"></param>
        /// <returns></returns>
        public int AddOrUpdateCallRegistry(CallRegistry objCalReg)
        {    
            
            DbCommand objCmd = objDb.GetStoredProcCommand("spAddOrUpdateCallHistory");
            objDb.AddInParameter(objCmd, "@CallID", DbType.Int32, objCalReg.CallID);
            objDb.AddInParameter(objCmd, "@StaffID", DbType.Int32, objCalReg.StaffID);
            objDb.AddInParameter(objCmd, "@CallDateTime", DbType.DateTime,objCalReg.CallDateTime);
            objDb.AddInParameter(objCmd, "@Industry", DbType.Int32, objCalReg.Industry);
            objDb.AddInParameter(objCmd, "@Company", DbType.String, objCalReg.CompanyName);
            objDb.AddInParameter(objCmd, "@Phone", DbType.String, objCalReg.Phone);
            objDb.AddInParameter(objCmd, "@Email", DbType.String, objCalReg.Email);
            objDb.AddInParameter(objCmd, "@AlternatePhone", DbType.String, objCalReg.AlternatePhone);
            objDb.AddInParameter(objCmd, "@Reference", DbType.Int32, objCalReg.Reference);
            objDb.AddInParameter(objCmd, "@MarketingCategory", DbType.Int32, objCalReg.MarketingCategory);
            objDb.AddInParameter(objCmd, "@MarketingStatus", DbType.Int32, objCalReg.MarketingStatus);
            objDb.AddInParameter(objCmd, "@Reminder", DbType.String, objCalReg.Reminder);
            objDb.AddInParameter(objCmd, "@Activity", DbType.String, objCalReg.Activity);
            objDb.AddInParameter(objCmd, "@FEmail", DbType.String, objCalReg.FEmail);
            objDb.AddInParameter(objCmd, "@SendProfile", DbType.Int16, objCalReg.SendProfile);
            objDb.AddInParameter(objCmd, "@NoOfCandidate", DbType.Int32, objCalReg.NoOfCandidate);
            objDb.AddInParameter(objCmd, "@Opportunity", DbType.Int32, objCalReg.Opportunity);

            int returnSeqValue = Convert.ToInt32(objDb.ExecuteScalar(objCmd));
            return returnSeqValue;
        }

        /// <summary>
        /// Connecting the DB and return the dropdown values
        /// </summary>
        /// <returns></returns>
        public DataSet GetCADropdownValues()
        {
           // Database objDb = new SqlDatabase(Convert.ToString(ConfigurationManager.ConnectionStrings["MMSConn"]));
            DbCommand objCmd = objDb.GetStoredProcCommand("spGetCallRegisteryDDValues");
            DataSet ds = objDb.ExecuteDataSet(objCmd);
            return ds;
        }

        /// <summary>
        /// Connecting the DBa nd return the all call details based on staff
        /// </summary>
        /// <param name="callID"></param>
        /// <param name="staffID"></param>
        /// <returns></returns>
        public DataSet GetCallDetails(int callID, int staffID, string today)
        {
           // Database objDb = new SqlDatabase(Convert.ToString(ConfigurationManager.ConnectionStrings["MMSConn"]));
            DbCommand objCmd = objDb.GetStoredProcCommand("spGetCallDetails");
            objDb.AddInParameter(objCmd, "@CallID", DbType.Int32, callID);
            objDb.AddInParameter(objCmd, "@StaffID", DbType.Int32, staffID);
            objDb.AddInParameter(objCmd, "@CallDate", DbType.String, today);
            DataSet ds = objDb.ExecuteDataSet(objCmd);
            return ds;
        }

        /// <summary>
        /// Connecting the DB and return the specific call detail based on call ID
        /// </summary>
        /// <param name="callID"></param>
        /// <returns></returns>
        public DataTable GetSpecificCallDetail(int callID)
        {
           // Database objDb = new SqlDatabase(Convert.ToString(ConfigurationManager.ConnectionStrings["MMSConn"]));
            DbCommand objCmd = objDb.GetStoredProcCommand("spGetSpecificCallDetail");
            objDb.AddInParameter(objCmd, "@CallID", DbType.Int32, callID);            
            DataSet ds = objDb.ExecuteDataSet(objCmd);
            return ds.Tables[0];
        }

        public int DeleteCallDetail(int callID)
        {
            DbCommand objCmd = objDb.GetStoredProcCommand("spDeleteCallRegistry");
            objDb.AddInParameter(objCmd, "@CallID", DbType.Int32, callID);

            int returnSeqValue = Convert.ToInt32(objDb.ExecuteNonQuery(objCmd));
            return returnSeqValue;
        }

        public DataSet GetCallHistoryDetails(int staffID)
        {
            DbCommand objCmd = objDb.GetStoredProcCommand("spGetCallHistoryDetails");            
            objDb.AddInParameter(objCmd, "@StaffID", DbType.Int32, staffID);          
            DataSet ds = objDb.ExecuteDataSet(objCmd);
            return ds;
        }

        public DataTable GetStaffDetails()
        {
            DbCommand objCmd = objDb.GetStoredProcCommand("spGetStaffDetails");            
            DataTable dt = objDb.ExecuteDataSet(objCmd).Tables[0];
            return dt;
        }
    }
}