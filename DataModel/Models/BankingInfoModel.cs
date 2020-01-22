using System;
using System.ComponentModel.DataAnnotations;
using DataModels.Common;

namespace DataModels.Models
{
    public class BankingInfoModel
    {
        public int BankingInfoID { get; set; }

        public int? BankAccountTypeID { get; set; }

        public string BankName { get; set; }

        public string BankAddress { get; set; }

        public string AccountNumber { get; set; }

        public string BranchNumber { get; set; }

        public string InstitutionNumber { get; set; }

        public DateTime? EffectiveDate { get; set; }

        public DateTime? EndDate { get; set; }

        public bool ActiveInd { get; set; }

        public byte[] Version { get; set; }

        public string Description { get; set; }

        public DateTime? Createddate { get; set; }
        public int? CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
    }
}