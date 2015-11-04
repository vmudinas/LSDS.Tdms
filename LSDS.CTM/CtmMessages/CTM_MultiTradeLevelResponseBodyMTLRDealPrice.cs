using System;
using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MultiTradeLevelResponseBodyMTLRDealPrice
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int DealPriceCtmId { get; set; }
        private string currencyCodeField;

        private string amountField;

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
         public string Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                if (value.Contains("."))
                {
                    this.amountField = value.TrimEnd().Replace(".", ",");
                }
                else if (value.Contains(","))
                {
                    this.amountField = value;
                }
                else
                {
                    this.amountField = value + ",";
                }

            }
        }
    }
}
