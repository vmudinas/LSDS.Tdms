using System.ComponentModel.DataAnnotations;
using CtmProcessor;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MessageMultiTradeLevelResponse
    {
        [Key]
        public int CtmId { get; set; }
        private CTM_MessageMultiTradeLevelResponseResponseHeader responseHeaderField;

        private CTM_MessageMultiTradeLevelResponseMultiTradeLevelResponseBody multiTradeLevelResponseBodyField;

        /// <remarks/>
        public CTM_MessageMultiTradeLevelResponseResponseHeader ResponseHeader
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
        public CTM_MessageMultiTradeLevelResponseMultiTradeLevelResponseBody MultiTradeLevelResponseBody
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
