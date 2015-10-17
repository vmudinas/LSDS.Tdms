using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_Valid
    {
        [Key]
        public int CtmId { get; set; }

        private CTM_ResponseHeader responseHeaderField;

        private CTM_ValidBody validBodyField;

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
        public CTM_ValidBody ValidBody
        {
            get
            {
                return this.validBodyField;
            }
            set
            {
                this.validBodyField = value;
            }
        }
    }
}