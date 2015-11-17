using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_ValidBody
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]

        public int ValidBodyId { get; set; }
        private CTM_ValidBodyInstructingParty instructingPartyField;

        private CTM_ValidBodyExecutingBroker executingBrokerField;

        private string echoMasterReferenceField;

        private string cTMTradeSideIdField;

        private string echoClientAllocationReferenceField;

        private string cTMTradeDetailIDField;

        /// <remarks/>
        public CTM_ValidBodyInstructingParty InstructingParty
        {
            get { return this.instructingPartyField; }
            set { this.instructingPartyField = value; }
        }

        /// <remarks/>
        public CTM_ValidBodyExecutingBroker ExecutingBroker
        {
            get { return this.executingBrokerField; }
            set { this.executingBrokerField = value; }
        }

        /// <remarks/>
        [MaxLength(16)]
        public string EchoMasterReference
        {
            get { return this.echoMasterReferenceField; }
            set { this.echoMasterReferenceField = value; }
        }

        /// <remarks/>
        [MaxLength(16)]
        public string CTMTradeSideId
        {
            get { return this.cTMTradeSideIdField; }
            set { this.cTMTradeSideIdField = value; }
        }

        /// <remarks/>
        [MaxLength(16)]
        public string EchoClientAllocationReference
        {
            get { return this.echoClientAllocationReferenceField; }
            set { this.echoClientAllocationReferenceField = value; }
        }

        /// <remarks/>
        [MaxLength(16)]
        public string CTMTradeDetailID
        {
            get { return this.cTMTradeDetailIDField; }
            set { this.cTMTradeDetailIDField = value; }
        }
    }
}