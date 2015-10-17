using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_TradeLevelBody
    {
        [Key]
        public int CtmId { get; set; }

        private string functionOfTheMessageField;

        private byte versionOfTradeComponentField;

        private CTM_TradeLevelBodyInstructingParty instructingPartyField;

        private CTM_TradeLevelBodyExecutingBroker executingBrokerField;

        private CTM_TradeLevelBodyTradeLevelReferences tradeLevelReferencesField;

        private CTM_TradeLevelBodyIdentificationOfASecurity identificationOfASecurityField;

        private CTM_TradeLevelBodyTradeLevelInformation tradeLevelInformationField;

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
        public CTM_TradeLevelBodyInstructingParty InstructingParty
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
        public CTM_TradeLevelBodyExecutingBroker ExecutingBroker
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
        public CTM_TradeLevelBodyTradeLevelReferences TradeLevelReferences
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
        public CTM_TradeLevelBodyIdentificationOfASecurity IdentificationOfASecurity
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
        public CTM_TradeLevelBodyTradeLevelInformation TradeLevelInformation
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