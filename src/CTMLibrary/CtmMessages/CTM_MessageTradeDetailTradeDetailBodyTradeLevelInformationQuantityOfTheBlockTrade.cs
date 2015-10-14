namespace CTMLibrary.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MessageTradeDetailTradeDetailBodyTradeLevelInformationQuantityOfTheBlockTrade
    {

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