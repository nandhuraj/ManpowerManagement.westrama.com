using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ManpowerManage.Entity
{
    public class ClientViewClass
    {
       
        public static int CompanyId { get; set; }
        public static string CompanyName { get; set; }
        public static string AdminOrStaff { get; set; }
        public static string SELECT { get; set; }
        public static int StaffId { get; set; }
       // public static int flagAddOrEdit { get; set; }
        public static DataSet dsGridClient { get; set; }

    }
}
