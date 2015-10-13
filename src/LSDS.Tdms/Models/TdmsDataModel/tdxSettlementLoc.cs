using System;
using System.Collections.Generic;

namespace LSDS.Tdms.Models.TdmsDataModel
{
    public partial class tdxSettlementLoc
    {
        public tdxSettlementLoc()
        {
            this.tblSettlementInstructionsMCs = new List<tblSettlementInstructionsMC>();
        }

        public int tdxSettlementLoc1 { get; set; }
        public string SettlementLoc { get; set; }
        public string SettlementLocDesc { get; set; }
        public byte[] timestamp { get; set; }
        public Nullable<int> tdxCountryCode { get; set; }
        public Nullable<byte> Equity { get; set; }
        public Nullable<byte> CorporateFI { get; set; }
        public Nullable<byte> GovtFI { get; set; }
        public Nullable<byte> MoneyMarkets { get; set; }
        public virtual ICollection<tblSettlementInstructionsMC> tblSettlementInstructionsMCs { get; set; }
    }
}
