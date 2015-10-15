using System.ComponentModel.DataAnnotations;

namespace CtmProcessor.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MessageTradeDetailTradeDetailBodyTradeDetailData
    {
        [Key]
        public int CtmId { get; set; }
        private CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataTradeAmount tradeAmountField;

        private CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataQuantityAllocated quantityAllocatedField;

        private CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataNetCashAmount netCashAmountField;

        private CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataCommFeesTaxes commFeesTaxesField;

        /// <remarks/>
        public CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataTradeAmount TradeAmount
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
        public CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataQuantityAllocated QuantityAllocated
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
        public CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataNetCashAmount NetCashAmount
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
        public CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataCommFeesTaxes CommFeesTaxes
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