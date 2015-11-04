using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    public class CTM_TradeDetailBodyPartySettlementPlaceOfSafekeeping
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int PlaceOfSafekeepingCtmId { get; set; }

        private string _PlaceOfSafekeepingType;
        private string _PlaceOfSafekeepingValue;
        private string _PlaceOfSafekeepingPlace;

        [MaxLength(35)]
        public string PlaceOfSafekeepingType
        {
            get
            {
                return this._PlaceOfSafekeepingType;
            }
            set
            {
                this._PlaceOfSafekeepingType = value;
            }
        }
        [MaxLength(14)]
        public string PlaceOfSafekeepingValue
        {
            get
            {
                return this._PlaceOfSafekeepingValue;
            }
            set
            {
                this._PlaceOfSafekeepingValue = value;
            }
        }
        [MaxLength(4)]
        public string PlaceOfSafekeepingPlace
        {
            get
            {
                return this._PlaceOfSafekeepingPlace;
            }
            set
            {
                this._PlaceOfSafekeepingPlace = value;
            }
        }

    }
}