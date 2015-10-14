namespace CTMLibrary.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MessageTradeDetailTradeDetailBody
    {

        private string functionOfTheMessageField;

        private byte versionOfTradeComponentField;

        private CTM_MessageTradeDetailTradeDetailBodyInstructingParty instructingPartyField;

        private CTM_MessageTradeDetailTradeDetailBodyExecutingBroker executingBrokerField;

        private CTM_MessageTradeDetailTradeDetailBodyTradeLevelReferences tradeLevelReferencesField;

        private CTM_MessageTradeDetailTradeDetailBodyTradeDetailReferences tradeDetailReferencesField;

        private string tradeLevelExpectedField;

        private CTM_MessageTradeDetailTradeDetailBodyIdentificationOfASecurity identificationOfASecurityField;

        private CTM_MessageTradeDetailTradeDetailBodyTradeLevelInformation tradeLevelInformationField;

        private CTM_MessageTradeDetailTradeDetailBodyTradeDetailData tradeDetailDataField;

        private CTM_MessageTradeDetailTradeDetailBodyIPSettlement iPSettlementField;

        private CTM_MessageTradeDetailTradeDetailBodyPartySettlement partySettlementField;

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
        public CTM_MessageTradeDetailTradeDetailBodyInstructingParty InstructingParty
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
        public CTM_MessageTradeDetailTradeDetailBodyExecutingBroker ExecutingBroker
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
        public CTM_MessageTradeDetailTradeDetailBodyTradeLevelReferences TradeLevelReferences
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
        public CTM_MessageTradeDetailTradeDetailBodyTradeDetailReferences TradeDetailReferences
        {
            get
            {
                return this.tradeDetailReferencesField;
            }
            set
            {
                this.tradeDetailReferencesField = value;
            }
        }

        /// <remarks/>
        public string TradeLevelExpected
        {
            get
            {
                return this.tradeLevelExpectedField;
            }
            set
            {
                this.tradeLevelExpectedField = value;
            }
        }

        /// <remarks/>
        public CTM_MessageTradeDetailTradeDetailBodyIdentificationOfASecurity IdentificationOfASecurity
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
        public CTM_MessageTradeDetailTradeDetailBodyTradeLevelInformation TradeLevelInformation
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

        /// <remarks/>
        public CTM_MessageTradeDetailTradeDetailBodyTradeDetailData TradeDetailData
        {
            get
            {
                return this.tradeDetailDataField;
            }
            set
            {
                this.tradeDetailDataField = value;
            }
        }

        /// <remarks/>
        public CTM_MessageTradeDetailTradeDetailBodyIPSettlement IPSettlement
        {
            get
            {
                return this.iPSettlementField;
            }
            set
            {
                this.iPSettlementField = value;
            }
        }

        /// <remarks/>
        public CTM_MessageTradeDetailTradeDetailBodyPartySettlement PartySettlement
        {
            get
            {
                return this.partySettlementField;
            }
            set
            {
                this.partySettlementField = value;
            }
        }
    }
}