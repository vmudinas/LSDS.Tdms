using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    public class CTM_TradeDetailBodyTradeLevelInformationRating
    {
        [Key]
        public int CtmId { get; set; }
        private string ratingType;
        private string ratingVendor;
        private string ratingValue;

        [MaxLength(4)]
        public string RatingType
        {
            get
            {
                return this.ratingType;
            }
            set
            {
                this.ratingType = value;
            }
        }
        [MaxLength(15)]
        public string RatingVendor
        {
            get
            {
                return this.ratingVendor;
            }
            set
            {
                this.ratingVendor = value;
            }
        }
        [MaxLength(15)]
        public string RatingValue
        {
            get
            {
                return this.ratingValue;
            }
            set
            {
                this.ratingValue = value;
            }
        }
        
            
            

    }
}