using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    public class CTM_TradeDetailBodyAdditionalDisclosures
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int DisclosuresCtmId { get; set; }
        private string functionOfTheMessageField;
        private string oddLotDifferential;
        private string otherRemuneration;
        private string assetBacked;
        private string marketMaker;
        private string sIPCMember;
        private string fINRAMember;
        private string otherRemunerationDisclosure;
        private string oddLotDisclosure;
        private string orderFlowDisclosure;
        private string redemptionDisclosure;
        private string assetBackedSecuritiesDisclosure;




        private CTM_TradeDetailBodyAdditionalDisclosuresReportedPrice reportedPrice;
        private CTM_TradeDetailBodyAdditionalDisclosuresMarkUpMarkDown markUpMarkDown;


        public CTM_TradeDetailBodyAdditionalDisclosuresMarkUpMarkDown MarkUpMarkDown
        {
            get
            {
                return this.markUpMarkDown;
            }
            set
            {
                this.markUpMarkDown = value;
            }
        }

        public CTM_TradeDetailBodyAdditionalDisclosuresReportedPrice ReportedPrice
        {
            get
            {
                return this.reportedPrice;
            }
            set
            {
                this.reportedPrice = value;
            }
        }
        
        [MaxLength(1)]
        public string OddLotDifferential
        {
            get
            {
                return this.oddLotDifferential;
            }
            set
            {
                this.oddLotDifferential = value;
            }
        }

        [MaxLength(1)]
        public string OtherRemuneration
        {
            get
            {
                return this.otherRemuneration;
            }
            set
            {
                this.otherRemuneration = value;
            }
        }

        [MaxLength(1)]
        public string AssetBacked
        {
            get
            {
                return this.assetBacked;
            }
            set
            {
                this.assetBacked = value;
            }
        }
        [MaxLength(1)]
        public string MarketMaker
        {
            get
            {
                return this.marketMaker;
            }
            set
            {
                this.marketMaker = value;
            }
        }
        [MaxLength(1)]
        public string SIPCMember
        {
            get
            {
                return this.sIPCMember;
            }
            set
            {
                this.sIPCMember = value;
            }
        }
        [MaxLength(1)]
        public string FINRAMember
        {
            get
            {
                return this.fINRAMember;
            }
            set
            {
                this.fINRAMember = value;
            }
        }
        [MaxLength(500)]
        public string OtherRemunerationDisclosure
        {
            get
            {
                return this.otherRemunerationDisclosure;
            }
            set
            {
                this.otherRemunerationDisclosure = value;
            }
        }
        [MaxLength(500)]
        public string OddLotDisclosure
        {
            get
            {
                return this.oddLotDisclosure;
            }
            set
            {
                this.oddLotDisclosure = value;
            }
        }
        [MaxLength(500)]
        public string OrderFlowDisclosure
        {
            get
            {
                return this.orderFlowDisclosure;
            }
            set
            {
                this.orderFlowDisclosure = value;
            }
        }
        [MaxLength(500)]
        public string RedemptionDisclosure
        {
            get
            {
                return this.redemptionDisclosure;
            }
            set
            {
                this.redemptionDisclosure = value;
            }
        }
        [MaxLength(500)]
        public string AssetBackedSecuritiesDisclosure
        {
            get
            {
                return this.assetBackedSecuritiesDisclosure;
            }
            set
            {
                this.assetBackedSecuritiesDisclosure = value;
            }
        }    

    }
}