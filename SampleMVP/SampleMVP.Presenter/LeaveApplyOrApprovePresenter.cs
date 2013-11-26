using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ManpowerManage.View;
using System.Data;
using ManpowerManage.Model;

namespace ManpowerManage.Presenter
{
    public class LeaveApplyOrApprovePresenter
    {
        private ILeaveApplyOrApproval iLeaveAppr;
        private LeaveApprovalOrApplyModel leaveApplyApprModel;

        public LeaveApplyOrApprovePresenter(ILeaveApplyOrApproval iLeaveApprview)
        {
            iLeaveAppr = iLeaveApprview;
        }

        public DataSet GetOrApplyOrAppr()
        {
            using (DataSet ds = new DataSet())
            {
                leaveApplyApprModel = new LeaveApprovalOrApplyModel();
                return leaveApplyApprModel.GetOrApplyOrApprFun(iLeaveAppr.cStatus_StaffId,iLeaveAppr.cLvTypeId,iLeaveAppr.dFromDate,iLeaveAppr.dToDate,iLeaveAppr.tTotHours,iLeaveAppr.cReason,iLeaveAppr.cApprPersonId,
                   iLeaveAppr.flagInsertOrLoad,iLeaveAppr.StaffFlag);
            }
        }

       
    }
}
