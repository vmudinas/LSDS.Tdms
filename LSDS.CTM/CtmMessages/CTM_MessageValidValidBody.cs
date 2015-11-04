using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MessageValidValidBody
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]

        public int ValidBodyId { get; set; }
        private CTM_MessageValidValidBodyInstructingParty instructingPartyField;

        private CTM_MessageValidValidBodyExecutingBroker executingBrokerField;

        private string echoMasterReferenceField;

        private uint cTMTradeSideIdField;

        private string echoClientAllocationReferenceField;

        private uint cTMTradeDetailIDField;

        /// <remarks/>
        public CTM_MessageValidValidBodyInstructingParty InstructingParty
        {
            get { return this.instructingPartyField; }
            set { this.instructingPartyField = value; }
        }

        /// <remarks/>
        public CTM_MessageValidValidBodyExecutingBroker ExecutingBroker
        {
            get { return this.executingBrokerField; }
            set { this.executingBrokerField = value; }
        }

        /// <remarks/>
        public string EchoMasterReference
        {
            get { return this.echoMasterReferenceField; }
            set { this.echoMasterReferenceField = value; }
        }

        /// <remarks/>
        public uint CTMTradeSideId
        {
            get { return this.cTMTradeSideIdField; }
            set { this.cTMTradeSideIdField = value; }
        }

        /// <remarks/>
        public string EchoClientAllocationReference
        {
            get { return this.echoClientAllocationReferenceField; }
            set { this.echoClientAllocationReferenceField = value; }
        }

        /// <remarks/>
        public uint CTMTradeDetailID
        {
            get { return this.cTMTradeDetailIDField; }
            set { this.cTMTradeDetailIDField = value; }
        }
    }
}