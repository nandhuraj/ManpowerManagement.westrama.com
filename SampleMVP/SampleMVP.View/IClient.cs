using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManpowerManage.View
{
    public interface IClient
    {
         int CompanyID { get; set; }
         string CompanyName { get; set; }
         int UserTypeID { get; set; }
         string GroupName { get; set; }
         string Website { get; set; }
         string PrimaryPhone { get; set; }
         string SecondaryPhone { get; set; }
         string Fax { get; set; }
         string Address { get; set; }
         string Address2 { get; set; }
         string City { get; set; }
         string State { get; set; }
         string Zip { get; set; }
         int CountryID { get; set; }
         int CustomerTypeID { get; set; }
         int SupplierTypeID { get; set; }
         int CompanySizeID { get; set; }
         int CompanySourceID { get; set; }
         string PrimaryContactPerson { get; set; }
         string OfficialEmailID { get; set; }
         int IndustryTypeID { get; set; }
         int CreatedBy { get; set; }
         DateTime CreationTime { get; set; }
         int ModifiedBy { get; set; }
         DateTime ModifiedTime { get; set; }
         int IsActive { get; set; }
         string Remarks { get; set; }
         string FLAG { get; set; }
         string COMPNAME { get; set; }
         string Usertypes { get; set; }
    }
}
