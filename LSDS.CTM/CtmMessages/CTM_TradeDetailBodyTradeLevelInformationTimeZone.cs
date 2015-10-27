using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_TradeDetailBodyTradeLevelInformationTimeZone
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int CtmId { get; set; }
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

    public class CTM_CountryTimeZone
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int CtmId { get; set; }
        private string tradeTimeQualifierField;
        private string countryCode;
        private string timeZoneIndicator;
        [MaxLength(2)]
        public string CountryCode
        {
            get
            {
                return this.countryCode;
            }
            set
            {
                this.countryCode = value;
            }
        }
        [MaxLength(4)]
        public string TradeTimeQualifier
        {
            get
            {
                return this.timeZoneIndicator;
            }
            set
            {
                this.timeZoneIndicator = value;
            }
        }


    }
}