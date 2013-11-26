using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManpowerManage.Entity
{
    public class StaffType
    {
        public int StaffTypeID { get; set; }
        public string Stafftype { get; set; }
        public int IsActive { get; set; }
        public int Flag { get; set; }
    }
}
