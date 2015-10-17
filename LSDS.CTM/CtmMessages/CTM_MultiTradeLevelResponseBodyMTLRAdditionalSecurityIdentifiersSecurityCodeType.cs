using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_AdditionalSecurityIdentifiersSecurityCodeType
    {
        [Key]
        public int CtmId { get; set; }
        private string numberingAgencyCodeField;
        private string countrCode;
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
        [MaxLength(30)]
        public string CountryCode
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