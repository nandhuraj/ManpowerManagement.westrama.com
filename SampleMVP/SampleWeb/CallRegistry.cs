using System;

namespace ManpowerManageWeb
{
    public class CallRegistry
    {
        public DateTime CallDateTime { get; set; }

        public int Industry { get; set; }

        public string CompanyName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string AlternatePhone { get; set; }

        public int Reference { get; set; }

        public int MarketingCategory { get; set; }

        public int MarketingStatus { get; set; }

        public string Reminder { get; set; }

        public string Activity { get; set; }

        public int SendProfile { get; set; }

        public int NoOfCandidate { get; set; }

        public int Opportunity { get; set; }

        public int CallID { get; set; }

        public int StaffID { get; set; }

        public string FEmail { get; set; }
    }
}