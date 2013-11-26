using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ManpowerManage.View;
using ManpowerManage.Model;
using System.Data;
using ManpowerManage.View;

namespace ManpowerManage.Presenter
{
    public class LeavePresenter
    {
        private ILeaveType ileaveType;
        private LeaveTypeModel leaveTypeModel;

        public LeavePresenter(ILeaveType LeaveTypeview)
        {
            ileaveType = LeaveTypeview;
        }

        public DataSet SaveNewLeaveType()
        {
            using (DataSet ds = new DataSet())
            {
                leaveTypeModel = new LeaveTypeModel();
                return leaveTypeModel.AddLeaveType(ileaveType.CreatedBy, ileaveType.cLeaveType, ileaveType.Days, ileaveType.Year, ileaveType.Flag);
            }
        }

        public DataSet UpdateDeleteLeaveType()
        {
            using (DataSet ds = new DataSet())
            {
                leaveTypeModel = new LeaveTypeModel();
                return leaveTypeModel.UpdateOrDeleteLeaveType(ileaveType.nLeaveTypeId, ileaveType.CreatedBy, ileaveType.cLeaveType, ileaveType.Days, ileaveType.Year, ileaveType.Flag);
            }
        }

        public DataSet GetLeaveTypePresent()
        {
            using (DataSet ds = new DataSet())
            {
               
                leaveTypeModel = new LeaveTypeModel();
                return leaveTypeModel.GetLeaveType(ileaveType.CreatedBy, ileaveType.cLeaveType, ileaveType.Days, ileaveType.Year, ileaveType.Flag);
            }

        }


    }
}
