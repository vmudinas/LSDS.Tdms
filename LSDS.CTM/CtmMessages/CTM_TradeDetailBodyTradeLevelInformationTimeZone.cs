﻿using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_TradeDetailBodyTradeLevelInformationTimeZone
    {
        [Key]
        public int CtmId { get; set; }
        private string tradeTimeQualifierField;

        /// <remarks/>
        [MaxLength(4)] public string TradeTimeQualifier
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