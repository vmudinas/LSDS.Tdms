using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_CancelBody
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int CancelBodyCtmId { get; set; }

        [MaxLength(35)]
        private string _TLUpdateGuard { get; set; }

        [MaxLength(35)]
        private string _TDUpdateGuard { get; set; }

        private CTM_TradeDetailBodyInstructingParty _InstructingParty;
        private CTM_TradeDetailBodyExecutingBroker _ExecutingBroker;
        private CTM_ClearingBroker _ClearingBroker;
        private CTM_TradeLevelIdentifiers _TradeLevelIdentifiers;
        private CtmTradeDetailIdentifiers _TradeDetailIdentifiers;
        private string _cancelText { get; set; }


        [MaxLength(35)]
        public string TDUpdateGuard
        {
            get { return _TDUpdateGuard; }
            set { _TDUpdateGuard = value; }
        }

        [MaxLength(35)]
        public string TLUpdateGuard
        {
            get { return _TLUpdateGuard; }
            set { _TLUpdateGuard = value; }
        }

        public CTM_TradeDetailBodyInstructingParty InstructingParty
        {
            get { return this._InstructingParty; }
            set { this._InstructingParty = value; }
        }

        public CTM_TradeDetailBodyExecutingBroker ExecutingBroker
        {
            get { return _ExecutingBroker; }
            set { _ExecutingBroker = value; }
        }

        public CTM_ClearingBroker ClearingBroker
        {
            get { return _ClearingBroker; }
            set { _ClearingBroker = value; }
        }

        public CTM_TradeLevelIdentifiers TradeLevelIdentifiers
        {
            get { return _TradeLevelIdentifiers; }
            set { _TradeLevelIdentifiers = value; }
        }

        public CtmTradeDetailIdentifiers TradeDetailIdentifiers
        {
            get { return _TradeDetailIdentifiers; }
            set { _TradeDetailIdentifiers = value; }
        }

        public string CancelText
        {

            get { return _cancelText; }
            set { _cancelText = value; }

        }

    }

  
}