using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TestApps.DAL;

namespace TestApps.BAL
{
    public class BusinessOpportunity
    {
        DataOpportunity objstaff = new DataOpportunity();

        public int Insert(int OpportunityId, string CompanyName, int Industry, int category, string requiredjobposition, int country, string passtype, string salary, string workinghours, string leavermonth, string requiredexperience, string accomodation, string overtime, string food, int flag)
        {
            return objstaff.Insert(OpportunityId, CompanyName, Industry, category, requiredjobposition, country, passtype, salary, workinghours, leavermonth, requiredexperience, accomodation, overtime, food, flag);
        }

        public int Update(int OpportunityId, string CompanyName, int Industry, int category, string requiredjobposition, int country, string passtype, string salary, string workinghours, string leavermonth, string requiredexperience, string accomodation, string overtime, string food, int flag)
        {
            return objstaff.Update(OpportunityId, CompanyName, Industry, category, requiredjobposition, country, passtype, salary, workinghours, leavermonth, requiredexperience, accomodation, overtime, food, flag);
        }

        public DataTable Select(int flag, int OpportunityId)
        {
            return objstaff.Select(flag, OpportunityId);
        }

        public DataTable SelectIndustry(int flag, int IndustryTypeID)
        {
            return objstaff.SelectIndustry(flag, IndustryTypeID);
        }

        public DataTable SelectCategory(int flag, int CategoryId)
        {
            return objstaff.SelectCategory(flag, CategoryId);
        }

        public DataTable SelectCountry(int flag, int CountryId)
        {
            return objstaff.SelectCountry(flag, CountryId);
        }        
    }
}