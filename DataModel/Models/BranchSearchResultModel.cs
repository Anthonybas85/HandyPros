using System;

namespace DataModels.Models
{
    public class BranchSearchResultModel
    {
        public int branchid { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime? effectivedate { get; set; }
        public DateTime? enddate { get; set; }
        public int? activeind { get; set; }
        public int? branchleaderid { get; set; }
        public string branchleaderName { get; set; }
        public int? teamid { get; set; }
        public string teamname { get; set; }
        public int? brokerhouseregionid { get; set; }
        public int? brokerhouseid { get; set; }
        public string brokerhousename { get; set; }
        public string brokerhouseAbbr { get; set; }
        public int? regionid { get; set; }
        public string regionname { get; set; }
    }
}
