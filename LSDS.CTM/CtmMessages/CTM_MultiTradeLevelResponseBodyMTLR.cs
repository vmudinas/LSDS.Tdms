using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MultiTradeLevelResponseBodyMTLR
    {
        [Key]
        public int CtmId { get; set; }

        private byte tLVersionOfTradeComponentField;

        private CTM_MultiTradeLevelResponseBodyMTLRInstructingParty instructingPartyField;

        private CTM_MultiTradeLevelResponseBodyMTLRExecutingBroker executingBrokerField;

        private CTM_MultiTradeLevelResponseBodyMTLRTradeLevelReferences tradeLevelReferencesField;

        private CTM_MultiTradeLevelResponseBodyMTLRMultiTradeLevelStatuses multiTradeLevelStatusesField;

        private string[] tLBusinessExceptionsField;

        private string buySellIndicatorField;

        private string securityTypeGroupField;

        private string typeOfFinancialInstrumentField;

        private CTM_MultiTradeLevelResponseBodyMTLRIdentificationOfASecurity identificationOfASecurityField;

        private CTM_MultiTradeLevelResponseBodyMTLRAdditionalSecurityIdentifiers additionalSecurityIdentifiersField;

        private ulong tradeDateTimeField;

        private CTM_MultiTradeLevelResponseBodyMTLRTimeZone timeZoneField;

        private CTM_MultiTradeLevelResponseBodyMTLRQuantityOfTheBlockTrade quantityOfTheBlockTradeField;

        private CTM_MultiTradeLevelResponseBodyMTLRDealPrice dealPriceField;

        private CTM_MultiTradeLevelResponseBodyMTLRTotalTradeAmount totalTradeAmountField;

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
        public CTM_MultiTradeLevelResponseBodyMTLRInstructingParty InstructingParty
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
        public CTM_MultiTradeLevelResponseBodyMTLRExecutingBroker ExecutingBroker
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
        public CTM_MultiTradeLevelResponseBodyMTLRTradeLevelReferences TradeLevelReferences
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
        public CTM_MultiTradeLevelResponseBodyMTLRMultiTradeLevelStatuses MultiTradeLevelStatuses
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
        public CTM_MultiTradeLevelResponseBodyMTLRIdentificationOfASecurity IdentificationOfASecurity
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
        public CTM_MultiTradeLevelResponseBodyMTLRAdditionalSecurityIdentifiers AdditionalSecurityIdentifiers
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
        public CTM_MultiTradeLevelResponseBodyMTLRTimeZone TimeZone
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
        public CTM_MultiTradeLevelResponseBodyMTLRQuantityOfTheBlockTrade QuantityOfTheBlockTrade
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
        public CTM_MultiTradeLevelResponseBodyMTLRDealPrice DealPrice
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
        public CTM_MultiTradeLevelResponseBodyMTLRTotalTradeAmount TotalTradeAmount
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
