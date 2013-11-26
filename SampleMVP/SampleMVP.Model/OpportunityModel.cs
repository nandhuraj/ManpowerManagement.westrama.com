using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ManpowerManage.Data;

namespace ManpowerManage.Model
{
    public class OpportunityModel
    {
        public DataSet Insert(int OpportunityId, string CompanyName, int Industry, int category, int requiredjobposition, int country, int passtype, string salary, int workinghours, int leavermonth, int requiredexperience, string accomodation, string overtime, string food, int flag, int companyInsert, int companyId, int userTypeId, int createdby)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();              

                parameters.Add("@OpportunityId",  OpportunityId);
                parameters.Add("@CompanyName",  CompanyName);
                parameters.Add("@Industry",  Industry);
                parameters.Add("@category",  category);
                parameters.Add("@requiredjobposition",  requiredjobposition);
                parameters.Add("@country",  country);
                parameters.Add("@passtype",  passtype);
                parameters.Add("@salary",  salary);
                parameters.Add("@workinghours",  workinghours);
                parameters.Add("@leavermonth",  leavermonth);
                parameters.Add("@requiredexperience",  requiredexperience);
                parameters.Add("@accomodation",  Convert.ToBoolean(accomodation));
                parameters.Add("@overtime",  Convert.ToBoolean(overtime));
                parameters.Add("@food",  Convert.ToBoolean(food));
                parameters.Add("@flag", flag);
                parameters.Add("@CompanyInsert", companyInsert);
                parameters.Add("@companyId", companyId);
                parameters.Add("@UserTypeId", userTypeId);
                parameters.Add("@CreatedBy", createdby);

            return DataLayer.Instance.ExecuteDataSetSP("SpOpportunityInsert", parameters.ToArray());
        }

        public DataSet Update(int OpportunityId, string CompanyName, int Industry, int category, int requiredjobposition, int country, int passtype, string salary, int workinghours, int leavermonth, int requiredexperience, string accomodation, string overtime, string food, int flag, int companyInsert, int companyId, int userTypeId, int createdby)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@OpportunityId", OpportunityId);
            parameters.Add("@CompanyName", CompanyName);
            parameters.Add("@Industry", Industry);
            parameters.Add("@category", category);
            parameters.Add("@requiredjobposition", requiredjobposition);
            parameters.Add("@country", country);
            parameters.Add("@passtype", passtype);
            parameters.Add("@salary", salary);
            parameters.Add("@workinghours", workinghours);
            parameters.Add("@leavermonth", leavermonth);
            parameters.Add("@requiredexperience", requiredexperience);
            parameters.Add("@accomodation", Convert.ToBoolean(accomodation));
            parameters.Add("@overtime", Convert.ToBoolean(overtime));
            parameters.Add("@food", Convert.ToBoolean(food));
            parameters.Add("@flag", flag);
            parameters.Add("@CompanyInsert", companyInsert);
            parameters.Add("@companyId", companyId);
            parameters.Add("@UserTypeId", userTypeId);
            parameters.Add("@CreatedBy", createdby);

            return DataLayer.Instance.ExecuteDataSetSP("SpOpportunityInsert", parameters.ToArray());            
        }

        public DataSet Select(int flag, int OpportunityId)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@OpportunityId", OpportunityId);
            parameters.Add("@flag", flag);

            return DataLayer.Instance.ExecuteDataSetSP("SpOpportunitySelect", parameters.ToArray());            
        }

        public DataSet SelectIndustry(int flag, int IndustryTypeID)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@IndustryTypeID", IndustryTypeID);
            parameters.Add("@flag", flag);

            return DataLayer.Instance.ExecuteDataSetSP("SpIndustrySelect", parameters.ToArray());            
        }

        public DataSet SelectCategory(int flag, int CategoryId)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@CategoryId", CategoryId);
            parameters.Add("@flag", flag);

            return DataLayer.Instance.ExecuteDataSetSP("SpCategorySelect", parameters.ToArray());            
        }

        public DataSet SelectCompany(int flag)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@flag", flag);
            return DataLayer.Instance.ExecuteDataSetSP("SpCompanySelect", parameters.ToArray());
        }

        public DataSet SelectExperience(int flag)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@flag", flag);
            return DataLayer.Instance.ExecuteDataSetSP("SpExperienceSelect", parameters.ToArray());
        }

        public DataSet SelectHours(int flag)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@flag", flag);
            return DataLayer.Instance.ExecuteDataSetSP("SpHoursSelect", parameters.ToArray());
        }

        public DataSet SelectCountry(int flag, int CountryId)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@CountryId", CountryId);
            parameters.Add("@flag", flag);

            return DataLayer.Instance.ExecuteDataSetSP("SpCountrySelect", parameters.ToArray());
        }

        public DataSet SelectLeavemonth(int flag)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@flag", flag);
            return DataLayer.Instance.ExecuteDataSetSP("SpLeavemonthSelect", parameters.ToArray());
        }

        public DataSet SelectPassType(int flag)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@flag", flag);
            return DataLayer.Instance.ExecuteDataSetSP("SpPassTypeSelect", parameters.ToArray());
        }

        public DataSet SelectJobPosition(int flag)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@flag", flag);
            return DataLayer.Instance.ExecuteDataSetSP("SpJobPositionSelect", parameters.ToArray());
        }        
    }
}
