using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using ManpowerManageWeb;

namespace TestApps.DAL
{
    public class DataStaffDetails : DataServiceBase
    {
        int iResult = int.MinValue;
        DataServiceBase ds = new DataServiceBase();

        public int Insert(int StaffId,  string title, int StaffType, int UserType, string Firstname, string middlename, string Lastname, string Address1, string Address2, string City, string State, string zip, int Country, string ContactNo, string EmergencyContactNo, string Email, string Qualification, string UserName, int CustomerTypeID, int StaffTeamID, string StaffPosition, string StaffRate, string CommissionRate, string CommissionType, string Createdby, int flag)
        {
            iResult = ExecuteNonQuery("SpStaffDetailsInsert",

                CreateParameter("@UserId", SqlDbType.Int, StaffId),
                CreateParameter("@Title", SqlDbType.VarChar, title),                
                CreateParameter("@FirstName", SqlDbType.VarChar, Firstname),
                CreateParameter("@MiddleName", SqlDbType.VarChar, middlename),
                CreateParameter("@LastName", SqlDbType.VarChar, Lastname),
                CreateParameter("@Address1", SqlDbType.VarChar, Address1),
                CreateParameter("@Address2", SqlDbType.VarChar, Address2),
                CreateParameter("@City", SqlDbType.VarChar, City),
                CreateParameter("@State", SqlDbType.VarChar, State),
                CreateParameter("@Zip", SqlDbType.VarChar, zip),
                CreateParameter("@CountryID", SqlDbType.Int, Country),
                CreateParameter("@PrimaryPhone", SqlDbType.VarChar, ContactNo),
                CreateParameter("@SecondaryPhone", SqlDbType.VarChar, EmergencyContactNo),
                CreateParameter("@EmailId", SqlDbType.VarChar, Email),
                CreateParameter("@UserName", SqlDbType.VarChar, UserName),
                CreateParameter("@Qualification", SqlDbType.VarChar, Qualification),
                CreateParameter("@StaffTypeID", SqlDbType.Int, StaffType),
                CreateParameter("@UserTypeId", SqlDbType.Int, UserType),
                CreateParameter("@CustomerTypeID", SqlDbType.Int, CustomerTypeID),
                CreateParameter("@StaffTeamID", SqlDbType.Int, StaffTeamID),
                CreateParameter("@StaffRate", SqlDbType.VarChar, StaffRate),
                CreateParameter("@StaffPosition", SqlDbType.VarChar, StaffPosition),
                CreateParameter("@Published", SqlDbType.Int, 1),
                CreateParameter("@CommissionRate", SqlDbType.VarChar, CommissionRate),
                CreateParameter("@CommissionType", SqlDbType.VarChar, CommissionType),
                CreateParameter("@CreatedBy", SqlDbType.VarChar, Createdby),
                CreateParameter("@flag", SqlDbType.Int, flag));

            return iResult;
        }

