using System;

namespace DataModels.Models
{
    public class BrokerModel
    {
        public int brokerid { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string status { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Email { get; set; }
        public string BizPhone { get; set; }
        public int? brokerstatusid { get; set; }
        public int? userid { get; set; }
    }
}
