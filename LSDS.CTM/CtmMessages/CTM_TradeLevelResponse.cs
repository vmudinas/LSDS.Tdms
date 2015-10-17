using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MultiTradeLevelResponse
    {
        [Key]
        public int CtmId { get; set; }
        private CTM_ResponseHeader responseHeaderField;

        private CTM_MultiTradeLevelResponseBody multiTradeLevelResponseBodyField;

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
        public CTM_MultiTradeLevelResponseBody MultiTradeLevelResponseBody
        {
            get
            {
                return this.multiTradeLevelResponseBodyField;
            }
            set
            {
                this.multiTradeLevelResponseBodyField = value;
            }
        }
    }
}
