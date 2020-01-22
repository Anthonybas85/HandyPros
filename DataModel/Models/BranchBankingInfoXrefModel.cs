namespace DataModels.Models
{
    public class BranchBankingInfoXrefModel
    {
        public int BranchBankingInfoXrefID { get; set; }

        public int BranchID { get; set; }
        public string BranchName { get; set; }

        public int BankingInfoID { get; set; }
        public BankingInfoModel BankingInfo { get; set; }

        public int? ActiveInd { get; set; }
    }
}
