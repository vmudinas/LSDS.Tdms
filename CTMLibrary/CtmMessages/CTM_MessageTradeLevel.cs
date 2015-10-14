namespace CTMLibrary.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MessageTradeLevel
    {

        private CTM_MessageTradeLevelSubmitHeader submitHeaderField;

        private CTM_MessageTradeLevelTradeLevelBody tradeLevelBodyField;

        /// <remarks/>
        public CTM_MessageTradeLevelSubmitHeader SubmitHeader
        {
            get
            {
                return this.submitHeaderField;
            }
            set
            {
                this.submitHeaderField = value;
            }
        }

        /// <remarks/>
        public CTM_MessageTradeLevelTradeLevelBody TradeLevelBody
        {
            get
            {
                return this.tradeLevelBodyField;
            }
            set
            {
                this.tradeLevelBodyField = value;
            }
        }
    }
}