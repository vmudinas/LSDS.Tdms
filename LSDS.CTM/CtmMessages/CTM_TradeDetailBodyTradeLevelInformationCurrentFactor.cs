using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    public class CTM_TradeDetailBodyTradeLevelInformationCurrentFactor
    {
        [Key]   [System.Xml.Serialization.XmlIgnore]
        public int CtmId { get; set; }
        private string signField;
        private string amountField;

        /// <remarks/>
        [MaxLength(1)]
        public string Sign
        {
            get
            {
                return this.signField;
            }
            set
            {
                this.signField = value;
            }
        }

        /// <remarks/>
       
        public string Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }
}