using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManpowerManage.View
{
    public interface ILeaveType
    {
       int CreatedBy { get; set; }
       int nLeaveTypeId { get; set; }
       string cLeaveType { get; set; }
       int Days { get; set; }
       int Year { get; set; }
       int Flag { get; set; } // This flag for Used to check in SP Insert or update or Delete and Select

    }
}
