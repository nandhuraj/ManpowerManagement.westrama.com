using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManpowerManage.View
{
    public interface IStaffDetails
    {
         int StaffId { get; set; }
         string title { get; set; }
         int StaffType { get; set; }
         int UserType { get; set; }
         string Firstname { get; set; }
         string middlename { get; set; }
         string Lastname { get; set; }
         string UserName { get; set; }
         string Address1 { get; set; }
         string Address2 { get; set; }
         string City { get; set; }
         string State { get; set; }
         string zip { get; set; }
         int Country { get; set; }
         string ContactNo { get; set; }
         string EmergencyContactNo { get; set; }
         string Email { get; set; }
         string Qualification { get; set; }
         int StaffTeamID { get; set; }
         int CustomerTypeID { get; set; }
         string StaffPosition { get; set; }
         string StaffRate { get; set; }
         string CommissionRate { get; set; }
         string CommissionType { get; set; }
         int CreatedBy { get; set; }         
         int flag { get; set; }
    }
}
