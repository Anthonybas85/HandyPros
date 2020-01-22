namespace DataModels.Models
{
    public class TeamBankingInfoXrefModel
    {
        public int TeamBankingInfoXrefID { get; set; }

        public int TeamID { get; set; }
        public string TeamName { get; set; }

        public int BankingInfoID { get; set; }
        public BankingInfoModel BankingInfo { get; set; }

        public int? ActiveInd { get; set; }
    }
}
