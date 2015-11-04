using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_TradeLevelBodyIdentificationOfASecuritySecurityCodeType
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int SecurityCodeTypeCtmId { get; set; }
        private string numberingAgencyCodeField;

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