using System;

namespace DataModels.Models
{
    public class TeamTypeModel
    {
        public int TeamTypeTeamXrefID { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? ActiveInd { get; set; }
        public string Name { get; set; }
        public string teamtypename { get; set; }
        public Int64? BrokerSplitAmount { get; set; }
    }
}
