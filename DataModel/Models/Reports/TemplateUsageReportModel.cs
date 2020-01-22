using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataModels.Models.Reports
{
    public class TemplateUsageReportModel
    {
        public int? TemplateID { get; set; }
        public long? TriggerActionTemplateID { get; set; }
        public string TemplateName { get; set; }
        public string TemplateCategory { get; set; }
        public int? TimeUsed { get; set; }
        public int? NumberOfRecipients { get; set; }
        public int? UniqueUsers { get; set; }
        public int? OpenedMessages { get; set; }
        public int? BouncedMessages { get; set; }


        public int? EmailTemplateID { get; set; }
    }
}
