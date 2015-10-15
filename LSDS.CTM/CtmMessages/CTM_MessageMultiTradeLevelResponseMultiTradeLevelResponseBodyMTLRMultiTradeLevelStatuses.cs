using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MessageMultiTradeLevelResponseMultiTradeLevelResponseBodyMTLRMultiTradeLevelStatuses
    {
        [Key]
        public int CtmId { get; set; }

        private string tLMatchStatusField;

        private string completeStatusField;

        private string matchAgreedStatusField;

        /// <remarks/>
        public string TLMatchStatus
        {
            get
            {
                return this.tLMatchStatusField;
            }
            set
            {
                this.tLMatchStatusField = value;
            }
        }

        /// <remarks/>
        public string CompleteStatus
        {
            get
            {
                return this.completeStatusField;
            }
            set
            {
                this.completeStatusField = value;
            }
        }

        /// <remarks/>
        public string MatchAgreedStatus
        {
            get
            {
                return this.matchAgreedStatusField;
            }
            set
            {
                this.matchAgreedStatusField = value;
            }
        }
    }
}
