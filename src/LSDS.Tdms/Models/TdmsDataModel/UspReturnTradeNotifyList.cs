using System;
using System.ComponentModel.DataAnnotations;

namespace LSDS.Tdms.Models.TdmsDataModel
{
    public class UspReturnTradeNotifyList
    {
        [MaxLength(12)]
        [Key]
        public string ShawPortNo { get; set; } 
        public int? tblPortContact { get; set; } 
        public int? contact_no { get; set; } 
        [MaxLength(64)]
        public string ContactTypeDesc { get; set; } 
        [MaxLength(64)]
        public string contact_name { get; set; }
        [MaxLength(64)]
        public string contact_company { get; set; }
        [MaxLength(64)]
        public string contact_addrs2 { get; set; }
        [MaxLength(82)]
        public string contact_City { get; set; }
        [MaxLength(40)]
        public string contact_State { get; set; }
        [MaxLength(3)]
        public string contact_Zip { get; set; }
        [MaxLength(10)]
        public string contact_fax { get; set; }
        [MaxLength(18)]
        public string contact_phone { get; set; }
        [MaxLength(18)]
        public string TransportDesc { get; set; }
        [MaxLength(64)]
        public string Fax_File_Name_Local { get; set; }
        [MaxLength(255)]
        public DateTime? date_time { get; set; } 
        public int? iomessageLog { get; set; } 
        public int? SentFlag { get; set; } 
    }

}
