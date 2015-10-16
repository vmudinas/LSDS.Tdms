using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_TradeDetailBody
    {
        [Key]
        public int CtmId { get; set; }
        private string functionOfTheMessageField;

        private byte versionOfTradeComponentField;

        private CTM_TradeDetailBodyInstructingParty instructingPartyField;

        private CTM_TradeDetailBodyExecutingBroker executingBrokerField;

        private CTM_TradeDetailBodyTradeLevelReferences tradeLevelReferencesField;

        private CTM_TradeDetailBodyTradeDetailReferences tradeDetailReferencesField;

        private string tradeLevelExpectedField;

        private CTM_TradeDetailBodyIdentificationOfASecurity identificationOfASecurityField;

        private CTM_TradeDetailBodyTradeLevelInformation tradeLevelInformationField;

        private CTM_TradeDetailBodyTradeDetailData tradeDetailDataField;

        private CTM_TradeDetailBodyIPSettlement iPSettlementField;

        private CTM_TradeDetailBodyPartySettlement partySettlementField;

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
        public CTM_TradeDetailBodyInstructingParty InstructingParty
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
        public CTM_TradeDetailBodyExecutingBroker ExecutingBroker
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
        public CTM_TradeDetailBodyTradeLevelReferences TradeLevelReferences
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
        public CTM_TradeDetailBodyTradeDetailReferences TradeDetailReferences
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
        public CTM_TradeDetailBodyIdentificationOfASecurity IdentificationOfASecurity
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
        public CTM_TradeDetailBodyTradeLevelInformation TradeLevelInformation
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
        public CTM_TradeDetailBodyTradeDetailData TradeDetailData
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
        public CTM_TradeDetailBodyIPSettlement IPSettlement
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
        public CTM_TradeDetailBodyPartySettlement PartySettlement
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