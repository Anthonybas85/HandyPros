using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DataModels.Common;

namespace DataModels.Models.Reports
{
    public class MaturityReportModel
    {

        public long UserID { get; set; }

        [LocalizedDisplayname1("FirstName")]
        public string FirstName { get; set; }

        [LocalizedDisplayname1("LastName")]
        public string LastName { get; set; }

        [LocalizedDisplayname1("FullName")]
        public string AgentName { get; set; }

        [LocalizedDisplayname1("Region")]
        public string RegionName { get; set; }

        [LocalizedDisplayname1("YTDVolume")]
        public decimal? YTDVolume { get; set; }

        [LocalizedDisplayname1("PrevYearsVolume")]
        public decimal PrevYearsVolume { get; set; }

        [LocalizedDisplayname1("TeamYTDVolume")]
        public decimal TeamYTDVolume { get; set; }

        [LocalizedDisplayname1("TeamPrevYearVolume")]
        public decimal TeamPrevYearVolume { get; set; }

        [LocalizedDisplayname1("TermDate")]
        public DateTime? TermDate { get; set; }

        [LocalizedDisplayname1("TeamName")]
        public string TeamName { get; set; }

        [LocalizedDisplayname1("TeamLeaderName")]
        public string TeamLeaderName { get; set; }

        [LocalizedDisplayname1("StartDate")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime? StartDate { get; set; }

        [LocalizedDisplayname1("MaturityDate")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime? MaturityDate { get; set; }

        [LocalizedDisplayname1("Notes")]
        public string Notes { get; set; }

        [LocalizedDisplayname1("Split")]
        public string Split { get; set; }

        public string TermDateStrDisplay
        {
            get { return TermDate.HasValue ? TermDate.Value.ToString("d") : string.Empty; }
        }

        public string StartDateStrDisplay
        {
            get { return StartDate.HasValue ? StartDate.Value.ToString("d") : string.Empty; }
        }

        public string MaturityDateStrDisplay
        {
            get { return MaturityDate.HasValue ? MaturityDate.Value.ToString("d") : string.Empty; }
        }

        public string YTDVolumeStrDisplay
        {
            get { return string.Format("{0:C}", YTDVolume ?? 0); }
        }

        public string PrevYearsVolumeStrDisplay
        {
            get { return string.Format("{0:C}", PrevYearsVolume); }
        }

        public string TeamYTDVolumeStrDisplay
        {
            get { return string.Format("{0:C}", TeamYTDVolume); }
        }

        public string TeamPrevYearVolumeStrDisplay
        {
            get { return string.Format("{0:C}", TeamPrevYearVolume); }
        }



    }

    public class MaturityAgentsDetailsGridModel
    {
        public MaturityAgentsDetailsGridModel()
        {
            DataTableAgentsList = new List<MaturityReportModel>();
            RegionModels = new List<RegionModel>();
            TeamModels = new List<TeamModel>();
        }

        public List<MaturityReportModel> DataTableAgentsList { get; set; }

        public List<RegionModel> RegionModels { get; set; }

        public List<TeamModel> TeamModels { get; set; }

        public decimal TeamYTDVolume { get; set; }

        public decimal TeamPrevYearVolume { get; set; }

        [LocalizedDisplayname1("EndDateBefore")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime EndDateBefore { get; set; }

        [LocalizedDisplayname1("MaturityStartDate")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime MaturityStartDate { get; set; }

        [LocalizedDisplayname1("MaturityEndDate")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime? MaturityEndDate { get; set; }
    }

    public class GetFunctionByID
    {
        [Key]
        public DateTime GetMaturityDateByID { get; set; }
    }
}