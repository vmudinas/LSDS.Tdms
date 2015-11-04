using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_TradeLevelBodyTradeLevelInformationQuantityOfTheBlockTrade
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int QuantityOfTheBlockTradeCtmId { get; set; }
        private string quantityTypeCodeField;

        private string amountField;

        /// <remarks/>
        [MaxLength(4)]
        public string QuantityTypeCode
        {
            get
            {
                return this.quantityTypeCodeField;
            }
            set
            {
                this.quantityTypeCodeField = value;
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