namespace CTMLibrary.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MessageTradeDetailTradeDetailBodyIdentificationOfASecurity
    {

        private CTM_MessageTradeDetailTradeDetailBodyIdentificationOfASecuritySecurityCodeType securityCodeTypeField;

        private string securityCodeField;

        private string descriptionOfTheSecurityField;

        /// <remarks/>
        public CTM_MessageTradeDetailTradeDetailBodyIdentificationOfASecuritySecurityCodeType SecurityCodeType
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