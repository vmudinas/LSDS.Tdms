﻿using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_TradeLevelBodyTradeLevelInformationDealPrice
    {
        [Key]   [System.Xml.Serialization.XmlIgnore]
        public int CtmId { get; set; }
        private string currencyCodeField;

        private double amountField;

        /// <remarks/>
         [MaxLength(3)] public string CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }

        /// <remarks/>
         public double Amount
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