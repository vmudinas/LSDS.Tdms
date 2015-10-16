using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_TradeDetailBodyIdentificationOfASecurity
    {
        [Key]
        public int CtmId { get; set; }

        private CTM_TradeDetailBodyIdentificationOfASecuritySecurityCodeType securityCodeTypeField;

        private string securityCodeField;

        private string descriptionOfTheSecurityField;

        /// <remarks/>
        public CTM_TradeDetailBodyIdentificationOfASecuritySecurityCodeType SecurityCodeType
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