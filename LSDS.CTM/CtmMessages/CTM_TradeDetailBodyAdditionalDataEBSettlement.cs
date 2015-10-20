using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    public class CTM_TradeDetailBodyAdditionalDataEBSettlement
    {
        [Key]   [System.Xml.Serialization.XmlIgnore]
        public int CtmId { get; set; }
        private string accountReference;
        private string accountID;

        [MaxLength(35)]
        public string AccountReference
        {
            get
            {
                return this.accountReference;
            }
            set
            {
                this.accountReference = value;
            }
        }
        [MaxLength(35)]
        public string AccountID
        {
            get
            {
                return this.accountID;
            }
            set
            {
                this.accountID = value;
            }
        }

    }
}