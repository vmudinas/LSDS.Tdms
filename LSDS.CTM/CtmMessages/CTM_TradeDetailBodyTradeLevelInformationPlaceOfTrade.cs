using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    public class CTM_TradeDetailBodyTradeLevelInformationPlaceOfTrade
    {
        [Key]
        public int CtmId { get; set; }

        private string placeCode;
        private string placeNarrative;
        private string orgName;


        [MaxLength(4)]
        public string PlaceCode
        {
            get
            {
                return this.placeCode;
            }
            set
            {
                this.placeCode = value;
            }
        }
        [MaxLength(30)]
        public string PlaceNarrative
        {
            get
            {
                return this.placeNarrative;
            }
            set
            {
                this.placeNarrative = value;
            }
        }
        [MaxLength(35)]
        public string OrgName
        {
            get
            {
                return this.orgName;
            }
            set
            {
                this.orgName = value;
            }
        }



    }
}