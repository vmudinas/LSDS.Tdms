using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_AdditionalSecurityIdentifiers
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int CtmId { get; set; }
        private CTM_AdditionalSecurityIdentifiersSecurityCodeType securityCodeTypeField;

        private string securityCodeField;

        /// <remarks/>
        public CTM_AdditionalSecurityIdentifiersSecurityCodeType SecurityCodeType
        {
            get
            {
                return this.securityCodeTypeField;
            }
            set
            {
                this.securityCodeTypeField = value;
            }
        }

        /// <remarks/>
        [MaxLength(30)]
        public string SecurityCode
        {
            get
            {
                return this.securityCodeField;
            }
            set
            {
                this.securityCodeField = value;
            }
        }
    }
}