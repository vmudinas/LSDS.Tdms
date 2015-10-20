using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    public class CTM_TradeDetailBodyTradeDetailDataDirectedCommissionBeneficiaryofCommissions
    {
        [Key]   [System.Xml.Serialization.XmlIgnore]
        public int CtmId { get; set; }
        private string clearingSystemID;
        private string partyFundName;
        private CTM_TradeDetailBodyTradeDetailDataDirectedCommissionBeneficiaryofCommissionsBrokerOfCredit brokerOfCredit;

        public CTM_TradeDetailBodyTradeDetailDataDirectedCommissionBeneficiaryofCommissionsBrokerOfCredit BrokerOfCredit
        {
            get
            {
                return this.brokerOfCredit;
            }
            set
            {
                this.brokerOfCredit = value;
            }
        }

        [MaxLength(35)]
        public string ClearingSystemID
        {
            get
            {
                return this.clearingSystemID;
            }
            set
            {
                this.clearingSystemID = value;
            }
        }
        [MaxLength(35)]
        public string PartyFundName
        {
            get
            {
                return this.partyFundName;
            }
            set
            {
                this.partyFundName = value;
            }
        }
    }
}