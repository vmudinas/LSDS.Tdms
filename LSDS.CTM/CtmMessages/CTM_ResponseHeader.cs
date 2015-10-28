using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_ResponseHeader
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int CtmId { get; set; }
        [MaxLength(4)]
        private string protocolVersionField;

        private CTM_OriginatorOfMessage originatorOfMessageField;

        private CTM_RecipientOfMessage recipientOfMessageField;
        private CTM_ResponseHeaderAuditTrail auditTrail;
        private CTM_ResponseHeaderAuditEvent auditEvent;
        [MaxLength(16)]
        private string echoSendersMessageReferenceField;
        [MaxLength(32)]
        private string echoUserId;
        private DateTime echoDateTimeOfSentMessageField;

        public CTM_ResponseHeaderAuditTrail AuditTrail
        {
            get
            {
                return this.auditTrail;
            }
            set
            {
                this.auditTrail = value;
            }
        }
        public CTM_ResponseHeaderAuditEvent AuditEvent
        {
            get
            {
                return this.auditEvent;
            }
            set
            {
                this.auditEvent = value;
            }
        }
        [MaxLength(32)]
        public string EchoUserId
        {
            get
            {
                return this.echoUserId;
            }
            set
            {
                this.echoUserId = value;
            }
        }

        /// <remarks/>
        [MaxLength(4)]
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
        [System.Xml.Serialization.XmlIgnore]
        public DateTime EchoDateTimeOfSentMsg
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
       
        [NotMapped]
        public ulong EchoDateTimeOfSentMessage
        {
            get
            {
                return ulong.Parse(EchoDateTimeOfSentMsg.ToString("yyyyMMddHHmmss"));
            }
            set
            {
                this.echoDateTimeOfSentMessageField = DateTime.ParseExact(value.ToString(), "yyyyMMddHHmmss", CultureInfo.InvariantCulture);

            }
        }
    }
}