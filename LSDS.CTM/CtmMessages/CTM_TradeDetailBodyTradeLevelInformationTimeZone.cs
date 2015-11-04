using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_TradeDetailBodyTradeLevelInformationTimeZone
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int TradeLevelInformationTimeZoneCtmId { get; set; }
        private string tradeTimeQualifierField;
        private CTM_CountryTimeZone countryTimeZone;
        /// <remarks/>
        public CTM_CountryTimeZone CountryTimeZone
        {
            get
            {
                return this.countryTimeZone;
            }
            set
            {
                this.countryTimeZone = value;
            }
        }
        [MaxLength(4)]
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