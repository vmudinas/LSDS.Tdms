using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_TradeDetailBody
    {
        [Key]
        public int CtmId { get; set; }       
        private string functionOfTheMessageField;
        private byte versionOfTradeComponentField;
        private string processingIndicator;
        private string reportingIndicator;
        private string detailLevelPartyCapacityIndicator;
        private CTM_TradeDetailBodyInstructingParty instructingPartyField;
        private CTM_TradeDetailBodyExecutingBroker executingBrokerField;
        private CTM_TradeDetailBodyTradeLevelReferences tradeLevelReferencesField;
        private CTM_TradeDetailBodyCPTYTradeLevelIdentifiers cPTYTradeLevelIdentifiers;
        private CTM_TradeDetailBodyTradeDetailReferences tradeDetailReferencesField;
        private string tradeLevelExpectedField;
        private CTM_TradeDetailBodyIdentificationOfASecurity identificationOfASecurityField;
        private CTM_AdditionalSecurityIdentifiers additionalSecurityIdentifiers;
        private CTM_TradeDetailBodyTradeLevelInformation tradeLevelInformationField;
        private CTM_TradeDetailBodyTradeDetailData tradeDetailDataField;
        private CTM_TradeDetailBodyIPSettlement iPSettlementField;
        private CTM_TradeDetailBodyPartySettlement partySettlementField;
        private CTM_TradeDetailBodyAdditionalDisclosures additionalDisclosures;
        private CTM_TradeDetailBodyAdditionalData additionalData;
        private CTM_TradeDetailBodyAdditionalDataIPSettlement additionalDataIPSettlement;
        private CTM_TradeDetailBodyAdditionalDataEBSettlement eBSettlement;
        private CTM_TradeDetailBodyConfirmDisclosureData confirmDisclosureData;

        public CTM_TradeDetailBodyConfirmDisclosureData ConfirmDisclosureData
        {
            get
            {
                return this.confirmDisclosureData;
            }
            set
            {
                this.confirmDisclosureData = value;
            }
        }


        public CTM_TradeDetailBodyAdditionalDataEBSettlement EBSettlement
        {
            get
            {
                return this.eBSettlement;
            }
            set
            {
                this.eBSettlement = value;
            }
        }

        public CTM_TradeDetailBodyAdditionalDataIPSettlement AdditionalDataIPSettlement
        {
            get
            {
                return this.additionalDataIPSettlement;
            }
            set
            {
                this.additionalDataIPSettlement = value;
            }
        }

        public CTM_TradeDetailBodyAdditionalData AdditionalData
        {
            get
            {
                return this.additionalData;
            }
            set
            {
                this.additionalData = value;
            }
        }
        public CTM_TradeDetailBodyAdditionalDisclosures AdditionalDisclosures
        {
            get
            {
                return this.additionalDisclosures;
            }
            set
            {
                this.additionalDisclosures = value;
            }
        }

        [MaxLength(35)]
        public string TDUpdateGuard { get; set; }
        [MaxLength(35)]
        public string L2MatchingProfileName { get; set; }
        [MaxLength(35)]
        public string ShowHiddenFieldsIndicator { get; set; }
        [MaxLength(4)]
        public string ProcessingIndicator { get; set; }
        [MaxLength(4)]
        public string ReportingIndicator { get; set; }
        [MaxLength(4)]
        public string DetailLevelPartyCapacityIndicator { get; set; }
        
        /// <remarks/>
        [MaxLength(4)]
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
        public CTM_AdditionalSecurityIdentifiers AdditionalSecurityIdentifiers
        {
            get
            {
                return this.additionalSecurityIdentifiers;
            }
            set
            {
                this.additionalSecurityIdentifiers = value;
            }
        }

        /// <remarks/>
        [MaxLength(10)]
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
        [MaxLength(1)]
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