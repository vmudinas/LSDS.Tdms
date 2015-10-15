using System.ComponentModel.DataAnnotations;

namespace CtmProcessor.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MessageMultiTradeLevelRequest
    {
        [Key]
        public int CtmId { get; set; }
        private CTM_MessageMultiTradeLevelRequestSubmitHeader submitHeaderField;

        private CTM_MessageMultiTradeLevelRequestMultiTradeLevelRequestBody multiTradeLevelRequestBodyField;

        /// <remarks/>
        public CTM_MessageMultiTradeLevelRequestSubmitHeader SubmitHeader
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
        public CTM_MessageMultiTradeLevelRequestMultiTradeLevelRequestBody MultiTradeLevelRequestBody
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