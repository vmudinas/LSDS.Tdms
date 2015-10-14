namespace CTMLibrary.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MessageTradeDetailTradeDetailBodyIPSettlement
    {

        private byte accountIDField;

        /// <remarks/>
        public byte AccountID
        {
            get
            {
                return this.accountIDField;
            }
            set
            {
                this.accountIDField = value;
            }
        }
    }
}