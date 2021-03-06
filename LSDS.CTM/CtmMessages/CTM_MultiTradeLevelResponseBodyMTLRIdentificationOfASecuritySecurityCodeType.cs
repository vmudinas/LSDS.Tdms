using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MultiTradeLevelResponseBodyMTLRIdentificationOfASecuritySecurityCodeType
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int MTLRIdentificationOfASecuritySecurityCodeTypeCtmId { get; set; }

        private string numberingAgencyCodeField;

        /// <remarks/>
        [MaxLength(4)]   public string NumberingAgencyCode
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
