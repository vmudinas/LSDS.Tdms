using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace LSDS.Tdms.Models.TdmsDataModel
{
    public class UspReturnSettlementLocList
    {
        public UspReturnSettlementLocList()
        {
            this.tblSettlementInstructionsMCs = new List<tblSettlementInstructionsMC>();
        }
        [Key]
        public int tdxSettlementLoc1 { get; set; }
        public string SettlementLoc { get; set; }
        public string SettlementLocDesc { get; set; }
        public byte[] timestamp { get; set; }
        public int? tdxCountryCode { get; set; }
        public byte? Equity { get; set; }
        public byte? CorporateFI { get; set; }
        public byte? GovtFI { get; set; }
        public byte? MoneyMarkets { get; set; }
        public virtual ICollection<tblSettlementInstructionsMC> tblSettlementInstructionsMCs { get; set; }
    }
}
