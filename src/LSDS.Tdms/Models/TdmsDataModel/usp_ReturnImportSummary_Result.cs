
using System;

namespace LSDS.Tdms.Models.TdmsDataModel
{
    public partial class usp_ReturnImportSummary_Result
    {
        public int tdMasterLog { get; set; }
        public short? LogType { get; set; }
        public string LogTypeAlt { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int TotalRecordCount { get; set; }
        public string Source { get; set; }
        public short? Status { get; set; }
        public string StatusDesc { get; set; }
        public string SysComment { get; set; }
        public int? tdUserGroupId { get; set; }
    }
}
