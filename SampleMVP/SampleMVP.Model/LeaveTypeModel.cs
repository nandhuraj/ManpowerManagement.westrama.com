using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ManpowerManage.Data;

namespace ManpowerManage.Model
{
    public class LeaveTypeModel
    {
        private string spUpdateOrDeleteOrGridSelect = "spLeaveTypeUpdOrDelAndSelect";
        private string spAddNewOrSelectDropOrGrid = "spLeaveTypeInsertAndSelect";
        // data access layer     
        #region "Add client Function"
        public DataSet AddLeaveType(int createdBy, string LeaveType, int cDays, int cYear,int flagInsertOrSelect)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@CreatedBy", createdBy);
            parameters.Add("@LeaveType", LeaveType);
            parameters.Add("@cDays", cDays);
            parameters.Add("@cYear", cYear);
            parameters.Add("@flagInsertOrSelect", flagInsertOrSelect);
           
            return DataLayer.Instance.ExecuteDataSetSP(spAddNewOrSelectDropOrGrid, parameters.ToArray());
        }
        #endregion

        public DataSet UpdateOrDeleteLeaveType(int LeaveTypeId,int createdBy, string LeaveType, int cDays, int cYear, int flagInsertOrSelect)
                                       
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@LeaveTypeId", LeaveTypeId);
            parameters.Add("@CreatedBy", createdBy);
            parameters.Add("@LeaveType", LeaveType);
            parameters.Add("@cDays", cDays);
            parameters.Add("@cYear", cYear);
            parameters.Add("@flagUpdatOrDelete", flagInsertOrSelect);

            return DataLayer.Instance.ExecuteDataSetSP(spUpdateOrDeleteOrGridSelect, parameters.ToArray());
        }

        // Get Client for updation Window or Search through Textbox by Copany Name
        public DataSet GetLeaveType(int createdBy, string LeaveType, int cDays, int cYear, int flagInsertOrSelect)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@CreatedBy", createdBy);
            parameters.Add("@LeaveType", LeaveType);
            parameters.Add("@cDays", cDays);
            parameters.Add("@cYear", cYear);
            parameters.Add("@flagInsertOrSelect", flagInsertOrSelect);
            return DataLayer.Instance.ExecuteDataSetSP(spAddNewOrSelectDropOrGrid, parameters.ToArray());
        }
    }
}
