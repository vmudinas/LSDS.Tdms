using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    public class CTM_TradeDetailBodyTradeLevelInformationStipulationsNonStandard
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int StipulationsNonStandardCtmId { get; set; }
        private string stipulationCodeNonStandard;
        private string stipulationValueNonStandard;

        [MaxLength(15)]
        public string StipulationCodeNonStandard
        {
            get
            {
                return this.stipulationCodeNonStandard;
            }
            set
            {
                this.stipulationCodeNonStandard = value;
            }
        }
        [MaxLength(35)]
        public string StipulationValueNonStandard
        {
            get
            {
                return this.stipulationValueNonStandard;
            }
            set
            {
                this.stipulationValueNonStandard = value;
            }
        }
    }
}