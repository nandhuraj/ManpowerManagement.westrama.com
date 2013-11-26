using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using ManpowerManageWeb;

namespace TestApps.DAL
{
    public class DataOpportunity :DataServiceBase
    {
        int iResult = int.MinValue;
        DataServiceBase ds = new DataServiceBase();

        public int Insert(int OpportunityId, string CompanyName, int Industry, int category, string requiredjobposition, int country, string passtype, string salary, string workinghours, string leavermonth, string requiredexperience, string accomodation, string overtime, string food, int flag)
        {
          
            iResult = ExecuteNonQuery("SpOpportunityInsert",

                CreateParameter("@OpportunityId", SqlDbType.Int, OpportunityId),
                CreateParameter("@CompanyName", SqlDbType.VarChar, CompanyName),
                CreateParameter("@Industry", SqlDbType.Int, Industry),
                CreateParameter("@category", SqlDbType.Int, category),
                CreateParameter("@requiredjobposition", SqlDbType.VarChar, requiredjobposition),
                CreateParameter("@country", SqlDbType.Int, country),
                CreateParameter("@passtype", SqlDbType.VarChar, passtype),
                CreateParameter("@salary", SqlDbType.VarChar, salary),
                CreateParameter("@workinghours", SqlDbType.VarChar, workinghours),
                CreateParameter("@leavermonth", SqlDbType.VarChar, leavermonth),
                CreateParameter("@requiredexperience", SqlDbType.VarChar, requiredexperience),
                CreateParameter("@accomodation", SqlDbType.Bit, Convert.ToBoolean(accomodation)),
                CreateParameter("@overtime", SqlDbType.Bit, Convert.ToBoolean(overtime)),
                CreateParameter("@food", SqlDbType.Bit, Convert.ToBoolean(food)),
                CreateParameter("@flag", SqlDbType.Int, flag));

            return iResult;
        }

        public int Update(int OpportunityId, string CompanyName, int Industry, int category, string requiredjobposition, int country, string passtype, string salary, string workinghours, string leavermonth, string requiredexperience, string accomodation, string overtime, string food, int flag)
        {
            iResult = ExecuteNonQuery("SpOpportunityInsert",

                CreateParameter("@OpportunityId", SqlDbType.Int, OpportunityId),
                CreateParameter("@CompanyName", SqlDbType.VarChar, CompanyName),
                CreateParameter("@Industry", SqlDbType.Int, Industry),
                CreateParameter("@category", SqlDbType.Int, category),
                CreateParameter("@requiredjobposition", SqlDbType.VarChar, requiredjobposition),
                CreateParameter("@country", SqlDbType.Int, country),
                CreateParameter("@passtype", SqlDbType.VarChar, passtype),
                CreateParameter("@salary", SqlDbType.VarChar, salary),
                CreateParameter("@workinghours", SqlDbType.VarChar, workinghours),
                CreateParameter("@leavermonth", SqlDbType.VarChar, leavermonth),
                CreateParameter("@requiredexperience", SqlDbType.VarChar, requiredexperience),
                CreateParameter("@accomodation", SqlDbType.Bit, Convert.ToBoolean(accomodation)),
                CreateParameter("@overtime", SqlDbType.Bit, Convert.ToBoolean(overtime)),
                CreateParameter("@food", SqlDbType.Bit, Convert.ToBoolean(food)),
                CreateParameter("@flag", SqlDbType.Int, flag));

            return iResult;
        }

        public DataTable Select(int flag, int OpportunityId)
        {
            return ExecuteDataTable("SpOpportunitySelect",
                CreateParameter("@flag", SqlDbType.Int, flag, ParameterDirection.Input),                
                CreateParameter("@OpportunityId", SqlDbType.Int, OpportunityId, ParameterDirection.Input));
        }

        public DataTable SelectIndustry(int flag, int IndustryTypeID)
        {
            return ExecuteDataTable("SpIndustrySelect",
               CreateParameter("@flag", SqlDbType.Int, flag, ParameterDirection.Input),
               CreateParameter("@IndustryTypeID", SqlDbType.Int, IndustryTypeID, ParameterDirection.Input));
        }

        public DataTable SelectCategory(int flag, int CategoryId)
        {
            return ExecuteDataTable("SpCategorySelect",
               CreateParameter("@flag", SqlDbType.Int, flag, ParameterDirection.Input),
               CreateParameter("@CategoryId", SqlDbType.Int, CategoryId, ParameterDirection.Input));
        }

        public DataTable SelectCountry(int flag, int CountryId)
        {
            return ExecuteDataTable("SpCountrySelect",
               CreateParameter("@flag", SqlDbType.Int, flag, ParameterDirection.Input),
               CreateParameter("@CountryId", SqlDbType.Int, CountryId, ParameterDirection.Input));
        }        
    }
}