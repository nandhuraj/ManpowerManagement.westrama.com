using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ManpowerManageWeb.Constant
{
    public class StaticProperty
    {
        public static string[] strtempRole = new string[] { "Staff", "Admin" };
        public static DataTable dTableStaffGrid { get; set; }
        public static DataTable dTableDDLLvType { get; set; }
        public static int insertOrUpdateErrorCnt { get; set; }

        public static DataTable CreateTableApplyLeaveStaff()
        {
            using (DataTable dtableGrid = new DataTable())
            {

                dtableGrid.Columns.Add("cLvTypeId");
                dtableGrid.Columns.Add("cStatus_StaffId");
                dtableGrid.Columns.Add("dFromDate");
                dtableGrid.Columns.Add("dToDate");
                dtableGrid.Columns.Add("tTotHours");
                dtableGrid.Columns.Add("cReason");
                dtableGrid.Columns.Add("cApprPersonId");
                dtableGrid.Columns.Add("cApprStatus");
                dtableGrid.Columns.Add("dLeaveReqDate");
                return dtableGrid;
            }
        }

        public static DataTable CreateTableLeaveType()
        {
            using (DataTable dtableddl = new DataTable())
            {

                dtableddl.Columns.Add("cLeaveTypeId");
                dtableddl.Columns.Add("cLeaveType");
                return dtableddl;
            }
        }
    }
}