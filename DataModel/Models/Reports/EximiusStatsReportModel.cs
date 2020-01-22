using System;

namespace DataModels.Models.Reports
{
    public class EximiusStatsReportModel
    {
        public string UserName { get; set; }
        public string TeamName { get; set; }
        public string RegionName { get; set; }
        public int autoemail { get; set; }
        public int adhoc { get; set; }
        public int taskreminders { get; set; }
        public int received { get; set; }
        public string MtgAppSettings { get; set; }
        public string TaskReminderSettings { get; set; }
        public string AutoEmailSettings { get; set; }
        public string ProfileSettings { get; set; }
        public string Enrolled { get; set; }
        public string ProfileType { get; set; }
        public DateTime? LastLogin { get; set; }
    }
}
