using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    public class CTM_TradeDetailBodyTradeDetailDataAdditionalFixedIncome
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int CtmId { get; set; }
        // AccruedInterestAmount
        private CTM_TradeDetailBodyTradeDetailDataAdditionalFixedIncomeAccruedInterestAmount accruedInterestAmount;
        private string originalFaceAmount;
        private string currentFaceValue;

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

        
        public string CurrentFaceValue
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

       
        public string OriginalFaceAmount
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