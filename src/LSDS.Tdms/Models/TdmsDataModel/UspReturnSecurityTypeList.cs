using System.ComponentModel.DataAnnotations;

namespace LSDS.Tdms.Models.TdmsDataModel
{
    public class UspReturnSecurityTypeList
    {
        public int tdxSecurityType { get; set; } 
        [MaxLength(3)]
        public string TypeCode { get; set; } 
        [MaxLength(36)]
        public string Description { get; set; } 
        public int? FlagBond1 { get; set; } 
        public int? FlagBond2 { get; set; } 
        public int? FlagBond3 { get; set; } 
        public int? FlagType1 { get; set; } 
        public int? FlagType2 { get; set; } 
        public int? FlagType3 { get; set; }
        [MaxLength(12)]
        public string TypeCodeAlt { get; set; } 
        [MaxLength(12)]
        public string TradeSource { get; set; } 
        [MaxLength(12)]
        public string SettlementLoc { get; set; } 
        [MaxLength(54)]
        public string SecurityTypeDisplay { get; set; } 
    }

}
