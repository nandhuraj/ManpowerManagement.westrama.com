using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManpowerManage.Entity
{
    class StaffDetails
    {
        public int StaffId { get; set; }
        public string title { get; set; }
        public int StaffType { get; set; }
        public int UserType { get; set; }
        public string Firstname { get; set; }
        public string middlename { get; set; }
        public string Lastname { get; set; }
        public string UserName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string zip { get; set; }
        public int Country { get; set; }
        public string ContactNo { get; set; }
        public string EmergencyContactNo { get; set; }
        public string Email { get; set; }
        public string Qualification { get; set; }
        public int StaffTeamID { get; set; }
        public int CustomerTypeID { get; set; }
        public string StaffPosition { get; set; }
        public string StaffRate { get; set; }
        public string CommissionRate { get; set; }
        public string CommissionType { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreationTime { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedTime { get; set; }        
        public int flag { get; set; }
    }
}
