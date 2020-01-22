using System;
using DataModels.Common;

namespace DataModels.Models
{
    public class ContractDetailsModel
    {
        public long ContractDetailID { get; set; }

        [LocalizedDisplayname1("ContractTerm")]
        public long ContractTermID { get; set; }

        [LocalizedDisplayname1("TermStartDate")]
        public DateTime TermStartDate { get; set; }

        [LocalizedDisplayname1("TermEndDate")]
        public DateTime TermEndDate { get; set; }

        [LocalizedDisplayname1("Notes")]
        public string ContractDetailNote { get; set; }

        public long ContractUserID { get; set; }

        public long ContractBrokerID { get; set; }
        
        public bool IsDelete { get; set; }
    }
}
