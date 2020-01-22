namespace DataModels.Models
{
    public class BrokerBankingInfoXrefModel
    {
        public int BrokerBankingInfoXrefID { get; set; }

        public int BrokerID { get; set; }
        public string BrokerName { get; set; }

        public int BankingInfoID { get; set; }
        public BankingInfoModel BankingInfo { get; set; }

        public int? ActiveInd { get; set; }

        public int? SameAs { get; set; }
    }
}