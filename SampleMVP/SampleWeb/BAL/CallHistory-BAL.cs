using System.Data;
using ManpowerManageWeb.DAL;

namespace ManpowerManageWeb.BAL
{
    public class CallHistory_BAL
    {
        CallHistory_DAL objCalDAL = new CallHistory_DAL();

        /// <summary>
        /// Calling DA layer to get the dropdown values
        /// </summary>
        /// <returns></returns>
        public DataSet GetCADropdownValues()
        {
            DataSet ds = objCalDAL.GetCADropdownValues();
            return ds;
        }

        public int AddOrUpdateCallRegistry(CallRegistry objCalReg)
        {
            return objCalDAL.AddOrUpdateCallRegistry(objCalReg);
        }

        public DataSet GetCallDetails(int callID,int staffID, string today)
        {
            DataSet ds = objCalDAL.GetCallDetails(callID, staffID, today);
            return ds;
        }

        public DataTable GetSpecificCallDetail(int callID)
        {
            DataTable dt = objCalDAL.GetSpecificCallDetail(callID);
            return dt;
        }

        public int DeleteCallDetail(int callID)
        {
           return objCalDAL.DeleteCallDetail(callID);
        }

        public DataSet GetCallHistoryDetails(int staffID)
        {
            return objCalDAL.GetCallHistoryDetails(staffID);
        }

        public DataTable GetStaffDetails()
        {
            return objCalDAL.GetStaffDetails();
        }
    }

}