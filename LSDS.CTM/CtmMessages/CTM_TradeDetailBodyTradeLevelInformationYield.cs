using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    public class CTM_TradeDetailBodyTradeLevelInformationYield
    {
        private string yieldType;
        private string sign;
        private double amount;

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
        [MaxLength(17)]
        public double Amount
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