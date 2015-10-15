using System;
using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [Serializable]
    public partial class CTM_MessageMultiTradeDetailResponse
    {
        [Key]
        public int CtmId { get; set; }
        private CTM_MessageMultiTradeDetailResponseResponseHeader responseHeaderField;

        private CTM_MessageMultiTradeDetailResponseMultiTradeDetailResponseBody multiTradeDetailResponseBodyField;

        /// <remarks/>
        public CTM_MessageMultiTradeDetailResponseResponseHeader ResponseHeader
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
        public CTM_MessageMultiTradeDetailResponseMultiTradeDetailResponseBody MultiTradeDetailResponseBody
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