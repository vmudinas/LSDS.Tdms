using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_TradeDetailBodyPartySettlement
    {
        [Key]
        public int CtmId { get; set; }

        private string settlementInstructionsSourceIndicatorField;

        private string alertCountryCodeField;

        private string alertMethodTypeField;

        private string alertSecurityTypeField;

        /// <remarks/>
        public string SettlementInstructionsSourceIndicator
        {
            get
            {
                return this.settlementInstructionsSourceIndicatorField;
            }
            set
            {
                this.settlementInstructionsSourceIndicatorField = value;
            }
        }

        /// <remarks/>
        public string AlertCountryCode
        {
            get
            {
                return this.alertCountryCodeField;
            }
            set
            {
                this.alertCountryCodeField = value;
            }
        }

        /// <remarks/>
        public string AlertMethodType
        {
            get
            {
                return this.alertMethodTypeField;
            }
            set
            {
                this.alertMethodTypeField = value;
            }
        }

        /// <remarks/>
        public string AlertSecurityType
        {
            get
            {
                return this.alertSecurityTypeField;
            }
            set
            {
                this.alertSecurityTypeField = value;
            }
        }
    }
}