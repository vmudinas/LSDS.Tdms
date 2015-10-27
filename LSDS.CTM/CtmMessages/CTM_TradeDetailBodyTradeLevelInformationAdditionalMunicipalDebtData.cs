using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    public class CTM_TradeDetailBodyTradeLevelInformationAdditionalMunicipalDebtData
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]

        public int CtmId { get; set; }
        private string discountRate;
        private string legalStatus;
        private string paymentIndicator;
        private string muniBondType;
        private string basisIndicator;
        private string bondValuationIndicator;
        private int interestAccrualDate;
        private int interestPaymentDate;
        private string optionCallIndicator;
        private string callPutIndicator;
        private string putBondType;
        private int putBondDate;
        private string putBondPrice;
        private string bondOwnershipIndicator;
        private string interestPaymentFrequency;
        private string couponType;
        private string flatDefaultStatus;
        private string bondTaxStatus;

     
        public string DiscountRate
        {
            get
            {
                return this.discountRate;
            }
            set
            {
                this.discountRate = value;
            }
        }
        [MaxLength(4)]
        public string LegalStatus
        {
            get
            {
                return this.legalStatus;
            }
            set
            {
                this.legalStatus = value;
            }
        }
        [MaxLength(4)]
        public string PaymentIndicator
        {
            get
            {
                return this.paymentIndicator;
            }
            set
            {
                this.paymentIndicator = value;
            }
        }
        [MaxLength(4)]
        public string BasisIndicator
        {
            get
            {
                return this.basisIndicator;
            }
            set
            {
                this.basisIndicator = value;
            }
        }

        [MaxLength(4)]
        public string BondValuationIndicator
        {
            get
            {
                return this.bondValuationIndicator;
            }
            set
            {
                this.bondValuationIndicator = value;
            }
        }

       
        public int InterestAccrualDate
        {
            get
            {
                return this.interestAccrualDate;
            }
            set
            {
                this.interestAccrualDate = value;
            }
        }

       
        public int InterestPaymentDate
        {
            get
            {
                return this.interestPaymentDate;
            }
            set
            {
                this.interestPaymentDate = value;
            }
        }
        [MaxLength(4)]
        public string OptionCallIndicator
        {
            get
            {
                return this.optionCallIndicator;
            }
            set
            {
                this.optionCallIndicator = value;
            }
        }
        
        public string CallPutIndicator
        {
            get
            {
                return this.callPutIndicator;
            }
            set
            {
                this.callPutIndicator = value;
            }
        }

        [MaxLength(4)]
        public string PutBondType
        {
            get
            {
                return this.putBondType;
            }
            set
            {
                this.putBondType = value;
            }
        }

      
        public int PutBondDate
        {
            get
            {
                return this.putBondDate;
            }
            set
            {
                this.putBondDate = value;
            }
        }
        [MaxLength(17)]
        public string PutBondPrice
        {
            get
            {
                return this.putBondPrice;
            }
            set
            {
                this.putBondPrice = value;
            }
        }
        [MaxLength(4)]
        public string BondOwnershipIndicator
        {
            get
            {
                return this.bondOwnershipIndicator;
            }
            set
            {
                this.bondOwnershipIndicator = value;
            }
        }

        [MaxLength(4)]
        public string InterestPaymentFrequency
        {
            get
            {
                return this.interestPaymentFrequency;
            }
            set
            {
                this.interestPaymentFrequency = value;
            }
        }
        [MaxLength(4)]
        public string CouponType
        {
            get
            {
                return this.couponType;
            }
            set
            {
                this.couponType = value;
            }
        }
        [MaxLength(4)]
        public string FlatDefaultStatus
        {
            get
            {
                return this.flatDefaultStatus;
            }
            set
            {
                this.flatDefaultStatus = value;
            }
        }
        [MaxLength(4)]
        public string BondTaxStatus
        {
            get
            {
                return this.bondTaxStatus;
            }
            set
            {
                this.bondTaxStatus = value;
            }
        }

        
    }
}