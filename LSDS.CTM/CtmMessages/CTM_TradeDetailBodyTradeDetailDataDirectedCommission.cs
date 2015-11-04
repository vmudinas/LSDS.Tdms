using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    public class CTM_TradeDetailBodyTradeDetailDataDirectedCommission
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int CommissionCtmId { get; set; }
        private string commissionSharingTypeIndicator;
        private CTM_TradeDetailBodyTradeDetailDataDirectedCommissionBeneficiaryofCommissions beneficiaryofCommissions;

        public CTM_TradeDetailBodyTradeDetailDataDirectedCommissionBeneficiaryofCommissions BeneficiaryofCommissions
        {
            get
            {
                return this.beneficiaryofCommissions;
            }
            set
            {
                this.beneficiaryofCommissions = value;
            }
        }

        [MaxLength(4)]
        public string CommissionSharingTypeIndicator
        {
            get
            {
                return this.commissionSharingTypeIndicator;
            }
            set
            {
                this.commissionSharingTypeIndicator = value;
            }
        }

    }
}