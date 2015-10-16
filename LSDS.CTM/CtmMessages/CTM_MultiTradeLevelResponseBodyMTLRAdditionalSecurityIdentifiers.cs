using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MultiTradeLevelResponseBodyMTLRAdditionalSecurityIdentifiers
    {
        [Key]
        public int CtmId { get; set; }
        private CTM_MultiTradeLevelResponseBodyMTLRAdditionalSecurityIdentifiersSecurityCodeType securityCodeTypeField;

        private string securityCodeField;

        /// <remarks/>
        public CTM_MultiTradeLevelResponseBodyMTLRAdditionalSecurityIdentifiersSecurityCodeType SecurityCodeType
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