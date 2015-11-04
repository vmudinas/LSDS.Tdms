using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MessageValidResponseHeaderRecipientOfMessage
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]

        public int RecipientOfMessageId { get; set; }
        private string partyRoleField;

        private string partyTypeField;

        private string partyValueField;

        /// <remarks/>
        public string PartyRole
        {
            get { return this.partyRoleField; }
            set { this.partyRoleField = value; }
        }

        /// <remarks/>
        public string PartyType
        {
            get { return this.partyTypeField; }
            set { this.partyTypeField = value; }
        }

        /// <remarks/>
        public string PartyValue
        {
            get { return this.partyValueField; }
            set { this.partyValueField = value; }
        }
    }
}