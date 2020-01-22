namespace DataModels.Models.Reports
{
    public class MarketingReportModel
    {
        public string GroupName { get; set; }
        public string TemplateName { get; set; }
        public int? Language { get; set; }
        public int? TimeUsed { get; set; }
        public string IsFranchise { get; set; }              
    }
}
