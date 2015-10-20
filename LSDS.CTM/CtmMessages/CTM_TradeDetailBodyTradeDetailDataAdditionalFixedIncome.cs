﻿using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    public class CTM_TradeDetailBodyTradeDetailDataAdditionalFixedIncome
    {
        [Key]   [System.Xml.Serialization.XmlIgnore]
        public int CtmId { get; set; }
        // AccruedInterestAmount
        private CTM_TradeDetailBodyTradeDetailDataAdditionalFixedIncomeAccruedInterestAmount accruedInterestAmount;
        private double originalFaceAmount;
        private double currentFaceValue;

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

        
        public double CurrentFaceValue
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

       
        public double OriginalFaceAmount
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