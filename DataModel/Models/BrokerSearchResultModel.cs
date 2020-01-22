using System;

namespace DataModels.Models
{
    public class BrokerSearchResultModel
    {
        public int brokerid { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string Cell { get; set; }
        public string OfficePhone { get; set; }
        public string OfficePhoneExt { get; set; }
        public string Email { get; set; }
        public DateTime? startdate { get; set; }
        public DateTime? enddate { get; set; }
        public int? brokerstatusid { get; set; }
        public string statusName { get; set; }
    }
}
