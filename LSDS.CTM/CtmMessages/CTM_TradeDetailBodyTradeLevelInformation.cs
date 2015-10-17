using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_TradeDetailBodyTradeLevelInformation
    {
        [Key]
        public int CtmId { get; set; }

        private string typeOfTransactionIndicatorField;

        private string buySellIndicatorField;

        private string typeOfFinancialInstrumentField;

        private CTM_TradeDetailBodyTradeLevelInformationDealPrice dealPriceField;

        private CTM_TradeDetailBodyTradeLevelInformationQuantityOfTheBlockTrade quantityOfTheBlockTradeField;

        private CTM_TradeDetailBodyTradeLevelInformationTotalTradeAmount totalTradeAmountField;

        private ulong tradeDateTimeField;

        private CTM_TradeDetailBodyTradeLevelInformationTimeZone timeZoneField;

        private uint settlementDateField;
        private string typeOfPriceIndicator;
        
        private string bestExecution;
        private string lotSize;
        [MaxLength(15)]
        public string LotSize
        {
            get
            {
                return this.lotSize;
            }
            set
            {
                this.lotSize = value;
            }
        }
        [MaxLength(4)]
        public string BestExecution
        {
            get
            {
                return this.bestExecution;
            }
            set
            {
                this.bestExecution = value;
            }
        }
        /// <remarks/>
        [MaxLength(4)]
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
        [MaxLength(4)]
        public string TypeOfPriceIndicator
        {
            get
            {
                return this.typeOfPriceIndicator;
            }
            set
            {
                this.typeOfPriceIndicator = value;
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
        public CTM_TradeDetailBodyTradeLevelInformationDealPrice DealPrice
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
        public CTM_TradeDetailBodyTradeLevelInformationQuantityOfTheBlockTrade QuantityOfTheBlockTrade
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
        public CTM_TradeDetailBodyTradeLevelInformationTotalTradeAmount TotalTradeAmount
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
        public CTM_TradeDetailBodyTradeLevelInformationTimeZone TimeZone
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