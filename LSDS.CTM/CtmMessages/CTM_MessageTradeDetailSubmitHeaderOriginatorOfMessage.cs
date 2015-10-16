using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MessageTradeDetailSubmitHeaderOriginatorOfMessage
    {
        [Key]
        public int CtmId { get; set; }
        private string partyRoleField;

        private string partyTypeField;

        private string partyValueField;

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
    }
}