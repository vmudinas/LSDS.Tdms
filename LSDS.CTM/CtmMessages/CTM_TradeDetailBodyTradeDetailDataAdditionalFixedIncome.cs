using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    public class CTM_TradeDetailBodyTradeDetailDataAdditionalFixedIncome
    {
        [Key]
        public int CtmId { get; set; }
        // AccruedInterestAmount
        private CTM_TradeDetailBodyTradeDetailDataAdditionalFixedIncomeAccruedInterestAmount accruedInterestAmount;
        private float originalFaceAmount;
        private float currentFaceValue;

        public CTM_TradeDetailBodyTradeDetailDataAdditionalFixedIncomeAccruedInterestAmount AccruedInterestAmount
        {
            get
            {
                return this.accruedInterestAmount;
            }
            set
            {
                this.accruedInterestAmount = value;
            }
        }

        [MaxLength(17)]
        public float CurrentFaceValue
        {
            get
            {
                return this.currentFaceValue;
            }
            set
            {
                this.currentFaceValue = value;
            }
        }

        [MaxLength(17)]
        public float OriginalFaceAmount
        {
            get
            {
                return this.originalFaceAmount;
            }
            set
            {
                this.originalFaceAmount = value;
            }
        }


    }
}