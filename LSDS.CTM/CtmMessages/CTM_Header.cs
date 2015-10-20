using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_Header
    {
        [Key]   [System.Xml.Serialization.XmlIgnore]
        public int CtmId { get; set; }
        [MaxLength(4)]
        private string protocolVersionField;

        private CTM_OriginatorOfMessage originatorOfMessageField;

        private CTM_RecipientOfMessage recipientOfMessageField;

        private string sendersMessageReferenceField;

        private ulong dateTimeOfSentMessageField;
        [MaxLength(32)]
        private string userId;
        /// <remarks/>
        /// 
        [MaxLength(32)]
        public string UserId
        {
            get
            {
                return this.userId;
            }
            set
            {
                this.userId = value;
            }
        }
        [MaxLength(4)]   public string ProtocolVersion
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
        public CTM_RecipientOfMessage RecipientOfMessage
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
        [MaxLength(16)]
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