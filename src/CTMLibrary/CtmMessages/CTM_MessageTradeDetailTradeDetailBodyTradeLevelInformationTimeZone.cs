﻿namespace CTMLibrary.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MessageTradeDetailTradeDetailBodyTradeLevelInformationTimeZone
    {

        private string tradeTimeQualifierField;

        /// <remarks/>
        public string TradeTimeQualifier
        {
            get
            {
                return this.tradeTimeQualifierField;
            }
            set
            {
                this.tradeTimeQualifierField = value;
            }
        }
    }
}