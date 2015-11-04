using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    public class CTM_ResponseHeaderAuditEvent
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int AuditEventCtmId { get; set; }

        private string _auditReason;
        private int _auditEventDepth;
        private string _auditEventTag;
        private string _auditEventName;
        private string _auditEventArg;
        private int _auditEventStart;
        private int _auditEventEnd;
        private int _auditEventExclIMs;

        
       public int AuditEventDepth
        {
            get
            {
                return this._auditEventDepth;
            }
            set
            {
                this._auditEventDepth = value;
            }
        }
        [MaxLength(255)]
        public string AuditEventTag
        {
            get
            {
                return this._auditEventTag;
            }
            set
            {
                this._auditEventTag = value;
            }
        }
        [MaxLength(255)]
        public string AuditEventName
        {
            get
            {
                return this._auditEventName;
            }
            set
            {
                this._auditEventName = value;
            }
        }
        [MaxLength(255)]
        public string AuditEventArg
        {
            get
            {
                return this._auditEventArg;
            }
            set
            {
                this._auditEventArg = value;
            }
        }
       
        public int AuditEventStart
        {
            get
            {
                return this._auditEventStart;
            }
            set
            {
                this._auditEventStart = value;
            }
        }                        
            
            public int AuditEventEnd
        {
            get
            {
                return this._auditEventEnd;
            }
            set
            {
                this._auditEventEnd = value;
            }
        }
       
        public int AuditEventInclMs
        {
            get
            {
                return this._auditEventDepth;
            }
            set
            {
                this._auditEventDepth = value;
            }
        }                       
         
            public int AuditEventExclIMs
        {
            get
            {
                return this._auditEventExclIMs;
            }
            set
            {
                this._auditEventExclIMs = value;
            }
        }                   
      

    }
}