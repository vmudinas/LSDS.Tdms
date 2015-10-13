using System;

namespace LSDS.Tdms.Models.TdmsDataModel
{
    public partial class usp_ReturnUserSavedReports_Result
    {
        public string Filename { get; set; }
        public string Profile_name { get; set; }
        public Nullable<int> LogId { get; set; }
        public Nullable<DateTime> EndDate { get; set; }
        public string EndDateDisplay { get; set; }
        public string CreatedUser { get; set; }
    }
}
