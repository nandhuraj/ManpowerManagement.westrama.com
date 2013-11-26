using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ManpowerManage.Data;

namespace ManpowerManage.Model
{
    public class LeaveApprovalOrApplyModel
    {
        private string spGetOrAplyOrApprOrCancel = "spLeaveApplyAndType";
       
        // data access layer     
        #region "Apply Or Appr Or Cancel Function"
        public DataSet GetOrApplyOrApprFun(int UserID, int LeaveTypeID, string FromDate, string ToDate, string TotHours, string Reason, int UserTypeId, int cFLAG, string UserType)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@staffRoleCode", UserID);
            parameters.Add("@LeavTypeId", LeaveTypeID);
            parameters.Add("@FromDate", FromDate);
            parameters.Add("@ToDate", ToDate);
            parameters.Add("@TotHours", TotHours);
            parameters.Add("@Reason", Reason);
            parameters.Add("@ApprPersonId",UserTypeId);
            parameters.Add("@FLAG", cFLAG);
            parameters.Add("@STAFF_FLAG", UserType);

            return DataLayer.Instance.ExecuteDataSetSP(spGetOrAplyOrApprOrCancel, parameters.ToArray());
        }
        #endregion

    }
}
