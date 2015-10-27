using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_TradeLevel
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int CtmId { get; set; }
        private CTM_Header submitHeaderField;

        private CTM_TradeLevelBody tradeLevelBodyField;

        /// <remarks/>
        public CTM_Header SubmitHeader
        {
            get
            {
                return this.submitHeaderField;
            }
            set
            {
                this.submitHeaderField = value;
            }
        }

        /// <remarks/>
        public CTM_TradeLevelBody TradeLevelBody
        {
            get
            {
                return this.tradeLevelBodyField;
            }
            set
            {
                this.tradeLevelBodyField = value;
            }
        }
    }
}