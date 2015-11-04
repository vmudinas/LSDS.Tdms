using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_TradeDetailBodyIdentificationOfASecuritySecurityCodeType
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int SecurityCodeTypeCtmId { get; set; }
        private string numberingAgencyCodeField;
        private string _countryCode;

        /// <remarks/>
        [MaxLength(4)]
        public string CountryCode
        {
            get
            {
                return this._countryCode;
            }
            set
            {
                this._countryCode = value;
            }
        }
      

        /// <remarks/>
        
        [MaxLength(4)]
        public string NumberingAgencyCode
        {
            get
            {
                return this.numberingAgencyCodeField;
            }
            set
            {
                this.numberingAgencyCodeField = value;
            }
        }
    }
}