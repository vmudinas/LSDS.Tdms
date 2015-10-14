namespace CTMLibrary.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MessageTradeDetailTradeDetailBodyTradeLevelInformation
    {

        private string typeOfTransactionIndicatorField;

        private string buySellIndicatorField;

        private string typeOfFinancialInstrumentField;

        private CTM_MessageTradeDetailTradeDetailBodyTradeLevelInformationDealPrice dealPriceField;

        private CTM_MessageTradeDetailTradeDetailBodyTradeLevelInformationQuantityOfTheBlockTrade quantityOfTheBlockTradeField;

        private CTM_MessageTradeDetailTradeDetailBodyTradeLevelInformationTotalTradeAmount totalTradeAmountField;

        private ulong tradeDateTimeField;

        private CTM_MessageTradeDetailTradeDetailBodyTradeLevelInformationTimeZone timeZoneField;

        private uint settlementDateField;

        /// <remarks/>
        public string TypeOfTransactionIndicator
        {
            get
            {
                return this.typeOfTransactionIndicatorField;
            }
            set
            {
                this.typeOfTransactionIndicatorField = value;
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
        public CTM_MessageTradeDetailTradeDetailBodyTradeLevelInformationDealPrice DealPrice
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
        public CTM_MessageTradeDetailTradeDetailBodyTradeLevelInformationQuantityOfTheBlockTrade QuantityOfTheBlockTrade
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
        public CTM_MessageTradeDetailTradeDetailBodyTradeLevelInformationTotalTradeAmount TotalTradeAmount
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
        public CTM_MessageTradeDetailTradeDetailBodyTradeLevelInformationTimeZone TimeZone
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