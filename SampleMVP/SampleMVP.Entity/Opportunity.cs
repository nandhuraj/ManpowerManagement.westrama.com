using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManpowerManage.Entity
{
    class Opportunity
    {
        
        public int OpportunityId { get; set; }
        public string CompanyName { get; set; }
        public int Industry { get; set; }
        public int category { get; set; }
        public int requiredjobposition { get; set; }
        public int CountryID { get; set; }
        public string salary { get; set; }
        public int workinghours { get; set; }
        public int leavermonth { get; set; }
        public int requiredexperience { get; set; }
        public string accomodation { get; set; }
        public string overtime { get; set; }
        public string food { get; set; }        
        public int CreatedBy { get; set; }
        public int passtype { get; set; } 
        public int flag { get; set; }
        public int CompanyInsert { get; set; }
        public int CompanyID { get; set; }
        public int UserTypeID { get; set; }        
    }
}
