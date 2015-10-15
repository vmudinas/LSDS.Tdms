using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MessageTradeLevelTradeLevelBodyIdentificationOfASecuritySecurityCodeType
    {
        [Key]
        public int CtmId { get; set; }
        private string numberingAgencyCodeField;

        /// <remarks/>
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