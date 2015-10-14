using System;
using System.ComponentModel.DataAnnotations;

namespace LSDS.Tdms.Models.TdmsDataModel
{
    public class UspReturnTradeRepairLog
    {
        [Key]
        public int tdTradeRepairLog { get; set; } 
        public DateTime mTradeDate { get; set; } 
        [MaxLength(15)]
        public string TradeRefNo { get; set; } 
        [MaxLength(50)]
        public string CUSIPNo { get; set; } 
        [MaxLength(12)]
        public string ShawPortNo { get; set; } 
        [MaxLength(1)]
        public string mTransactionCode { get; set; } 
        public int? tblShawPort { get; set; } 
        [MaxLength(25)]
        public string RepairType { get; set; } 
        [MaxLength(255)]
        public string RepairDescription { get; set; } 
        [MaxLength(36)]
        public string RepairedBy { get; set; } 
        public DateTime? RepairedDate { get; set; } 
    }

}
