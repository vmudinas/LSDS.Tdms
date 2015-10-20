using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_TradeDetailBodyTradeDetailData
    {
        [Key]   [System.Xml.Serialization.XmlIgnore]
        public int CtmId { get; set; }
        private string settlementTransactionConditionIndicator;
        private string tradeRegulator;
        private CTM_TradeDetailBodyTradeDetailDataTradeAmount tradeAmountField;
        private CTM_TradeDetailBodyTradeDetailDataQuantityAllocated quantityAllocatedField;
        private CTM_TradeDetailBodyTradeDetailDataNetCashAmount netCashAmountField;
        private CTM_TradeDetailBodyTradeDetailDataCommFeesTaxes commFeesTaxesField;
        private CTM_TradeDetailBodyTradeDetailDataSettlementAmount settlementAmount;
        private CTM_TradeDetailBodyTradeDetailDataExchangeRate exchangeRate;
        private CTM_TradeDetailBodyTradeDetailDataAdditionalFixedIncome additionalFixedIncome;
        private CTM_TradeDetailBodyTradeDetailDataDirectedCommission directedCommission;

        [MaxLength(34)]
        public string TradeRegulator
        {
            get
            {
                return this.tradeRegulator;
            }
            set
            {
                this.tradeRegulator = value;
            }
        }
        public CTM_TradeDetailBodyTradeDetailDataDirectedCommission DirectedCommission
        {
            get
            {
                return this.directedCommission;
            }
            set
            {
                this.directedCommission = value;
            }
        }


        public CTM_TradeDetailBodyTradeDetailDataAdditionalFixedIncome AdditionalFixedIncome
        {
            get
            {
                return this.additionalFixedIncome;
            }
            set
            {
                this.additionalFixedIncome = value;
            }
        }

        public string SettlementTransactionConditionIndicator
        {
            get
            {
                return this.settlementTransactionConditionIndicator;
            }
            set
            {
                this.settlementTransactionConditionIndicator = value;
            }
        }

        public CTM_TradeDetailBodyTradeDetailDataExchangeRate ExchangeRate
        {
            get
            {
                return this.exchangeRate;
            }
            set
            {
                this.exchangeRate = value;
            }
        }

        public CTM_TradeDetailBodyTradeDetailDataSettlementAmount SettlementAmount
        {
            get
            {
                return this.settlementAmount;
            }
            set
            {
                this.settlementAmount = value;
            }
        }
        /// <remarks/>
        public CTM_TradeDetailBodyTradeDetailDataTradeAmount TradeAmount
        {
            get
            {
                return this.tradeAmountField;
            }
            set
            {
                this.tradeAmountField = value;
            }
        }

        /// <remarks/>
        public CTM_TradeDetailBodyTradeDetailDataQuantityAllocated QuantityAllocated
        {
            get
            {
                return this.quantityAllocatedField;
            }
            set
            {
                this.quantityAllocatedField = value;
            }
        }

        /// <remarks/>
        public CTM_TradeDetailBodyTradeDetailDataNetCashAmount NetCashAmount
        {
            get
            {
                return this.netCashAmountField;
            }
            set
            {
                this.netCashAmountField = value;
            }
        }

        /// <remarks/>
        public CTM_TradeDetailBodyTradeDetailDataCommFeesTaxes CommFeesTaxes
        {
            get
            {
                return this.commFeesTaxesField;
            }
            set
            {
                this.commFeesTaxesField = value;
            }
        }
    }
}