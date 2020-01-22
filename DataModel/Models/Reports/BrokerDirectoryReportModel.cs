using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataModels.Models.Reports
{
    public class BrokerDirectoryReportModel
    {
        public string lastname { get; set; }
        public string firstname { get; set; }
        public string team { get; set; }
        public string email { get; set; }
        public string brokerstatus { get; set; }
        public string City { get; set; }
        public string province { get; set; }
        public string Street { get; set; }
        public string postalcode { get; set; }
        public string ServiceAreas { get; set; }
        public string officephone { get; set; }
        public string faxnumber { get; set; }
        public string officephone2 { get; set; }
        public string cell { get; set; }
        public string officephoneext { get; set; }
        public string profiletype { get; set; }
    }
}
