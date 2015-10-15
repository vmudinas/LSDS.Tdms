using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataCommFeesTaxes
    {
        [Key]
        public int CtmId { get; set; }
        private CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataCommFeesTaxesCommissions commissionsField;

        private CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataCommFeesTaxesChargesOrTaxes[] chargesOrTaxesField;

        /// <remarks/>
        public CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataCommFeesTaxesCommissions Commissions
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
        public CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataCommFeesTaxesChargesOrTaxes[] ChargesOrTaxes
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