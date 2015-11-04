using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_TradeLevelBodyTradeLevelInformation
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
       
        public int InformationCtmId { get; set; }

        private string typeOfTransactionIndicatorField;

        private string buySellIndicatorField;

        private string typeOfFinancialInstrumentField;
       
        private CTM_TradeLevelBodyTradeLevelInformationDealPrice dealPriceField;

        private CTM_TradeLevelBodyTradeLevelInformationQuantityOfTheBlockTrade quantityOfTheBlockTradeField;

        private CTM_TradeLevelBodyTradeLevelInformationTotalTradeAmount totalTradeAmountField;

        private DateTime tradeDateTimeField;

        private CTM_TradeLevelBodyTradeLevelInformationTimeZone timeZoneField;

        private DateTime settlementDateField;

        /// <remarks/>
         [MaxLength(4)]   public string TypeOfTransactionIndicator
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
         [MaxLength(4)]
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
         [MaxLength(4)]
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
        public CTM_TradeLevelBodyTradeLevelInformationDealPrice DealPrice
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
        public CTM_TradeLevelBodyTradeLevelInformationQuantityOfTheBlockTrade QuantityOfTheBlockTrade
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
        public CTM_TradeLevelBodyTradeLevelInformationTotalTradeAmount TotalTradeAmount
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
        [System.Xml.Serialization.XmlIgnore]
        public DateTime TradeDT
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
        [NotMapped]
        public ulong TradeDateTime
        {
            get
            {
                return ulong.Parse(TradeDT.ToString("yyyyMMddHHmmss"));
            }
            set
            {
                this.tradeDateTimeField = DateTime.ParseExact(value.ToString(), "yyyyMMddHHmmss", CultureInfo.InvariantCulture);

            }
        }

        /// <remarks/>
        public CTM_TradeLevelBodyTradeLevelInformationTimeZone TimeZone
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
        [System.Xml.Serialization.XmlIgnore]
        public DateTime SettlementDt
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
        [NotMapped]
        public uint SettlementDate
        {
            get
            {
                return uint.Parse(SettlementDt.ToString("yyyyMMdd"));
            }
            set
            {
                this.settlementDateField = DateTime.ParseExact(value.ToString(), "yyyyMMdd", CultureInfo.InvariantCulture);

            }
        }
    }
}