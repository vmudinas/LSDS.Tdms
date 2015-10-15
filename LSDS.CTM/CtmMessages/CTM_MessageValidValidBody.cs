using System.ComponentModel.DataAnnotations;

namespace CtmProcessor.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MessageValidValidBody
    {
        [Key]
        public int CtmId { get; set; }

        private CTM_MessageValidValidBodyInstructingParty instructingPartyField;

        private CTM_MessageValidValidBodyExecutingBroker executingBrokerField;

        private long echoMasterReferenceField;

        private uint cTMTradeSideIdField;

        /// <remarks/>
        public CTM_MessageValidValidBodyInstructingParty InstructingParty
        {
            get
            {
                return this.instructingPartyField;
            }
            set
            {
                this.instructingPartyField = value;
            }
        }

        /// <remarks/>
        public CTM_MessageValidValidBodyExecutingBroker ExecutingBroker
        {
            get
            {
                return this.executingBrokerField;
            }
            set
            {
                this.executingBrokerField = value;
            }
        }

        /// <remarks/>
        public long EchoMasterReference
        {
            get
            {
                return this.echoMasterReferenceField;
            }
            set
            {
                this.echoMasterReferenceField = value;
            }
        }

        /// <remarks/>
        public uint CTMTradeSideId
        {
            get
            {
                return this.cTMTradeSideIdField;
            }
            set
            {
                this.cTMTradeSideIdField = value;
            }
        }
    }
}