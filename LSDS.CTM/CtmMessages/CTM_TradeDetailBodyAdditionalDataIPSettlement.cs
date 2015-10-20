using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    public class CTM_TradeDetailBodyAdditionalDataIPSettlement
    {
        [Key]
        public int CtmId { get; set; }
        private string accountID;


        [MaxLength(35)]
        public string AccountID
        {
            get
            {
                return this.accountID;
            }
            set
            {
                this.accountID = value;
            }
        }

    }
}