using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_InfoRequestBodyAccessPath
    {
        [Key]   [System.Xml.Serialization.XmlIgnore]
        public int CtmId { get; set; }
        private string iDOwnerField;

        private CTM_InfoRequestBodyAccessPathTradeLevelIdentifiers tradeLevelIdentifiersField;

        /// <remarks/>
        public string IDOwner
        {
            get
            {
                return this.iDOwnerField;
            }
            set
            {
                this.iDOwnerField = value;
            }
        }

        /// <remarks/>
        public CTM_InfoRequestBodyAccessPathTradeLevelIdentifiers TradeLevelIdentifiers
        {
            get
            {
                return this.tradeLevelIdentifiersField;
            }
            set
            {
                this.tradeLevelIdentifiersField = value;
            }
        }
    }
}