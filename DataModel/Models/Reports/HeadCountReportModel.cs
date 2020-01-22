using System;

namespace DataModels.Models.Reports
{
    public class HeadCountReportModel
    {
        public string lastName { get; set; }
        public string firstname { get; set; }
        public string Email { get; set; }
        public string EmailPersonal { get; set; }
        public string brokerhouse { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string RegionName { get; set; }
        public string profiletype { get; set; }
        public string team { get; set; }
        public DateTime? TeamEffectiveDate { get; set; }
        public string ServiceLevel { get; set; }
        public string BrokerStatus { get; set; }
        public string status { get; set; }
    }
}