using System;
using System.Collections.Generic;

namespace LSDS.Tdms.Models.TdmsDataModel
{
    public partial class tdxCurrencyCode
    {
        public tdxCurrencyCode()
        {
            this.tblSettlementInstructionsMCs = new List<tblSettlementInstructionsMC>();
        }

        public string CurrencyCode { get; set; }
        public string CurrencyCodeAlt { get; set; }
        public string CurrencyCodeDesc { get; set; }
        public Nullable<short> SortOrder { get; set; }
        public virtual ICollection<tblSettlementInstructionsMC> tblSettlementInstructionsMCs { get; set; }
    }
}
