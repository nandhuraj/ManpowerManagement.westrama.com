using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using TestApps.DAL;

namespace TestApps.BAL
{
    public class BusinessStaffType
    {
        DataStaffType objstaff = new DataStaffType();

        public int Insert(string StaffTypeName, int flag)
        {
            return objstaff.Insert(StaffTypeName, flag);
        }

        public int Update(int StaffTypeId, string StaffTypeName, int IsActive, int flag)
        {
            return objstaff.Update(StaffTypeId, StaffTypeName, IsActive, flag);
        }

        public DataTable Select(int flag, int StaffTypeId, string StaffTypeName)
        {
            return objstaff.Select(flag, StaffTypeId, StaffTypeName);
        }
    }
}
