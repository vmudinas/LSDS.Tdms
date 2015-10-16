using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_TradeDetailBodyTradeLevelInformationQuantityOfTheBlockTrade
    {
        [Key]
        public int CtmId { get; set; }
        private string quantityTypeCodeField;

        private string amountField;

        /// <remarks/>
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
                this.amountField = value;
            }
        }
    }
}