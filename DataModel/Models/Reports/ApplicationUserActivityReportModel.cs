namespace DataModels.Models.Reports
{
    public class ApplicationUserActivityReportModel
    {
        public string ApplicationName { get; set; }
        public string MainModule { get; set; }
        public string SubModule { get; set; }
        public int TotalVisitors { get; set; }
        public int TotalUniqueUsers { get; set; } 
    }
}
