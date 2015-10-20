﻿using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    public class CTM_TradeDetailBodyTradeDetailLinkages
    {
        [Key]   [System.Xml.Serialization.XmlIgnore]
        public int CtmId { get; set; }
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