        public int Update(int StaffId, string title, int StaffType, int UserType, string Firstname, string middlename, string Lastname, string Address1, string Address2, string City, string State, string zip, int Country, string ContactNo, string EmergencyContactNo, string Email, string Qualification, string UserName, int CustomerTypeID, int StaffTeamID, string StaffPosition, string StaffRate, string CommissionRate, string CommissionType, string Createdby, int flag)
        {
            iResult = ExecuteNonQuery("SpStaffDetailsInsert",

                CreateParameter("@UserId", SqlDbType.Int, StaffId),
                CreateParameter("@Title", SqlDbType.VarChar, title),
                CreateParameter("@FirstName", SqlDbType.VarChar, Firstname),
                CreateParameter("@MiddleName", SqlDbType.VarChar, middlename),
                CreateParameter("@LastName", SqlDbType.VarChar, Lastname),
                CreateParameter("@Address1", SqlDbType.VarChar, Address1),
                CreateParameter("@Address2", SqlDbType.VarChar, Address2),
                CreateParameter("@City", SqlDbType.VarChar, City),
                CreateParameter("@State", SqlDbType.VarChar, State),
                CreateParameter("@Zip", SqlDbType.VarChar, zip),
                CreateParameter("@CountryID", SqlDbType.Int, Country),
                CreateParameter("@PrimaryPhone", SqlDbType.VarChar, ContactNo),
                CreateParameter("@SecondaryPhone", SqlDbType.VarChar, EmergencyContactNo),
                CreateParameter("@EmailId", SqlDbType.VarChar, Email),
                CreateParameter("@UserName", SqlDbType.VarChar, UserName),
                CreateParameter("@Qualification", SqlDbType.VarChar, Qualification),
                CreateParameter("@StaffTypeID", SqlDbType.Int, StaffType),
                CreateParameter("@UserTypeId", SqlDbType.Int, UserType),
                CreateParameter("@CustomerTypeID", SqlDbType.Int, CustomerTypeID),
                CreateParameter("@StaffTeamID", SqlDbType.Int, StaffTeamID),
                CreateParameter("@StaffRate", SqlDbType.VarChar, StaffRate),
                CreateParameter("@StaffPosition", SqlDbType.VarChar, StaffPosition),
                CreateParameter("@Published", SqlDbType.Int, 1),
                CreateParameter("@CommissionRate", SqlDbType.VarChar, CommissionRate),
                CreateParameter("@CommissionType", SqlDbType.VarChar, CommissionType),
                CreateParameter("@CreatedBy", SqlDbType.VarChar, Createdby),
                CreateParameter("@flag", SqlDbType.Int, flag));

            return iResult;
        }

        public DataTable Select(int flag, int StaffId)
        {
            return ExecuteDataTable("SpStaffDetailsSelect",
                CreateParameter("@flag", SqlDbType.Int, flag, ParameterDirection.Input),
                CreateParameter("@cStaffId", SqlDbType.Int, StaffId, ParameterDirection.Input));
        }

        
        public DataTable SelectStaffType(int flag, int StaffTypeId)
        {
            return ExecuteDataTable("SpStaffTypeSelect",
               CreateParameter("@flag", SqlDbType.Int, flag, ParameterDirection.Input),
               CreateParameter("@StaffTypeName", SqlDbType.VarChar, "", ParameterDirection.Input),
               CreateParameter("@StaffTypeId", SqlDbType.Int, StaffTypeId, ParameterDirection.Input));
        }

        public DataTable SelectUserType(int flag, int UserTypeId)
        {
            return ExecuteDataTable("SpUserTypeSelect",
               CreateParameter("@flag", SqlDbType.Int, flag, ParameterDirection.Input),
               CreateParameter("@UserId", SqlDbType.Int, UserTypeId, ParameterDirection.Input));
        }

        public DataTable SelectStaffTeam(int flag, int StaffTeamId)
        {
            return ExecuteDataTable("SpStaffTeamSelect",
               CreateParameter("@flag", SqlDbType.Int, flag, ParameterDirection.Input),
               CreateParameter("@StaffTeamId", SqlDbType.Int, StaffTeamId, ParameterDirection.Input));
        }

        public DataTable SelectCustomerType(int flag, int CustomerTypeId)
        {
            return ExecuteDataTable("SpCustomerTypeSelect",
               CreateParameter("@flag", SqlDbType.Int, flag, ParameterDirection.Input),
               CreateParameter("@CustomerTypeId", SqlDbType.Int, CustomerTypeId, ParameterDirection.Input));
        }
        public DataTable SelectCountry(int flag, int CountryId)
        {
            return ExecuteDataTable("SpCountrySelect",
               CreateParameter("@flag", SqlDbType.Int, flag, ParameterDirection.Input),
               CreateParameter("@CountryId", SqlDbType.Int, CountryId, ParameterDirection.Input));
        }  
    }
}
