using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_TradeDetailBodyTradeDetailDataNetCashAmount
    {
        [Key]
        public int CtmId { get; set; }
        private string currencyCodeField;

        private double amountField;

        /// <remarks/>
         [MaxLength(3)] public string CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }

        /// <remarks/>
         [MaxLength(17)] public double Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }
}