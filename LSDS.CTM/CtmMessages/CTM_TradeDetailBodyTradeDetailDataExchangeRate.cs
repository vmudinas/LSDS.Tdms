using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    public class CTM_TradeDetailBodyTradeDetailDataExchangeRate
    {

        [Key]
        public int CtmId { get; set; }
        private string fromCurrency;
        private string toCurrency;
        private double exchangeRateAmount;


       
        public double ExchangeRateAmount
        {
            get
            {
                return this.exchangeRateAmount;
            }
            set
            {
                this.exchangeRateAmount = value;
            }
        }

        [MaxLength(3)]
        public string ToCurrency
        {
            get
            {
                return this.toCurrency;
            }
            set
            {
                this.toCurrency = value;
            }
        }
        [MaxLength(3)]
        public string FromCurrency
        {
            get
            {
                return this.fromCurrency;
            }
            set
            {
                this.fromCurrency = value;
            }
        }


    }
}