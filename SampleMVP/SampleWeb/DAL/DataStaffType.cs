using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using ManpowerManageWeb;

namespace TestApps.DAL
{
    public class DataStaffType:DataServiceBase
    {
        int iResult = int.MinValue;
        DataServiceBase ds = new DataServiceBase();

        public int Insert(string StaffTypeName, int flag)
        {
            iResult = ExecuteNonQuery("SpStaffTypeInsert",
                CreateParameter("@StaffTypeID", SqlDbType.Int, 0),
                CreateParameter("@StaffTypeName", SqlDbType.VarChar, StaffTypeName),
                CreateParameter("@IsActive", SqlDbType.Int, 1),
                CreateParameter("@flag", SqlDbType.Int, flag));

            return iResult;
        }

        public int Update(int StaffTypeId, string StaffTypeName, int IsActive, int flag)
        {
            iResult = ExecuteNonQuery("SpStaffTypeInsert",
                CreateParameter("@StaffTypeID", SqlDbType.Int, StaffTypeId),
                CreateParameter("@StaffTypeName", SqlDbType.VarChar, StaffTypeName),
                CreateParameter("@IsActive", SqlDbType.Int, IsActive),
                CreateParameter("@flag", SqlDbType.Int, flag));

            return iResult;
        }

        public DataTable Select(int flag, int StaffTypeId, string StaffTypeName)
        {
            return ExecuteDataTable("SpStaffTypeSelect",
                CreateParameter("@flag", SqlDbType.Int, flag, ParameterDirection.Input),
                CreateParameter("@StaffTypeID", SqlDbType.Int, StaffTypeId, ParameterDirection.Input),
                CreateParameter("@StaffTypeName", SqlDbType.VarChar, StaffTypeName));
        }
    }
}
