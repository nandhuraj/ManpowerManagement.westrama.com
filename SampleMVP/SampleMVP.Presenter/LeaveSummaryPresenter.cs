using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ManpowerManage.View;
using ManpowerManage.Model;
using System.Data;

namespace ManpowerManage.Presenter
{
    public class LeaveSummaryPresenter
    {
        private LeaveSummaryModel leaveSummary;
        private int StaffID = 0;

        public LeaveSummaryPresenter(int StaffId)
        {
            StaffID = StaffId;
        }

        public DataSet GetLeaveSummary()
        {
            using (DataSet ds = new DataSet())
            {
                leaveSummary = new LeaveSummaryModel();
                return leaveSummary.GetLeaveLeaveSummary(StaffID);
            }
        }
    }
}
