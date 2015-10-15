using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MessageTradeLevelTradeLevelBodyTradeLevelInformation
    {
        [Key]
        public int CtmId { get; set; }

        private string typeOfTransactionIndicatorField;

        private string buySellIndicatorField;

        private string typeOfFinancialInstrumentField;

        private CTM_MessageTradeLevelTradeLevelBodyTradeLevelInformationDealPrice dealPriceField;

        private CTM_MessageTradeLevelTradeLevelBodyTradeLevelInformationQuantityOfTheBlockTrade quantityOfTheBlockTradeField;

        private CTM_MessageTradeLevelTradeLevelBodyTradeLevelInformationTotalTradeAmount totalTradeAmountField;

        private ulong tradeDateTimeField;

        private CTM_MessageTradeLevelTradeLevelBodyTradeLevelInformationTimeZone timeZoneField;

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
        public CTM_MessageTradeLevelTradeLevelBodyTradeLevelInformationDealPrice DealPrice
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
        public CTM_MessageTradeLevelTradeLevelBodyTradeLevelInformationQuantityOfTheBlockTrade QuantityOfTheBlockTrade
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
        public CTM_MessageTradeLevelTradeLevelBodyTradeLevelInformationTotalTradeAmount TotalTradeAmount
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
        public CTM_MessageTradeLevelTradeLevelBodyTradeLevelInformationTimeZone TimeZone
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