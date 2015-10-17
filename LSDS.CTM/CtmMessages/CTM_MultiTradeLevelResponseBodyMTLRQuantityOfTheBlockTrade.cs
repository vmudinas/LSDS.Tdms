using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MultiTradeLevelResponseBodyMTLRQuantityOfTheBlockTrade
    {
        [Key]
        public int CtmId { get; set; }
        private string quantityTypeCodeField;

        private double amountField;

        /// <remarks/>
        [MaxLength(4)] public string QuantityTypeCode
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
