using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MultiTradeLevelResponseBodyMTLRExecutingBroker
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int MTLRExecutingBrokerCtmId { get; set; }
        [MaxLength(4)]
        private string partyRoleField;
        [MaxLength(35)]
        private string partyTypeField;
        [MaxLength(11)]
        private string partyValueField;

         [MaxLength(35)]  private string[] 
            orgNameField;

        /// <remarks/>
        [MaxLength(4)]
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
        [MaxLength(35)]
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
        [MaxLength(11)]
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
        [MaxLength(35)]  public string[] OrgName
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
