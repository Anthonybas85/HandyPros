using DataModels.Common;

namespace DataModels.Models.Reports
{
    public class SubmittingAgentsReport2
    {
        //[LocalizedDisplayname("Team")]
        public int? TeamID { get; set; }

        //[LocalizedDisplayname("Broker")]
        public int? BrokerID { get; set; }

        //[LocalizedDisplayname("Branch")]
        public int? BranchID { get; set; }

        //[LocalizedDisplayname("BrokerName")]
        public string BrokerName { get; set; }
    }
}