using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MultiTradeLevelRequest
    {
        [Key]
        public int CtmId { get; set; }
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