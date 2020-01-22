using System;

namespace DataModels.Models
{
    public class BranchModel
    {
        public int BranchID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? ActiveInd { get; set; }
        public int? ParentBranchID { get; set; }
        public int? BranchLeaderID { get; set; }
        public int? TeamID { get; set; }
        public int? BrokerHouseRegionID { get; set; }
        public int? AddressID { get; set; }
        public string WebsiteUrl { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public byte[] Version { get; set; }
    }
}
