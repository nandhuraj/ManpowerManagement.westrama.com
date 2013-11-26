using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ManpowerManage.Data;
using System.Data;


namespace ManpowerManage.Model
{
    
    public class ClientModel
    {
        private string spUpdateClient = "spUpdateClient";
        private string spAddNewClient = "spClientAdd";
        private string spDeleteUser = "spDeleteClient";
        private string spSelectDropDownOrGrid = "spClientSelect";
        private string spClientname = "spClientname";


        // data access layer
        public DataSet DeleteClientDetails(int userId, string newPassword)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            return DataLayer.Instance.ExecuteDataSetSP(spAddNewClient, parameters.ToArray()); 
        }

      #region "Add client Function"
        public int AddClientDetails(string CompanyName, int UserTypeID, string GroupName, string Website
                                          ,string PrimaryPhone,string SecondaryPhone,string Fax,string Address,string City,
                                          string State, int CountryID, string Zip, int CustomerTypeID, int SupplierTypeID, int CompanySizeID,
                                          int CompanySourceID,string PrimaryContactPerson,string OfficialEmailID,int IndustryTypeID,
                                          int CreatedBy, int IsActive,string Remarks)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@CompanyName", CompanyName);
            parameters.Add("@UserTypeID", UserTypeID);
            parameters.Add("@GroupName", GroupName);
            parameters.Add("@Website", Website);
            parameters.Add("@PrimaryPhone", PrimaryPhone);
            parameters.Add("@SecondaryPhone", SecondaryPhone);
            parameters.Add("@Fax", Fax);
            parameters.Add("@Address1", Address);
            parameters.Add("@City", City);
            parameters.Add("@State", State);
            parameters.Add("@CountryID", CountryID);
            parameters.Add("@Zip", Zip);
            parameters.Add("@CustomerTypeID", CustomerTypeID);
            parameters.Add("@SupplierTypeID", SupplierTypeID);
            parameters.Add("@CompanySizeID", CompanySizeID);
            parameters.Add("@CompanySourceID", CompanySourceID);
            parameters.Add("@PrimaryContactPerson", PrimaryContactPerson);
            parameters.Add("@OfficialEmailID", OfficialEmailID);
            parameters.Add("@IndustryTypeID", IndustryTypeID);
            parameters.Add("@CreatedBy", CreatedBy);
            parameters.Add("@IsActive", IsActive);
            parameters.Add("@Remarks", Remarks);
            return DataLayer.Instance.ExecuteNonQuerySP(spAddNewClient, parameters.ToArray());       
        }
       #endregion

        public DataSet UpdateClientDetails(int CompanyID, string CompanyName, int UserTypeID, string GroupName, string Website
                                          ,string PrimaryPhone,string SecondaryPhone,string Fax,string Address,string City,
                                          string State, int CountryID, string Zip, int CustomerTypeID, int SupplierTypeID, int CompanySizeID,
                                          int CompanySourceID,string PrimaryContactPerson,string OfficialEmailID,int IndustryTypeID,
                                          int ModifiedBy, int IsActive, string Remarks,string flagAdminOrStaff)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@CompanyID", CompanyID);
            parameters.Add("@CompanyName", CompanyName);
            parameters.Add("@UserTypeID", UserTypeID);
            parameters.Add("@GroupName", GroupName);
            parameters.Add("@Website", Website);
            parameters.Add("@PrimaryPhone", PrimaryPhone);
            parameters.Add("@SecondaryPhone", SecondaryPhone);
            parameters.Add("@Fax", Fax);
            parameters.Add("@Address1", Address);
            parameters.Add("@City", City);
            parameters.Add("@State", State);
            parameters.Add("@CountryID", CountryID);
            parameters.Add("@Zip", Zip);
            parameters.Add("@CustomerTypeID", CustomerTypeID);
            parameters.Add("@SupplierTypeID", SupplierTypeID);
            parameters.Add("@CompanySizeID", CompanySizeID);
            parameters.Add("@CompanySourceID", CompanySourceID);
            parameters.Add("@PrimaryContactPerson", PrimaryContactPerson);
            parameters.Add("@OfficialEmailID", OfficialEmailID);
            parameters.Add("@IndustryTypeID", IndustryTypeID);
            parameters.Add("@ModifiedBy", ModifiedBy);
            parameters.Add("@IsActive", IsActive);
            parameters.Add("@Remarks", Remarks);
            parameters.Add("@AdminOrStaff", flagAdminOrStaff);
            return DataLayer.Instance.ExecuteDataSetSP(spUpdateClient, parameters.ToArray()); 
        }

        // Get Client for updation Window or Search through Textbox by Copany Name
        public DataSet GetClientDetails(int cmpId, string CompyName, string AdmOrStaff, string SELECTflag, int stfId)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@CompanyId",  cmpId);
            parameters.Add("@companyName", CompyName);
            parameters.Add("@SELECT", SELECTflag);
            parameters.Add("@AdminOrStaff",AdmOrStaff );
            parameters.Add("@StaffId", stfId);
           // parameters.Add("@FlagGridToUpdateForm", flagCode);
            return DataLayer.Instance.ExecuteDataSetSP(spSelectDropDownOrGrid, parameters.ToArray());
           
        }

        public DataSet GetClientNameDetails(string CompyName)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@CompanyName", CompyName);
            return DataLayer.Instance.ExecuteDataSetSP(spClientname, parameters.ToArray());
        }
        
    }

     
}
