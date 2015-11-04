using System;
using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MultiTradeLevelResponseBodyMTLR
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int ResponseBodyMTLRCtmId { get; set; }

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

        private CTM_AdditionalSecurityIdentifiers additionalSecurityIdentifiersField;

        private DateTime tradeDateTimeField;

        private CTM_MultiTradeLevelResponseBodyMTLRTimeZone timeZoneField;

        private CTM_MultiTradeLevelResponseBodyMTLRQuantityOfTheBlockTrade quantityOfTheBlockTradeField;

        private CTM_MultiTradeLevelResponseBodyMTLRDealPrice dealPriceField;

        private CTM_MultiTradeLevelResponseBodyMTLRTotalTradeAmount totalTradeAmountField;

        private DateTime settlementDateField;

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
         [MaxLength(4)]  public string BuySellIndicator
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
         [MaxLength(4)] public string TypeOfFinancialInstrument
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
        public CTM_AdditionalSecurityIdentifiers AdditionalSecurityIdentifiers
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
        public DateTime TradeDateTime
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
        public DateTime SettlementDate
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
