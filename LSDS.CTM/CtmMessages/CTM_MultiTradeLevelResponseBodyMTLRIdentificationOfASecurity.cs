using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MultiTradeLevelResponseBodyMTLRIdentificationOfASecurity
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int CtmId { get; set; }

        private CTM_MultiTradeLevelResponseBodyMTLRIdentificationOfASecuritySecurityCodeType securityCodeTypeField;

        private string securityCodeField;

        private string descriptionOfTheSecurityField;

        /// <remarks/>
        public CTM_MultiTradeLevelResponseBodyMTLRIdentificationOfASecuritySecurityCodeType SecurityCodeType
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

        /// <remarks/>
        public string DescriptionOfTheSecurity
        {
            get
            {
                return this.descriptionOfTheSecurityField;
            }
            set
            {
                this.descriptionOfTheSecurityField = value;
            }
        }
    }
}
