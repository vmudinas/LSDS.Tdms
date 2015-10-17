using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    public class CTM_TradeDetailBodyTDReferences
    {
        private string _tDReferenceValue;
        private string _tDReferenceType;
        [MaxLength(4)]
        public string TDReferenceType
        {
            get
            {
                return this._tDReferenceType;
            }
            set
            {
                this._tDReferenceType = value;
            }
        }
        [MaxLength(16)]
        public string TDReferenceValue
        {
            get
            {
                return this._tDReferenceValue;
            }
            set
            {
                this._tDReferenceValue = value;
            }
        }
    }
}