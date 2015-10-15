using System.ComponentModel.DataAnnotations;

namespace CtmProcessor
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MessageMultiTradeLevelResponseMultiTradeLevelResponseBodyMTLR
    {
        [Key]
        public int CtmId { get; set; }

        private byte tLVersionOfTradeComponentField;

        private CTM_MessageMultiTradeLevelResponseMultiTradeLevelResponseBodyMTLRInstructingParty instructingPartyField;

        private CTM_MessageMultiTradeLevelResponseMultiTradeLevelResponseBodyMTLRExecutingBroker executingBrokerField;

        private CTM_MessageMultiTradeLevelResponseMultiTradeLevelResponseBodyMTLRTradeLevelReferences tradeLevelReferencesField;

        private CTM_MessageMultiTradeLevelResponseMultiTradeLevelResponseBodyMTLRMultiTradeLevelStatuses multiTradeLevelStatusesField;

        private string[] tLBusinessExceptionsField;

        private string buySellIndicatorField;

        private string securityTypeGroupField;

        private string typeOfFinancialInstrumentField;

        private CTM_MessageMultiTradeLevelResponseMultiTradeLevelResponseBodyMTLRIdentificationOfASecurity identificationOfASecurityField;

        private CTM_MessageMultiTradeLevelResponseMultiTradeLevelResponseBodyMTLRAdditionalSecurityIdentifiers additionalSecurityIdentifiersField;

        private ulong tradeDateTimeField;

        private CTM_MessageMultiTradeLevelResponseMultiTradeLevelResponseBodyMTLRTimeZone timeZoneField;

        private CTM_MessageMultiTradeLevelResponseMultiTradeLevelResponseBodyMTLRQuantityOfTheBlockTrade quantityOfTheBlockTradeField;

        private CTM_MessageMultiTradeLevelResponseMultiTradeLevelResponseBodyMTLRDealPrice dealPriceField;

        private CTM_MessageMultiTradeLevelResponseMultiTradeLevelResponseBodyMTLRTotalTradeAmount totalTradeAmountField;

        private uint settlementDateField;

        /// <remarks/>
        public byte TLVersionOfTradeComponent
        {
            get
            {
                return this.tLVersionOfTradeComponentField;
            }
            set
            {
                this.tLVersionOfTradeComponentField = value;
            }
        }

        /// <remarks/>
        public CTM_MessageMultiTradeLevelResponseMultiTradeLevelResponseBodyMTLRInstructingParty InstructingParty
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
        public CTM_MessageMultiTradeLevelResponseMultiTradeLevelResponseBodyMTLRExecutingBroker ExecutingBroker
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
        public CTM_MessageMultiTradeLevelResponseMultiTradeLevelResponseBodyMTLRTradeLevelReferences TradeLevelReferences
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
        public CTM_MessageMultiTradeLevelResponseMultiTradeLevelResponseBodyMTLRMultiTradeLevelStatuses MultiTradeLevelStatuses
        {
            get
            {
                return this.multiTradeLevelStatusesField;
            }
            set
            {
                this.multiTradeLevelStatusesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("TLBusinessExceptionCode", IsNullable = false)]
        public string[] TLBusinessExceptions
        {
            get
            {
                return this.tLBusinessExceptionsField;
            }
            set
            {
                this.tLBusinessExceptionsField = value;
            }
        }

        /// <remarks/>
        public string BuySellIndicator
        {
            get
            {
                return this.buySellIndicatorField;
            }
            set
            {
                this.buySellIndicatorField = value;
            }
        }

        /// <remarks/>
        public string SecurityTypeGroup
        {
            get
            {
                return this.securityTypeGroupField;
            }
            set
            {
                this.securityTypeGroupField = value;
            }
        }

        /// <remarks/>
        public string TypeOfFinancialInstrument
        {
            get
            {
                return this.typeOfFinancialInstrumentField;
            }
            set
            {
                this.typeOfFinancialInstrumentField = value;
            }
        }

        /// <remarks/>
        public CTM_MessageMultiTradeLevelResponseMultiTradeLevelResponseBodyMTLRIdentificationOfASecurity IdentificationOfASecurity
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
        public CTM_MessageMultiTradeLevelResponseMultiTradeLevelResponseBodyMTLRAdditionalSecurityIdentifiers AdditionalSecurityIdentifiers
        {
            get
            {
                return this.additionalSecurityIdentifiersField;
            }
            set
            {
                this.additionalSecurityIdentifiersField = value;
            }
        }

        /// <remarks/>
        public ulong TradeDateTime
        {
            get
            {
                return this.tradeDateTimeField;
            }
            set
            {
                this.tradeDateTimeField = value;
            }
        }

        /// <remarks/>
        public CTM_MessageMultiTradeLevelResponseMultiTradeLevelResponseBodyMTLRTimeZone TimeZone
        {
            get
            {
                return this.timeZoneField;
            }
            set
            {
                this.timeZoneField = value;
            }
        }

        /// <remarks/>
        public CTM_MessageMultiTradeLevelResponseMultiTradeLevelResponseBodyMTLRQuantityOfTheBlockTrade QuantityOfTheBlockTrade
        {
            get
            {
                return this.quantityOfTheBlockTradeField;
            }
            set
            {
                this.quantityOfTheBlockTradeField = value;
            }
        }

        /// <remarks/>
        public CTM_MessageMultiTradeLevelResponseMultiTradeLevelResponseBodyMTLRDealPrice DealPrice
        {
            get
            {
                return this.dealPriceField;
            }
            set
            {
                this.dealPriceField = value;
            }
        }

        /// <remarks/>
        public CTM_MessageMultiTradeLevelResponseMultiTradeLevelResponseBodyMTLRTotalTradeAmount TotalTradeAmount
        {
            get
            {
                return this.totalTradeAmountField;
            }
            set
            {
                this.totalTradeAmountField = value;
            }
        }

        /// <remarks/>
        public uint SettlementDate
        {
            get
            {
                return this.settlementDateField;
            }
            set
            {
                this.settlementDateField = value;
            }
        }
    }
}
