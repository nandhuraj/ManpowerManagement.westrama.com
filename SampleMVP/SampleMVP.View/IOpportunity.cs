using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManpowerManage.View
{
    public interface IOpportunity
    {
         int OpportunityId { get; set; }
         string CompanyName { get; set; }
         int Industry { get; set; }
         int category { get; set; }
         int requiredjobposition { get; set; }
         int CountryID { get; set; }
         string salary { get; set; }
         int workinghours { get; set; }
         int leavermonth { get; set; }
         int requiredexperience { get; set; }
         string accomodation { get; set; }
         string overtime { get; set; }
         string food { get; set; }
         int CreatedBy { get; set; }            
         int flag { get; set; }
         int passtype { get; set; }
         int CompanyInsert { get; set; }
         int CompanyID { get; set; }
         int UserTypeID { get; set; }         
    }
}
