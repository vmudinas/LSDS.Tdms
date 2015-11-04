using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    public class CTM_TradeDetailBodyTradeLevelInformationCallPrice
    {

        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int InformationCallPriceCtmId { get; set; }
        private string amount;
        private string currencyCodeField;


        
        public string Amount
        {
            get
            {
                return this.amount;
            }
            set
            {
                this.amount = value;
            }
        }

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

    }
}