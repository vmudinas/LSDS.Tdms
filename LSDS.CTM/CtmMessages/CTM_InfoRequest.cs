using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_InfoRequest
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int InfoRequestCtmId { get; set; }

        private CTM_Header submitHeaderField;

        private CTM_InfoRequestBody infoRequestBodyField;

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
        public CTM_InfoRequestBody InfoRequestBody
        {
            get
            {
                return this.infoRequestBodyField;
            }
            set
            {
                this.infoRequestBodyField = value;
            }
        }
    }
}