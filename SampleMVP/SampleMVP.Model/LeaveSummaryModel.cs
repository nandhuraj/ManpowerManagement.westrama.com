using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ManpowerManage.Data;
using System.Data;

namespace ManpowerManage.Model
{
    public class LeaveSummaryModel
    {
        private string spGetLeaveSummary = "spLeaveSummary";

        public DataSet GetLeaveLeaveSummary(int StaffId)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@staffRoleCode", StaffId);          
            return DataLayer.Instance.ExecuteDataSetSP(spGetLeaveSummary, parameters.ToArray());
        }
    }
}
