using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MessageMultiTradeLevelResponseMultiTradeLevelResponseBodyMTLRAdditionalSecurityIdentifiers
    {
        [Key]
        public int CtmId { get; set; }
        private CTM_MessageMultiTradeLevelResponseMultiTradeLevelResponseBodyMTLRAdditionalSecurityIdentifiersSecurityCodeType securityCodeTypeField;

        private string securityCodeField;

        /// <remarks/>
        public CTM_MessageMultiTradeLevelResponseMultiTradeLevelResponseBodyMTLRAdditionalSecurityIdentifiersSecurityCodeType SecurityCodeType
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