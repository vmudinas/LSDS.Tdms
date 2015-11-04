using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    public class CTM_CountryTimeZone
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int CountryTimeZoneCtmId { get; set; }
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