using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace ManpowerManageWeb.DAS
{
    public class DataStaffDetails : DataServiceBase
    {
        int iResult = int.MinValue;
      
        
        public int Insert(string StaffId, string title, string StaffType, string UserType, string Firstname, string Lastname, string Address1, string Address2, string City, string State, string Country, string ContactNo, string EmergencyContactNo, string Email, string Qualification, string UserName, int flag)
        {
            iResult = ExecuteNonQuery("SP_MMS_MAS_STAFF_INSERT",

                CreateParameter("StaffId", SqlDbType.VarChar, StaffId),
                CreateParameter("title", SqlDbType.VarChar, title),
                CreateParameter("StaffType", SqlDbType.VarChar, StaffType),
                CreateParameter("UserType", SqlDbType.VarChar, UserType),
                CreateParameter("Firstname", SqlDbType.VarChar, Firstname),
                CreateParameter("Lastname", SqlDbType.VarChar, Lastname),
                CreateParameter("Address1", SqlDbType.VarChar, Address1),
                CreateParameter("Address2", SqlDbType.VarChar, Address2),
                CreateParameter("City", SqlDbType.VarChar, City),
                CreateParameter("State", SqlDbType.VarChar, State),
                CreateParameter("Country", SqlDbType.VarChar, Country),
                CreateParameter("ContactNo", SqlDbType.Int, ContactNo),
                CreateParameter("EmergencyContactNo", SqlDbType.Int, EmergencyContactNo),
                CreateParameter("Email", SqlDbType.VarChar, Email),
                CreateParameter("UserName", SqlDbType.VarChar, UserName),
                CreateParameter("Qualification", SqlDbType.VarChar, Qualification),
                CreateParameter("flag", SqlDbType.Int, flag));

            return iResult;            
        }

        public int Update(string StaffId, string title, string StaffType, string UserType, string Firstname, string Lastname, string Address1, string Address2, string City, string State, string Country, string ContactNo, string EmergencyContactNo, string Email, string Qualification, string UserName, int flag)
        {
            iResult = ExecuteNonQuery("SP_MMS_MAS_STAFF_INSERT",

                CreateParameter("StaffId", SqlDbType.VarChar, StaffId),
                CreateParameter("title", SqlDbType.VarChar, title),
                CreateParameter("StaffType", SqlDbType.VarChar, StaffType),
                CreateParameter("UserType", SqlDbType.VarChar, UserType),
                CreateParameter("Firstname", SqlDbType.VarChar, Firstname),
                CreateParameter("Lastname", SqlDbType.VarChar, Lastname),
                CreateParameter("Address1", SqlDbType.VarChar, Address1),
                CreateParameter("Address2", SqlDbType.VarChar, Address2),
                CreateParameter("City", SqlDbType.VarChar, City),
                CreateParameter("State", SqlDbType.VarChar, State),
                CreateParameter("Country", SqlDbType.VarChar, Country),
                CreateParameter("ContactNo", SqlDbType.Int, ContactNo),
                CreateParameter("EmergencyContactNo", SqlDbType.Int, EmergencyContactNo),
                CreateParameter("Email", SqlDbType.VarChar, Email),
                CreateParameter("UserName", SqlDbType.VarChar, UserName),
                CreateParameter("Qualification", SqlDbType.VarChar, Qualification),
                CreateParameter("flag", SqlDbType.Int, flag));

            return iResult;
        }

        public DataTable Select(bool flag, string StaffId)
        {
            return ExecuteDataTable("SP_MMS_MAS_STAFF_INFO",
                CreateParameter("flag", SqlDbType.Bit, flag, ParameterDirection.Input),
                CreateParameter("StaffId", SqlDbType.VarChar, StaffId, ParameterDirection.Input));
        }        
    }
}
