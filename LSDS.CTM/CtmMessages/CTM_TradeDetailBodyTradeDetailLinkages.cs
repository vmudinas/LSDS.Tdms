namespace LSDS.CTM.CtmMessages
{
    public class CTM_TradeDetailBodyTradeDetailLinkages
    {
        private CTM_TradeDetailBodyTDReferences _tDReferences;
        public CTM_TradeDetailBodyTDReferences TDReferences
        {
            get
            {
                return this._tDReferences;
            }
            set
            {
                this._tDReferences = value;
            }
        }
    }
}