using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_TradeLevelBodyTradeLevelReferences
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int ReferencesCtmId { get; set; }
        [MaxLength(16)]
        private string _masterReferenceField;

        /// <remarks/>
         [MaxLength(16)]
        public string MasterReference
        {
            get
            {
                return this._masterReferenceField;
            }
            set
            {
                this._masterReferenceField = value;
            }
        }
    }
}