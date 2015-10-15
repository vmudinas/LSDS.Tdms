using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MessageMultiTradeLevelResponseMultiTradeLevelResponseBodyMTLRExecutingBroker
    {
        [Key]
        public int CtmId { get; set; }

        private string partyRoleField;

        private string partyTypeField;

        private string partyValueField;

        private string[] orgNameField;

        /// <remarks/>
        public string PartyRole
        {
            get
            {
                return this.partyRoleField;
            }
            set
            {
                this.partyRoleField = value;
            }
        }

        /// <remarks/>
        public string PartyType
        {
            get
            {
                return this.partyTypeField;
            }
            set
            {
                this.partyTypeField = value;
            }
        }

        /// <remarks/>
        public string PartyValue
        {
            get
            {
                return this.partyValueField;
            }
            set
            {
                this.partyValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OrgName")]
        public string[] OrgName
        {
            get
            {
                return this.orgNameField;
            }
            set
            {
                this.orgNameField = value;
            }
        }
    }
}
