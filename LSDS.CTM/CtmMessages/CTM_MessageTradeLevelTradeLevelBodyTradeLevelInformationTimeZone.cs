﻿using System.ComponentModel.DataAnnotations;

namespace CtmProcessor.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MessageTradeLevelTradeLevelBodyTradeLevelInformationTimeZone
    {
        [Key]
        public int CtmId { get; set; }

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