namespace CTMLibrary.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataCommFeesTaxesChargesOrTaxes
    {

        private string chargeTaxTypeField;

        private CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataCommFeesTaxesChargesOrTaxesChargeAmount chargeAmountField;

        /// <remarks/>
        public string ChargeTaxType
        {
            get
            {
                return this.chargeTaxTypeField;
            }
            set
            {
                this.chargeTaxTypeField = value;
            }
        }

        /// <remarks/>
        public CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataCommFeesTaxesChargesOrTaxesChargeAmount ChargeAmount
        {
            get
            {
                return this.chargeAmountField;
            }
            set
            {
                this.chargeAmountField = value;
            }
        }
    }
}