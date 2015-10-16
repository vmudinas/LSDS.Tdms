using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_TradeDetailBodyTradeDetailDataCommFeesTaxes
    {
        [Key]
        public int CtmId { get; set; }
        private CTM_TradeDetailBodyTradeDetailDataCommFeesTaxesCommissions commissionsField;

        private CTM_TradeDetailBodyTradeDetailDataCommFeesTaxesChargesOrTaxes[] chargesOrTaxesField;

        /// <remarks/>
        public CTM_TradeDetailBodyTradeDetailDataCommFeesTaxesCommissions Commissions
        {
            get
            {
                return this.commissionsField;
            }
            set
            {
                this.commissionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ChargesOrTaxes")]
        public CTM_TradeDetailBodyTradeDetailDataCommFeesTaxesChargesOrTaxes[] ChargesOrTaxes
        {
            get
            {
                return this.chargesOrTaxesField;
            }
            set
            {
                this.chargesOrTaxesField = value;
            }
        }
    }
}