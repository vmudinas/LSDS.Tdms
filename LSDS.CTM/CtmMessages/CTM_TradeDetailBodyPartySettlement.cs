using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_TradeDetailBodyPartySettlement
    {
        [Key]
        public int CtmId { get; set; }

        private string settlementInstructionsSourceIndicatorField;

        private string alertCountryCodeField;
        private string alertMethodTypeField;
        private string alertSecurityTypeField;
        private string partyIdentifier;
        private string partyFundName;
        private string alertCountryCode;
        private string alertMethodType;
        private string alertSecurityType;
        private string alertSettlementModelName;
        private string sNReleaseOverride;
        private string fXDealCurrencyCode;
        private string settlementInstructionProcessingNarrative;
        private CTM_TradeDetailBodyPartySettlementSettlementInstructions settlementInstructions;
        private CTM_TradeDetailBodyPartySettlementPlaceOfSafekeeping placeOfSafekeeping;

        public CTM_TradeDetailBodyPartySettlementSettlementInstructions SettlementInstructions
        {
            get
            {
                return this.settlementInstructions;
            }
            set
            {
                this.settlementInstructions = value;
            }
        }


        public CTM_TradeDetailBodyPartySettlementPlaceOfSafekeeping PlaceOfSafekeeping
        {
            get
            {
                return this.placeOfSafekeeping;
            }
            set
            {
                this.placeOfSafekeeping = value;
            }
        }
        
             [MaxLength(2100)]
        public string SettlementInstructionProcessingNarrative
        {
            get
            {
                return this.settlementInstructionProcessingNarrative;
            }
            set
            {
                this.settlementInstructionProcessingNarrative = value;
            }
        }

        [MaxLength(3)]
        public string AlertCountryCode
        {
            get
            {
                return this.alertCountryCode;
            }
            set
            {
                this.alertCountryCode = value;
            }
        }
        [MaxLength(12)]
        public string AlertMethodType
        {
            get
            {
                return this.alertMethodType;
            }
            set
            {
                this.alertMethodType = value;
            }
        }
        [MaxLength(3)]
        public string AlertSecurityType
        {
            get
            {
                return this.alertSecurityType;
            }
            set
            {
                this.alertSecurityType = value;
            }
        }

        [MaxLength(12)]
        public string AlertSettlementModelName
        {
            get
            {
                return this.alertSettlementModelName;
            }
            set
            {
                this.alertSettlementModelName = value;
            }
        }
        
             [MaxLength(4)]
        public string SNReleaseOverride
        {
            get
            {
                return this.sNReleaseOverride;
            }
            set
            {
                this.sNReleaseOverride = value;
            }
        }
        
             [MaxLength(3)]
        public string FXDealCurrencyCode
        {
            get
            {
                return this.fXDealCurrencyCode;
            }
            set
            {
                this.fXDealCurrencyCode = value;
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

        [MaxLength(4)]
        public string PartyIdentifier
        {
            get
            {
                return this.partyIdentifier;
            }
            set
            {
                this.partyIdentifier = value;
            }
        }
        /// <remarks/>
        [MaxLength(4)]
        public string SettlementInstructionsSourceIndicator
        {
            get
            {
                return this.settlementInstructionsSourceIndicatorField;
            }
            set
            {
                this.settlementInstructionsSourceIndicatorField = value;
            }
        }

       
    }
}