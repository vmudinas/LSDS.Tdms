using System.ComponentModel.DataAnnotations;

namespace LSDS.Tdms.Models.TdmsDataModel
{
    public class UspLookupNotifyStatus
    {
        [Key]
        public int tdxTradeNotifyCode { get; set; }
        [MaxLength(16)]
        public string code { get; set; }
        [MaxLength(128)]
        public string description { get; set; }
        [MaxLength(16)]
        public string mapToCode1 { get; set; }
        [MaxLength(16)]
        public string mapToCode2 { get; set; }
        [MaxLength(16)]
        public string mapToCode3 { get; set; }
        [MaxLength(16)]
        public string mapToCode4 { get; set; }
        [MaxLength(16)]
        public string notifyType { get; set; } 
    }
}
