using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace LSDS.CTM.CtmMessages
{
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class CTM_ValidBodyExecutingBroker
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int ValidBodyExecutingBrokerCtmId { get; set; }
        [MaxLength(4)]
        private string partyRoleField;
        [MaxLength(35)]
        private string partyTypeField;
        [MaxLength(11)]
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
    }
}