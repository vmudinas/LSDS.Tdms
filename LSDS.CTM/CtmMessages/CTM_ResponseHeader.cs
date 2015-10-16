using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_ResponseHeader
    {
        [Key]
        public int CtmId { get; set; }
        private string protocolVersionField;

        private CTM_OriginatorOfMessage originatorOfMessageField;

        private CTM_ResponseHeaderRecipientOfMessage recipientOfMessageField;

        private string echoSendersMessageReferenceField;

        private ulong echoDateTimeOfSentMessageField;

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
        public CTM_OriginatorOfMessage OriginatorOfMessage
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
        public CTM_ResponseHeaderRecipientOfMessage RecipientOfMessage
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
        public string EchoSendersMessageReference
        {
            get
            {
                return this.echoSendersMessageReferenceField;
            }
            set
            {
                this.echoSendersMessageReferenceField = value;
            }
        }

        /// <remarks/>
        public ulong EchoDateTimeOfSentMessage
        {
            get
            {
                return this.echoDateTimeOfSentMessageField;
            }
            set
            {
                this.echoDateTimeOfSentMessageField = value;
            }
        }
    }
}