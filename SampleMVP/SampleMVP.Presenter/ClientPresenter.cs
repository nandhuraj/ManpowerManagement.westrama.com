using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ManpowerManage.View;
using ManpowerManage.Model;
using System.Data;

namespace ManpowerManage.Presenter
{
    public class ClientPresenter
    {

        private IClient iClientEntry;
        private ClientModel clientModel;
        private int cmpId=0;
        private string CompyName="";
        private string AdmOrStaff = "";
        private string SELECTflag = "";
        private int stfId = 0;
       
        public ClientPresenter(IClient Clientview)
        {
            iClientEntry = Clientview;
        }
        public ClientPresenter(int CompId,string CompName,string adminOrStaff,string SELECT,int StaffId)
        {
            cmpId = CompId;
            CompyName = CompName;
            AdmOrStaff = adminOrStaff;
            SELECTflag = SELECT;
            stfId = StaffId;
        }

        public int SaveNewClient()
        {
            try
            {
                clientModel = new ClientModel();
                return clientModel.AddClientDetails(iClientEntry.CompanyName, iClientEntry.UserTypeID, iClientEntry.GroupName, iClientEntry.Website
                                              , iClientEntry.PrimaryPhone, iClientEntry.SecondaryPhone, iClientEntry.Fax, iClientEntry.Address, iClientEntry.City,
                                              iClientEntry.State, iClientEntry.CountryID, iClientEntry.Zip, iClientEntry.CustomerTypeID, iClientEntry.SupplierTypeID, iClientEntry.CompanySizeID,
                                              iClientEntry.CompanySourceID, iClientEntry.PrimaryContactPerson, iClientEntry.OfficialEmailID, iClientEntry.IndustryTypeID,
                                              iClientEntry.CreatedBy, iClientEntry.IsActive, iClientEntry.Remarks);
            }
            catch (Exception ex)
            {
                throw ex;
            }
               
        }

        public DataSet UpdateClient()
        {
            using (DataSet ds = new DataSet())
            {
                clientModel = new ClientModel();
                return clientModel.UpdateClientDetails(iClientEntry.CompanyID, iClientEntry.CompanyName, iClientEntry.UserTypeID, iClientEntry.GroupName, iClientEntry.Website
                                              , iClientEntry.PrimaryPhone, iClientEntry.SecondaryPhone, iClientEntry.Fax, iClientEntry.Address, iClientEntry.City,
                                              iClientEntry.State, iClientEntry.CountryID, iClientEntry.Zip, iClientEntry.CustomerTypeID, iClientEntry.SupplierTypeID, iClientEntry.CompanySizeID,
                                              iClientEntry.CompanySourceID, iClientEntry.PrimaryContactPerson, iClientEntry.OfficialEmailID, iClientEntry.IndustryTypeID,
                                              iClientEntry.ModifiedBy, iClientEntry.IsActive, iClientEntry.Remarks,iClientEntry.Usertypes);
            }
        }

        public DataSet GetClientDetails()
        {
            using (DataSet ds = new DataSet())
            {
                DataSet ds1 = new DataSet();
                clientModel = new ClientModel();
                ds1 = clientModel.GetClientDetails(cmpId, CompyName, AdmOrStaff, SELECTflag, stfId);
                return ds1;
            }

        }

        public DataSet GetClientNameDetails()
        {
            using (DataSet ds = new DataSet())
            {
                DataSet ds1 = new DataSet();
                clientModel = new ClientModel();
                ds1 = clientModel.GetClientNameDetails(CompyName);
                return ds1;
            }

        }
       
    }
}
