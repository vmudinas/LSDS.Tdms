using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    public class CTM_TradeDetailBodyTradeDetailDataAdditionalFixedIncomeAccruedInterestAmount
    {

        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int InterestAmountCtmId { get; set; }
        private string currencyCodeField;
        private string sign;
        private string amountField;


        [MaxLength(1)]
        public string Sign
        {
            get
            {
                return this.sign;
            }
            set
            {
                this.sign = value;
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