using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_TradeDetailBodyIPSettlement
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int IPSettlementCtmId { get; set; }
        private string accountIDField;

        /// <remarks/>
        [MaxLength(35)]
        public string AccountID
        {
            get
            {
                return this.accountIDField;
            }
            set
            {
                this.accountIDField = value;
            }
        }
    }
}