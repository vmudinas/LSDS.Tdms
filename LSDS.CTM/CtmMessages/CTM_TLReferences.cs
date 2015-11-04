using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    public class CTM_TLReferences
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int TLReferencesCtmId { get; set; }

        private string _tLReferenceType;
        private string _tLReferenceValue;
        [MaxLength(4)]
        public string TLReferenceType
        {
            get
            {
                return this._tLReferenceType;
            }
            set
            {
                this._tLReferenceType = value;
            }
        }
        [MaxLength(16)]
        public string TLReferenceValue
        {
            get
            {
                return this._tLReferenceValue;
            }
            set
            {
                this._tLReferenceValue = value;
            }
        }
    }
}