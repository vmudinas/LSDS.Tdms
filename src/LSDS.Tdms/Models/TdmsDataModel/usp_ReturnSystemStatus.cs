using System;

namespace LSDS.Tdms.Models.TdmsDataModel
{
    public class usp_ReturnSystemStatus
    {
        public int tdSystemStatus { get; set; }
        public string StatusType { get; set; }
        public DateTime? LastRun { get; set; }
        public string LastRunDisplay { get; set; }
        public int? LastRunTimingType { get; set; }
        public string LastRunTimingTypeDesc { get; set; }
        public DateTime? NextRun { get; set; }
        public string NextRunDisplay { get; set; }
        public int? NextRunTimingType { get; set; }
        public string NextRunTimingTypeDesc { get; set; }
        public int? New { get; set; }
        public int? Cancel { get; set; }
        public int? Matched { get; set; }
        public int? Affirmed { get; set; }
        public int? LastRunStatus { get; set; }
        public string LastRunStatusDesc { get; set; }
        public int? tblFundAccounting { get; set; }
        public int? LastMasterLogId { get; set; }
        public int? ErrorLogCount { get; set; }
        public string User_Group_Description { get; set; }
        public bool? Edit { get; set; }
    }
}