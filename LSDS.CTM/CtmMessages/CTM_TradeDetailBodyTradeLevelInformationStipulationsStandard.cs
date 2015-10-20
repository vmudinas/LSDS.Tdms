using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    public class CTM_TradeDetailBodyTradeLevelInformationStipulationsStandard
    {
        public int CtmId { get; set; }
        private string stipulationCodeStandard;
        private CTM_TradeDetailBodyTradeLevelInformationStipulationsStandardStipulationValueStandard stipulationsValueStandard;

        public CTM_TradeDetailBodyTradeLevelInformationStipulationsStandardStipulationValueStandard StipulationValueStandard
        {
            get
            {
                return this.stipulationsValueStandard;
            }
            set
            {
                this.stipulationsValueStandard = value;
            }
        }


        [MaxLength(15)]
        public string StipulationCodeStandard
        {
            get
            {
                return this.stipulationCodeStandard;
            }
            set
            {
                this.stipulationCodeStandard = value;
            }
        }
    }
}