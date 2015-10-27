using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    public class CTM_TradeDetailBodyTradeLevelInformationYield
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int CtmId { get; set; }
        private string yieldType;
        private string sign;
        private string amount;

        [MaxLength(4)]
        public string YieldType
        {
            get
            {
                return this.yieldType;
            }
            set
            {
                this.yieldType = value;
            }
        }
        [MaxLength(1)]
        public string Sign
        {
            get
            {
                return this.sign;
            }
            set
            {
                this.sign = value;
            }
        }
     
        public string Amount
        {
            get
            {
                return this.amount;
            }
            set
            {
                this.amount = value;
            }
        }
    }
}