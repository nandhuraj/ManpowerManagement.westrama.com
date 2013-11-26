using ManpowerManage.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ManpowerManage.Model
{
    public class StaffDetailsModel
    {
        public DataSet Insert(int StaffId, string title, int StaffType, int UserType, string Firstname, string middlename, string Lastname, string Address1, string Address2, string City, string State, string zip, int Country, string ContactNo, string EmergencyContactNo, string Email, string Qualification, string UserName, int CustomerTypeID, int StaffTeamID, string StaffPosition, string StaffRate, string CommissionRate, string CommissionType, int Createdby, int flag)
        {          

            Dictionary<string, object> parameters = new Dictionary<string, object>();           

                parameters.Add("@UserId", StaffId);
                parameters.Add("@Title", title);
                parameters.Add("@FirstName", Firstname);
                parameters.Add("@MiddleName", middlename);
                parameters.Add("@LastName", Lastname);
                parameters.Add("@Address1", Address1);
                parameters.Add("@Address2", Address2);
                parameters.Add("@City",  City);
                parameters.Add("@State",  State);
                parameters.Add("@Zip",  zip);
                parameters.Add("@CountryID",  Country);
                parameters.Add("@PrimaryPhone",  ContactNo);
                parameters.Add("@SecondaryPhone",  EmergencyContactNo);
                parameters.Add("@EmailId",  Email);
                parameters.Add("@UserName",  UserName);
                parameters.Add("@Qualification",  Qualification);
                parameters.Add("@StaffTypeID",  StaffType);
                parameters.Add("@UserTypeId",  UserType);
                parameters.Add("@CustomerTypeID",  CustomerTypeID);
                parameters.Add("@StaffTeamID",  StaffTeamID);
                parameters.Add("@StaffRate",  StaffRate);
                parameters.Add("@StaffPosition",  StaffPosition);
                parameters.Add("@Published",  1);
                parameters.Add("@CommissionRate",  CommissionRate);
                parameters.Add("@CommissionType",  CommissionType);
                parameters.Add("@CreatedBy",  Createdby);
                parameters.Add("@flag", flag);

            return DataLayer.Instance.ExecuteDataSetSP("SpStaffDetailsInsert", parameters.ToArray());
        }

        public DataSet Update(int StaffId, string title, int StaffType, int UserType, string Firstname, string middlename, string Lastname, string Address1, string Address2, string City, string State, string zip, int Country, string ContactNo, string EmergencyContactNo, string Email, string Qualification, string UserName, int CustomerTypeID, int StaffTeamID, string StaffPosition, string StaffRate, string CommissionRate, string CommissionType, int Createdby, int flag)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@UserId", StaffId);
            parameters.Add("@Title", title);
            parameters.Add("@FirstName", Firstname);
            parameters.Add("@MiddleName", middlename);
            parameters.Add("@LastName", Lastname);
            parameters.Add("@Address1", Address1);
            parameters.Add("@Address2", Address2);
            parameters.Add("@City", City);
            parameters.Add("@State", State);
            parameters.Add("@Zip", zip);
            parameters.Add("@CountryID", Country);
            parameters.Add("@PrimaryPhone", ContactNo);
            parameters.Add("@SecondaryPhone", EmergencyContactNo);
            parameters.Add("@EmailId", Email);
            parameters.Add("@UserName", UserName);
            parameters.Add("@Qualification", Qualification);
            parameters.Add("@StaffTypeID", StaffType);
            parameters.Add("@UserTypeId", UserType);
            parameters.Add("@CustomerTypeID", CustomerTypeID);
            parameters.Add("@StaffTeamID", StaffTeamID);
            parameters.Add("@StaffRate", StaffRate);
            parameters.Add("@StaffPosition", StaffPosition);
            parameters.Add("@Published", 1);
            parameters.Add("@CommissionRate", CommissionRate);
            parameters.Add("@CommissionType", CommissionType);
            parameters.Add("@CreatedBy", Createdby);
            parameters.Add("@flag", flag);

            return DataLayer.Instance.ExecuteDataSetSP("SpStaffDetailsInsert", parameters.ToArray());
        }

        public DataSet Select(int flag, int StaffId)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@cStaffId", StaffId);            
            parameters.Add("@flag", flag);

            return DataLayer.Instance.ExecuteDataSetSP("SpStaffDetailsSelect", parameters.ToArray());           
                
        }


        public DataSet SelectStaffType(int flag, int StaffTypeId)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@StaffTypeName", "");
            parameters.Add("@StaffTypeId", StaffTypeId);
            parameters.Add("@flag", flag);

            return DataLayer.Instance.ExecuteDataSetSP("SpStaffTypeSelect", parameters.ToArray());             
        }

        public DataSet SelectUserType(int flag, int UserTypeId)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@UserId", UserTypeId);            
            parameters.Add("@flag", flag);

            return DataLayer.Instance.ExecuteDataSetSP("SpUserTypeSelect", parameters.ToArray());             
        }

        public DataSet SelectStaffTeam(int flag, int StaffTeamId)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@StaffTeamId", StaffTeamId);            
            parameters.Add("@flag", flag);

            return DataLayer.Instance.ExecuteDataSetSP("SpStaffTeamSelect", parameters.ToArray()); 
        }

        public DataSet SelectCustomerType(int flag, int CustomerTypeId)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@CustomerTypeId", CustomerTypeId);            
            parameters.Add("@flag", flag);

            return DataLayer.Instance.ExecuteDataSetSP("SpCustomerTypeSelect", parameters.ToArray());             
        }

        public DataSet SelectCountry(int flag, int CountryId)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@CountryId", CountryId);            
            parameters.Add("@flag", flag);

            return DataLayer.Instance.ExecuteDataSetSP("SpCountrySelect", parameters.ToArray());             
        }
    }
}
