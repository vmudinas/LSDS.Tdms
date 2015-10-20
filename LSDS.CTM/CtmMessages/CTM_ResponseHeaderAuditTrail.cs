using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    public class CTM_ResponseHeaderAuditTrail
    {

        [Key]   [System.Xml.Serialization.XmlIgnore]
        public int CtmId { get; set; }
        [MaxLength(255)]
        private string _auditReason { get; set; }
        [MaxLength(255)]
        public string AuditReason
        {
            get
            {
                return this._auditReason;
            }
            set
            {
                this._auditReason = value;
            }
        }
    }
}