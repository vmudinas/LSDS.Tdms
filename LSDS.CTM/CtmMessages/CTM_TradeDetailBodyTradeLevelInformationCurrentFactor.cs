using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    public class CTM_TradeDetailBodyTradeLevelInformationCurrentFactor
    {
        [Key]
        public int CtmId { get; set; }
        private string signField;
        private double amountField;

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
        [MaxLength(17)]
        public double Amount
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