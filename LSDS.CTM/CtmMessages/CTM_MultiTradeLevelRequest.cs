using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MultiTradeLevelRequest
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int TradeLevelRequestCtmId { get; set; }
        private CTM_Header submitHeaderField;

        private CTM_MultiTradeLevelRequestBody multiTradeLevelRequestBodyField;

        /// <remarks/>
        public CTM_Header SubmitHeader
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
        public CTM_MultiTradeLevelRequestBody MultiTradeLevelRequestBody
        {
            get
            {
                return this.multiTradeLevelRequestBodyField;
            }
            set
            {
                this.multiTradeLevelRequestBodyField = value;
            }
        }
    }
}