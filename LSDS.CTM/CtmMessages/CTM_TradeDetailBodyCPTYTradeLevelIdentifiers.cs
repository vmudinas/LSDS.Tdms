using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    public class CTM_TradeDetailBodyCPTYTradeLevelIdentifiers
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int CtmId { get; set; }
        [MaxLength(16)]
        private string masterReferenceField;

        private string cTMTradeSideIdField;

        /// <remarks/>
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

        /// <remarks/>
        [MaxLength(16)]
        public string CTMTradeSideId
        {
            get
            {
                return this.cTMTradeSideIdField;
            }
            set
            {
                this.cTMTradeSideIdField = value;
            }
        }
    }
}