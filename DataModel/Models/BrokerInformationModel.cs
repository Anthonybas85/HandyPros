using System;

namespace DataModels.Models
{
    public class BrokerInformationModel
    {
        public int brokerid { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public DateTime? DOB { get; set; }
        public string SIN { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? brokerstatusid { get; set; }
        public string BrokerStatus { get; set; }
        public string notes { get; set; }
        public int? languageid { get; set; }
        public string language { get; set; }
        public int? salutationid { get; set; }
        public string salutation { get; set; }
        public int? genderid { get; set; }
        public string gender { get; set; }
        public int? websiteind { get; set; }
        public string websiteurl { get; set; }
        public string preferredname { get; set; }
        public int? timezoneid { get; set; }
        public string timezone { get; set; }
        public byte[] version { get; set; }
    }
}
