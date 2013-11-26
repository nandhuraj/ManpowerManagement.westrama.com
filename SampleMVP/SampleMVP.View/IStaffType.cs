using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManpowerManage.View
{
    public interface IStaffType
    {
        int StaffTypeID { get; set; }
        string StaffType { get; set; }
        int IsActive { get; set; }
        int Flag { get; set; }
    }
}
