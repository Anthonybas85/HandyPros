using System;

namespace DataModels.Models
{
    public class BrokerHouseRegionModel
    {
        public int BrokerHouseRegionId { get; set; }
        public int? BrokerHouseId { get; set; }
        public int? RegionId { get; set; }
        public string BrokerHouseName { get; set; }
        public string RegionName { get; set; }
        public int? RVP { get; set; }
        public int? ActiveInd { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
