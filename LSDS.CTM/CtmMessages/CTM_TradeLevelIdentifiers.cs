using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    public partial class CTM_TradeLevelIdentifiers
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int TradeLevelIdentifiersCtmId { get; set; }

        private string masterReferenceField;
        private string _CTMTradeSideId;
        private CTM_TLReferences _TLReferences;
        public CTM_TLReferences TLReferences
        {
            get
            {
                return this._TLReferences;
            }
            set
            {
                this._TLReferences = value;
            }
        }
        [MaxLength(16)]
        public string CTMTradeSideId
        {
            get
            {
                return this._CTMTradeSideId;
            }
            set
            {
                this._CTMTradeSideId = value;
            }
        }
        /// <remarks/>
        /// 
        [MaxLength(16)]
        public string MasterReference
        {
            get
            {
                return this.masterReferenceField;
            }
            set
            {
                this.masterReferenceField = value;
            }
        }
    }
}