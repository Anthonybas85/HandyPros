using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataModels.Models.Reports
{
    public class BrokerT4APlannerInfoReportModel
    {
        public long? id1 { get; set; }
        public string paycode { get; set; }
        public string Name { get; set; }
        public string t4AStatus { get; set; }
        public string T4StartDate { get; set; }
        public string T4EndDate { get; set; }
        public string CompanyName { get; set; }
        public string Street1 { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string SINNo { get; set; }
        public string DOB { get; set; }
        public string BrokerEndtDt { get; set; }
        public string BrokerStartDt { get; set; }
        public string TerminationDate { get; set; }
        public string branchName { get; set; }
        public string INCORPORATEDATE { get; set; }
        public string ProfileType { get; set; }
        public string Email { get; set; }
        public string TeamName { get; set; }
        public string brokerStatus { get; set; }
        public string TeamTypeName { get; set; }
    }
}
