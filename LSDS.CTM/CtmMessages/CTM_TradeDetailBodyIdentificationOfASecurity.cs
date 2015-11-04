using System;
using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_TradeDetailBodyIdentificationOfASecurity
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int IdentificationOfASecurityCtmId { get; set; }

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
        [MaxLength(35)]
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