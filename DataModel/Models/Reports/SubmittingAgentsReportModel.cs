using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataModels.Models.Reports
{
    public class SubmittingAgentsReportModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TeamName { get; set; }
        public string BrokerName { get; set; }
        public string BranchName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}
