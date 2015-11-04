using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_TradeDetailBodyTradeDetailDataCommFeesTaxes
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int CommFeesTaxesCtmId { get; set; }
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