namespace CTMLibrary.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MessageTradeLevelTradeLevelBody
    {

        private string functionOfTheMessageField;

        private byte versionOfTradeComponentField;

        private CTM_MessageTradeLevelTradeLevelBodyInstructingParty instructingPartyField;

        private CTM_MessageTradeLevelTradeLevelBodyExecutingBroker executingBrokerField;

        private CTM_MessageTradeLevelTradeLevelBodyTradeLevelReferences tradeLevelReferencesField;

        private CTM_MessageTradeLevelTradeLevelBodyIdentificationOfASecurity identificationOfASecurityField;

        private CTM_MessageTradeLevelTradeLevelBodyTradeLevelInformation tradeLevelInformationField;

        /// <remarks/>
        public string FunctionOfTheMessage
        {
            get
            {
                return this.functionOfTheMessageField;
            }
            set
            {
                this.functionOfTheMessageField = value;
            }
        }

        /// <remarks/>
        public byte VersionOfTradeComponent
        {
            get
            {
                return this.versionOfTradeComponentField;
            }
            set
            {
                this.versionOfTradeComponentField = value;
            }
        }

        /// <remarks/>
        public CTM_MessageTradeLevelTradeLevelBodyInstructingParty InstructingParty
        {
            get
            {
                return this.instructingPartyField;
            }
            set
            {
                this.instructingPartyField = value;
            }
        }

        /// <remarks/>
        public CTM_MessageTradeLevelTradeLevelBodyExecutingBroker ExecutingBroker
        {
            get
            {
                return this.executingBrokerField;
            }
            set
            {
                this.executingBrokerField = value;
            }
        }

        /// <remarks/>
        public CTM_MessageTradeLevelTradeLevelBodyTradeLevelReferences TradeLevelReferences
        {
            get
            {
                return this.tradeLevelReferencesField;
            }
            set
            {
                this.tradeLevelReferencesField = value;
            }
        }

        /// <remarks/>
        public CTM_MessageTradeLevelTradeLevelBodyIdentificationOfASecurity IdentificationOfASecurity
        {
            get
            {
                return this.identificationOfASecurityField;
            }
            set
            {
                this.identificationOfASecurityField = value;
            }
        }

        /// <remarks/>
        public CTM_MessageTradeLevelTradeLevelBodyTradeLevelInformation TradeLevelInformation
        {
            get
            {
                return this.tradeLevelInformationField;
            }
            set
            {
                this.tradeLevelInformationField = value;
            }
        }
    }
}