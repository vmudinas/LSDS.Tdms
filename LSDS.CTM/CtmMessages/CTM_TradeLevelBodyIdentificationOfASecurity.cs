using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_TradeLevelBodyIdentificationOfASecurity
    {
        [Key]
        public int CtmId { get; set; }
        private CTM_TradeLevelBodyIdentificationOfASecuritySecurityCodeType securityCodeTypeField;

        private uint securityCodeField;

        /// <remarks/>
        public CTM_TradeLevelBodyIdentificationOfASecuritySecurityCodeType SecurityCodeType
        {
            get
            {
                return this.securityCodeTypeField;
            }
            set
            {
                this.securityCodeTypeField = value;
            }
        }

        /// <remarks/>
        public uint SecurityCode
        {
            get
            {
                return this.securityCodeField;
            }
            set
            {
                this.securityCodeField = value;
            }
        }
    }
}