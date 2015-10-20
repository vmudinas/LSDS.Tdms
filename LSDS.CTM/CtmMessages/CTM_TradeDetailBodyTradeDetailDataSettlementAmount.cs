using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    public class CTM_TradeDetailBodyTradeDetailDataSettlementAmount
    {
        [Key]
        public int CtmId { get; set; }
        private string currencyCodeField;

        private double amountField;
        private string sign;

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
        [MaxLength(17)]
        public double Amount
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