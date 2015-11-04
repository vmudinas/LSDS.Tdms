using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_Header
    {
        public CTM_Header() 
        {
            OriginatorOfMessage = new CTM_OriginatorOfMessage();
            RecipientOfMessage = new CTM_RecipientOfMessage();
   
        }

        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int HeaderCtmId { get; set; }
        [MaxLength(4)]
        private string protocolVersionField;

        private CTM_OriginatorOfMessage originatorOfMessageField;

        private CTM_RecipientOfMessage recipientOfMessageField;

        private string sendersMessageReferenceField;

        private DateTime dateTimeOfSentMessageField;
        [MaxLength(32)]
        private string userId;
        /// <remarks/>
        /// 
        
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
        [System.Xml.Serialization.XmlIgnore]
        public DateTime DateTimeOfSentMsg
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
        [NotMapped]
        public ulong DateTimeOfSentMessage
        {
            get
            {
                return ulong.Parse(DateTimeOfSentMsg.ToString("yyyyMMddHHmmss")); 
            }
            set
            {
                this.dateTimeOfSentMessageField = DateTime.ParseExact(value.ToString(), "yyyyMMddHHmmss",CultureInfo.InvariantCulture);
                
            }
        }
    }
}