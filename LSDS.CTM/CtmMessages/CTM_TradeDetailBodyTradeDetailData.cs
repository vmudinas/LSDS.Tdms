using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_TradeDetailBodyTradeDetailData
    {
        [Key]
        public int CtmId { get; set; }
        private CTM_TradeDetailBodyTradeDetailDataTradeAmount tradeAmountField;

        private CTM_TradeDetailBodyTradeDetailDataQuantityAllocated quantityAllocatedField;

        private CTM_TradeDetailBodyTradeDetailDataNetCashAmount netCashAmountField;

        private CTM_TradeDetailBodyTradeDetailDataCommFeesTaxes commFeesTaxesField;

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