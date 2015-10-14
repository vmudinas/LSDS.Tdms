using System;
using System.ComponentModel.DataAnnotations;

namespace LSDS.Tdms.Models.TdmsDataModel
{
    public class UspReturnMatchedTradesConfirms
    {
       
        public int? tdTrade { get; set; }
        [MaxLength(16)]
        [Key]
        public string TradeRefNo { get; set; } 
        public int? tdConfirm { get; set; }
        [MaxLength(16)]
        public string ConfirmRefNo { get; set; }
        public DateTime? mTradeDate { get; set; } 
        public int? Archive { get; set; } 
        public int? History { get; set; }
        [MaxLength(6)]
        public string ConfirmSource { get; set; } 
    }

}
