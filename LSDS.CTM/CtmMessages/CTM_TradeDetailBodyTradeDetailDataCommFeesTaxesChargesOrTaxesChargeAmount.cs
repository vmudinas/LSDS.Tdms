using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_TradeDetailBodyTradeDetailDataCommFeesTaxesChargesOrTaxesChargeAmount
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int ChargeAmountCtmId { get; set; }
        private string signField;

        private string currencyCodeField;

        private string amountField;

        /// <remarks/>
        [MaxLength(1)]
        public string Sign
        {
            get
            {
                return this.signField;
            }
            set
            {
                this.signField = value;
            }
        }

        /// <remarks/>
         [MaxLength(3)]
        public string CurrencyCode
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
       
        public string Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                if (value.Contains("."))
                {
                    this.amountField = value.TrimEnd().Replace(".", ",");
                }
                else if (value.Contains(","))
                {
                    this.amountField = value;
                }
                else
                {
                    this.amountField = value + ",";
                }

            }
        }
    }
}