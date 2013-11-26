using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ManpowerManage.View;
using ManpowerManage.Model;

namespace ManpowerManage.Presenter
{
    public class OpportunityPresenter
    {
        private IOpportunity iopportunityEntry;
        private OpportunityModel opportunityModel;

        public OpportunityPresenter(IOpportunity opportunityview)
        {
            iopportunityEntry = opportunityview;
        }

        public DataSet Insert()
        {
            using (DataSet ds = new DataSet())
            {
                opportunityModel = new OpportunityModel();
                return opportunityModel.Insert(iopportunityEntry.OpportunityId, iopportunityEntry.CompanyName, iopportunityEntry.Industry, iopportunityEntry.category
                                              , iopportunityEntry.requiredjobposition, iopportunityEntry.CountryID, iopportunityEntry.passtype, iopportunityEntry.salary, iopportunityEntry.workinghours,
                                              iopportunityEntry.leavermonth, iopportunityEntry.requiredexperience, iopportunityEntry.accomodation, iopportunityEntry.overtime, iopportunityEntry.food, iopportunityEntry.flag, iopportunityEntry.CompanyInsert, iopportunityEntry.CompanyID, iopportunityEntry.UserTypeID, iopportunityEntry.CreatedBy);
            }
        }

        public DataSet Update()
        {
            using (DataSet ds = new DataSet())
            {
                opportunityModel = new OpportunityModel();
                return opportunityModel.Update(iopportunityEntry.OpportunityId, iopportunityEntry.CompanyName, iopportunityEntry.Industry, iopportunityEntry.category
                                              , iopportunityEntry.requiredjobposition, iopportunityEntry.CountryID, iopportunityEntry.passtype, iopportunityEntry.salary, iopportunityEntry.workinghours,
                                              iopportunityEntry.leavermonth, iopportunityEntry.requiredexperience, iopportunityEntry.accomodation, iopportunityEntry.overtime, iopportunityEntry.food, iopportunityEntry.flag, iopportunityEntry.CompanyInsert, iopportunityEntry.CompanyID, iopportunityEntry.UserTypeID,iopportunityEntry.CreatedBy);
            }            
        }

        public DataSet Select()
        {
            using (DataSet ds = new DataSet())
            {
                opportunityModel = new OpportunityModel();
                return opportunityModel.Select(iopportunityEntry.flag, iopportunityEntry.OpportunityId);
            }            
        }

        public DataSet SelectIndustry()
        {
            using (DataSet ds = new DataSet())
            {
                opportunityModel = new OpportunityModel();
                return opportunityModel.SelectIndustry(iopportunityEntry.flag, iopportunityEntry.Industry);
            }            
        }

        public DataSet SelectCompany()
        {
            using (DataSet ds = new DataSet())
            {
                opportunityModel = new OpportunityModel();
                return opportunityModel.SelectCompany(iopportunityEntry.flag);
            }            
        }

        public DataSet SelectCategory()
        {
            using (DataSet ds = new DataSet())
            {
                opportunityModel = new OpportunityModel();
                return opportunityModel.SelectCategory(iopportunityEntry.flag, iopportunityEntry.category);
            }            
        }

        public DataSet SelectCountry()
        {
            using (DataSet ds = new DataSet())
            {
                opportunityModel = new OpportunityModel();
                return opportunityModel.SelectCountry(iopportunityEntry.flag, iopportunityEntry.CountryID);
            }
        }

        public DataSet SelectExperience()
        {
            using (DataSet ds = new DataSet())
            {
                opportunityModel = new OpportunityModel();
                return opportunityModel.SelectExperience(iopportunityEntry.flag);
            }
        }

        public DataSet SelectHours()
        {
            using (DataSet ds = new DataSet())
            {
                opportunityModel = new OpportunityModel();
                return opportunityModel.SelectHours(iopportunityEntry.flag);
            }
        }

        public DataSet SelectLeavemonth()
        {
            using (DataSet ds = new DataSet())
            {
                opportunityModel = new OpportunityModel();
                return opportunityModel.SelectLeavemonth(iopportunityEntry.flag);
            }
        }

        public DataSet SelectPassType()
        {
            using (DataSet ds = new DataSet())
            {
                opportunityModel = new OpportunityModel();
                return opportunityModel.SelectPassType(iopportunityEntry.flag);
            }
        }

        public DataSet SelectJobPosition()
        {
            using (DataSet ds = new DataSet())
            {
                opportunityModel = new OpportunityModel();
                return opportunityModel.SelectJobPosition(iopportunityEntry.flag);
            }
        }        
    }
}
