using System;
using System.Collections.Generic;
using DataModels.Common;

namespace DataModels.Models
{
    public class MaturityAgentsDetailsModel
    {
        public string AgentName { get; set; }

        public decimal YTDVolume { get; set; }

        public decimal PrevYearsVolume { get; set; }

        public DateTime? TermDate { get; set; }

        public string TermDateStr
        {
            get { return TermDate.HasValue ? TermDate.Value.ToString("d") : string.Empty; }
        }
    }


    public class MaturityAgentsDetailsGridModel
    {
        public MaturityAgentsDetailsGridModel()
        {
            DataTableAgentsList = new List<MaturityAgentsDetailsModel>();
        }

        public List<MaturityAgentsDetailsModel> DataTableAgentsList { get; set; }

        public decimal TeamYTDVolume { get; set; }

        public decimal TeamPrevYearVolume { get; set; }
    }

}
