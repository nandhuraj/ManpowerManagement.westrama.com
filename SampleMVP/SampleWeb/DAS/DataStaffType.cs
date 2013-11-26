using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;


namespace ManpowerManageWeb.DAS
{
    public class DataStaffType:DataServiceBase
    {
        int iResult = int.MinValue;
        DataServiceBase ds = new DataServiceBase();

        public int Insert(string StaffType, string StaffTypeName, string Description, int flag)
        {
            iResult = ExecuteNonQuery("SP_MMS_MAS_STAFFTYPE_INSERT",

                CreateParameter("StaffType", SqlDbType.VarChar, StaffType),
                CreateParameter("StaffTypeName", SqlDbType.VarChar, StaffTypeName),
                CreateParameter("Description", SqlDbType.VarChar, Description),
                CreateParameter("flag", SqlDbType.Int, flag));

            return iResult;
        }

        public int Update(string StaffType, string StaffTypeName, string Description, int flag)
        {
            iResult = ExecuteNonQuery("SP_MMS_MAS_STAFFTYPE_INSERT",

                CreateParameter("StaffType", SqlDbType.VarChar, StaffType),
                CreateParameter("StaffTypeName", SqlDbType.VarChar, StaffTypeName),
                CreateParameter("Description", SqlDbType.VarChar, Description),
                CreateParameter("flag", SqlDbType.Int, flag));

            return iResult;
        }

        public DataTable Select(bool flag, string StaffTypeId)
        {
            return ExecuteDataTable("SP_MMS_MAS_STAFFTYPE_INFO",
                CreateParameter("flag", SqlDbType.Bit, flag, ParameterDirection.Input),
                CreateParameter("StaffTypeId", SqlDbType.VarChar, StaffTypeId, ParameterDirection.Input));
        }     
    }
}
