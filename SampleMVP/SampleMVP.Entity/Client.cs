using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManpowerManage.Entity
{
    public class Client
    {

      public int  CompanyID { get ;set;}
      public string CompanyName{get;set;}
      public int UserTypeID{get;set;}
      public string GroupName{get;set;}
      public string Website{get;set;}
      public string PrimaryPhone{get;set;}
      public string SecondaryPhone{get;set;}
      public string Fax{get;set;}
      public string Address{get;set;}
      public string Address2{get;set;}
      public string City{get;set;}
      public string State{get;set;}
      public string Zip{get;set;}
      public int CountryID{get;set;}
      public int CustomerTypeID { get; set; }
      public int SupplierTypeID{get;set;}
      public int CompanySizeID{get;set;}
      public int  CompanySourceID{get;set;}
      public int  PrimaryContactPerson{get;set;}
      public int  OfficialEmailID{get;set;}
      public int IndustryTypeID{get;set;}
      public int CreatedBy{get;set;}
      public DateTime CreationTime{get;set;}
      public int ModifiedBy{get;set;}
      public DateTime  ModifiedTime{get;set;}
      public bool IsActive{get;set;}
      public string Remarks{get;set;}
 
    }
}
