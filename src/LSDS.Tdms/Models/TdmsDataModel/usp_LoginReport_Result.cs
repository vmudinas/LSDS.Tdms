
using System;

namespace LSDS.Tdms.Models.TdmsDataModel
{
    public partial class usp_LoginReport_Result
    {
        public Guid id { get; set; }
        public string user_name { get; set; }
        public string Fullname { get; set; }
        public string Description { get; set; }
        public string ClientName { get; set; }
        public string CurrentLocation { get; set; }
        public DateTime? LoginDate { get; set; }
        public bool? LoginSuccess { get; set; }
    }
}
