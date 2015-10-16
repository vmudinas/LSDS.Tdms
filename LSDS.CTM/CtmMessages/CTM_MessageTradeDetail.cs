using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace LSDS.CTM
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MessageTradeDetail
    {
        [Key]
        public int CtmId { get; set; }

        public DateTime LastUpdated { get; set; }
       
        private CTM_MessageTradeDetailSubmitHeader submitHeaderField;

        private CTM_MessageTradeDetailTradeDetailBody tradeDetailBodyField;

        /// <remarks/>
        public CTM_MessageTradeDetailSubmitHeader SubmitHeader
        {
            get
            {
                return this.submitHeaderField;
            }
            set
            {
                this.submitHeaderField = value;
            }
        }

        /// <remarks/>
        public CTM_MessageTradeDetailTradeDetailBody TradeDetailBody
        {
            get
            {
                return this.tradeDetailBodyField;
            }
            set
            {
                this.tradeDetailBodyField = value;
            }
        }
    }
}