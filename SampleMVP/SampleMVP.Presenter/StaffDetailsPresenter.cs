using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ManpowerManage.Model;
using ManpowerManage.View;
using System.Data;

namespace ManpowerManage.Presenter
{
    public class StaffDetailsPresenter
    {
        private IStaffDetails iStaffDetailsEntry;
        private StaffDetailsModel StaffDetailsModel;

        public StaffDetailsPresenter(IStaffDetails iStaffDetails)
        {
            iStaffDetailsEntry = iStaffDetails;
        }

        public DataSet Insert()
        {
            using (DataSet ds = new DataSet())
            {
                StaffDetailsModel = new StaffDetailsModel();
                return StaffDetailsModel.Insert(iStaffDetailsEntry.StaffId, iStaffDetailsEntry.title, iStaffDetailsEntry.StaffType, iStaffDetailsEntry.UserType
                                              , iStaffDetailsEntry.Firstname, iStaffDetailsEntry.middlename, iStaffDetailsEntry.Lastname, iStaffDetailsEntry.Address1, 
                                              iStaffDetailsEntry.Address2, iStaffDetailsEntry.City, iStaffDetailsEntry.State, iStaffDetailsEntry.zip, iStaffDetailsEntry.Country, iStaffDetailsEntry.ContactNo,
                                              iStaffDetailsEntry.EmergencyContactNo, iStaffDetailsEntry.Email, iStaffDetailsEntry.Qualification, iStaffDetailsEntry.UserName,
                                              iStaffDetailsEntry.CustomerTypeID, iStaffDetailsEntry.StaffTeamID, iStaffDetailsEntry.StaffPosition, iStaffDetailsEntry.StaffRate, iStaffDetailsEntry.CommissionRate, iStaffDetailsEntry.CommissionType,
                                              iStaffDetailsEntry.CreatedBy, iStaffDetailsEntry.flag);
            }            
        }

        public DataSet Update()
        {
            using (DataSet ds = new DataSet())
            {
                StaffDetailsModel = new StaffDetailsModel();
                return StaffDetailsModel.Update(iStaffDetailsEntry.StaffId, iStaffDetailsEntry.title, iStaffDetailsEntry.StaffType, iStaffDetailsEntry.UserType
                                              , iStaffDetailsEntry.Firstname, iStaffDetailsEntry.middlename, iStaffDetailsEntry.Lastname, iStaffDetailsEntry.Address1, iStaffDetailsEntry.Address2,
                                              iStaffDetailsEntry.City, iStaffDetailsEntry.State, iStaffDetailsEntry.zip, iStaffDetailsEntry.Country, iStaffDetailsEntry.ContactNo,
                                              iStaffDetailsEntry.EmergencyContactNo, iStaffDetailsEntry.Email, iStaffDetailsEntry.Qualification, iStaffDetailsEntry.UserName,
                                              iStaffDetailsEntry.CustomerTypeID, iStaffDetailsEntry.StaffTeamID, iStaffDetailsEntry.StaffPosition,iStaffDetailsEntry.StaffRate, iStaffDetailsEntry.CommissionRate,iStaffDetailsEntry.CommissionType,
                                              iStaffDetailsEntry.CreatedBy, iStaffDetailsEntry.flag);
            }            
        }

        public DataSet Select()
        {
            using (DataSet ds = new DataSet())
            {
                StaffDetailsModel = new StaffDetailsModel();
                return StaffDetailsModel.Select(iStaffDetailsEntry.flag, iStaffDetailsEntry.StaffId);
            }            
        }

        public DataSet SelectStaffType()
        {
            using (DataSet ds = new DataSet())
            {
                StaffDetailsModel = new StaffDetailsModel();
                return StaffDetailsModel.SelectStaffType(iStaffDetailsEntry.flag, iStaffDetailsEntry.StaffType);
            }            
        }

        public DataSet SelectUserType()
        {
            using (DataSet ds = new DataSet())
            {
                StaffDetailsModel = new StaffDetailsModel();
                return StaffDetailsModel.SelectUserType(iStaffDetailsEntry.flag, iStaffDetailsEntry.UserType);
            }
        }

        public DataSet SelectStaffTeam()
        {
            using (DataSet ds = new DataSet())
            {
                StaffDetailsModel = new StaffDetailsModel();
                return StaffDetailsModel.SelectStaffTeam(iStaffDetailsEntry.flag, iStaffDetailsEntry.StaffTeamID);
            }
        }

        public DataSet SelectCustomerType()
        {
            using (DataSet ds = new DataSet())
            {
                StaffDetailsModel = new StaffDetailsModel();
                return StaffDetailsModel.SelectCustomerType(iStaffDetailsEntry.flag, iStaffDetailsEntry.CustomerTypeID);
            }
        }
        public DataSet SelectCountry()
        {
            using (DataSet ds = new DataSet())
            {
                StaffDetailsModel = new StaffDetailsModel();
                return StaffDetailsModel.SelectCountry(iStaffDetailsEntry.flag, iStaffDetailsEntry.Country);
            }            
        }
    }
}
