using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_ValidBody
    {
        [Key]
        public int CtmId { get; set; }

        private CTM_ValidBodyInstructingParty instructingPartyField;

        private CTM_ValidBodyExecutingBroker executingBrokerField;

        private long echoMasterReferenceField;

        private uint cTMTradeSideIdField;

        /// <remarks/>
        public CTM_ValidBodyInstructingParty InstructingParty
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
        public CTM_ValidBodyExecutingBroker ExecutingBroker
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