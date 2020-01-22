using System;

namespace DataModels.Models
{
    public class BranchInformationModel
    {
        public int BrokerBranchXrefId { get; set; }
        public int? brokerhouseId { get; set; }
        public string BrokerHouseName { get; set; }
        public int? regionid { get; set; }
        public string regionName { get; set; }
        public int? BranchId { get; set; }
        public string BranchName { get; set; }
        public int? teamId { get; set; }
        public string TeamName { get; set; }
        public int? TeamLeaderId { get; set; }
        public string TeamLeaderName { get; set; }
        public int? BranchLeaderId { get; set; }
        public string BranchLeaderName { get; set; }
        public DateTime? effectivedate { get; set; }
        public DateTime? enddate { get; set; }
        public int? activeind { get; set; }
        public int? BrokerRoleTypeId { get; set; }
        public string BrokerRoleTypeName { get; set; }
    }
}
