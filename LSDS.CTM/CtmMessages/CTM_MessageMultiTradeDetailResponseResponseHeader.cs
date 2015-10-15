using System;
using System.ComponentModel.DataAnnotations;

namespace CtmProcessor
{
    /// <remarks/>
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MessageMultiTradeDetailResponseResponseHeader
    {
        [Key]
        public int CtmId { get; set; }

        private string protocolVersionField;

        private CTM_MessageMultiTradeDetailResponseResponseHeaderOriginatorOfMessage originatorOfMessageField;

        private CTM_MessageMultiTradeDetailResponseResponseHeaderRecipientOfMessage recipientOfMessageField;

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
        public CTM_MessageMultiTradeDetailResponseResponseHeaderOriginatorOfMessage OriginatorOfMessage
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
        public CTM_MessageMultiTradeDetailResponseResponseHeaderRecipientOfMessage RecipientOfMessage
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