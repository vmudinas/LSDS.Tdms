using System;
using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [Serializable]
    public partial class CTM_MultiTradeDetailResponse
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int TradeDetailResponseCtmId { get; set; }
        private CTM_ResponseHeader responseHeaderField;

        private CTM_MultiTradeDetailResponseMultiTradeDetailResponseBody multiTradeDetailResponseBodyField;

        /// <remarks/>
        public CTM_ResponseHeader ResponseHeader
        {
            get
            {
                return this.responseHeaderField;
            }
            set
            {
                this.responseHeaderField = value;
            }
        }

        /// <remarks/>
        public CTM_MultiTradeDetailResponseMultiTradeDetailResponseBody MultiTradeDetailResponseBody
        {
            get
            {
                return this.multiTradeDetailResponseBodyField;
            }
            set
            {
                this.multiTradeDetailResponseBodyField = value;
            }
        }
    }
}