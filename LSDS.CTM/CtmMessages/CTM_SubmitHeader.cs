using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_Header
    {
        [Key]
        public int CtmId { get; set; }
        private string protocolVersionField;

        private CTM_SubmitHeaderOriginatorOfMessage originatorOfMessageField;

        private CTM_SubmitHeaderRecipientOfMessage recipientOfMessageField;

        private string sendersMessageReferenceField;

        private ulong dateTimeOfSentMessageField;

        /// <remarks/>
        public string ProtocolVersion
        {
            get
            {
                return this.protocolVersionField;
            }
            set
            {
                this.protocolVersionField = value;
            }
        }

        /// <remarks/>
        public CTM_SubmitHeaderOriginatorOfMessage OriginatorOfMessage
        {
            get
            {
                return this.originatorOfMessageField;
            }
            set
            {
                this.originatorOfMessageField = value;
            }
        }

        /// <remarks/>
        public CTM_SubmitHeaderRecipientOfMessage RecipientOfMessage
        {
            get
            {
                return this.recipientOfMessageField;
            }
            set
            {
                this.recipientOfMessageField = value;
            }
        }

        /// <remarks/>
        public string SendersMessageReference
        {
            get
            {
                return this.sendersMessageReferenceField;
            }
            set
            {
                this.sendersMessageReferenceField = value;
            }
        }

        /// <remarks/>
        public ulong DateTimeOfSentMessage
        {
            get
            {
                return this.dateTimeOfSentMessageField;
            }
            set
            {
                this.dateTimeOfSentMessageField = value;
            }
        }
    }
}