using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using TestApps.DAL;

namespace TestApps.BAL
{
    public class BusinessStaffDetails
    {
        DataStaffDetails objstaff = new DataStaffDetails();

        public int Insert(int StaffId, string title, int StaffType, int UserType, string Firstname, string middlename, string Lastname, string Address1, string Address2, string City, string State, string zip, int Country, string ContactNo, string EmergencyContactNo, string Email, string Qualification, string UserName, int CustomerTypeID, int StaffTeamID, string StaffPosition, string StaffRate, string CommissionRate, string CommissionType, string Createdby, int flag)
        {
            return objstaff.Insert(StaffId,  title, StaffType, UserType, Firstname, middlename, Lastname, Address1, Address2, City, State, zip, Country, ContactNo, EmergencyContactNo, Email, Qualification, UserName, CustomerTypeID, StaffTeamID, StaffPosition, StaffRate, CommissionRate, CommissionType, Createdby, flag);
        }

        public int Update(int StaffId,  string title, int StaffType, int UserType, string Firstname, string middlename, string Lastname, string Address1, string Address2, string City, string State, string zip, int Country, string ContactNo, string EmergencyContactNo, string Email, string Qualification, string UserName, int CustomerTypeID, int StaffTeamID, string StaffPosition, string StaffRate, string CommissionRate, string CommissionType, string Createdby, int flag)
        {
            return objstaff.Update(StaffId,  title, StaffType, UserType, Firstname, middlename, Lastname, Address1, Address2, City, State, zip, Country, ContactNo, EmergencyContactNo, Email, Qualification, UserName, CustomerTypeID, StaffTeamID, StaffPosition, StaffRate, CommissionRate, CommissionType, Createdby, flag);
        }

        public DataTable Select(int flag, int StaffId)
        {
            return objstaff.Select(flag, StaffId);
        }

       
        public DataTable SelectStaffType(int flag, int StaffTypeId)
        {
            return objstaff.SelectStaffType(flag, StaffTypeId);
        }

        public DataTable SelectUserType(int flag, int UserTypeId)
        {
            return objstaff.SelectUserType(flag, UserTypeId);
        }

        public DataTable SelectStaffTeam(int flag, int StaffTeamId)
        {
            return objstaff.SelectStaffTeam(flag, StaffTeamId);
        }

        public DataTable SelectCustomerType(int flag, int CustomerTypeId)
        {
            return objstaff.SelectCustomerType(flag, CustomerTypeId);
        }
        public DataTable SelectCountry(int flag, int CountryId)
        {
            return objstaff.SelectCountry(flag, CountryId);
        }   
    }
}
