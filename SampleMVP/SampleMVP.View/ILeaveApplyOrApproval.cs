using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManpowerManage.View
{
   
        public interface ILeaveApplyOrApproval
        {           
            int cStatus_StaffId { get; set; }
            int cLvTypeId { get; set; }
            string dFromDate { get; set; }
            string dToDate { get; set; }           
            string tTotHours { get; set; }
            string cReason { get; set; }
            int cApprPersonId { get; set; }               
            int flagInsertOrLoad { get; set; }
            string StaffFlag { get; set; }
        }

    //    @staffRoleCode varchar(10),
    //@LeavTypeId varchar(10),	
    //@FromDate varchar(20), 
    //@ToDate varchar(20), 
    //@TotHours int, 
    //@Reason nvarchar(100), 
    //@ApprPersonId varchar(10),   
    //@FLAG int,
    //@STAFF_FLAG varchar(5)
    
}
