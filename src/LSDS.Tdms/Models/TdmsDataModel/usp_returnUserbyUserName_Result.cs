
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LSDS.Tdms.Models.TdmsDataModel
{
    public partial class usp_returnUserbyUserName_Result
    {
        public Guid id { get; set; }
        public string user_name { get; set; }
        public string description { get; set; }
        public Nullable<int> priority { get; set; }
        public Nullable<int> user_type { get; set; }
        public Nullable<byte> user_status { get; set; }
        public string psw { get; set; }
        public Nullable<int> passperiod { get; set; }
        public Nullable<DateTime> passchanged { get; set; }
        public string fullname { get; set; }
        public string image_loginid { get; set; }
        public Nullable<int> security_level { get; set; }
        public string signature_file { get; set; }
        public byte[] signature_image { get; set; }
        public string email { get; set; }
        public int UserID { get; set; }
        public int tdUserGroupID { get; set; }
        public int tdxLocationID { get; set; }
        public byte[] timestamp { get; set; }
    }
}
