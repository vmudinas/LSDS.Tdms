using System;
using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_TradeDetail
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int TradeDetailCtmId { get; set; }

      
        private CTM_Header submitHeaderField;

        private CTM_TradeDetailBody tradeDetailBodyField;

        /// <remarks/>
        public CTM_Header SubmitHeader
        {
            get
            {
                return this.submitHeaderField;
            }
            set
            {
                this.submitHeaderField = value;
            }
        }

        /// <remarks/>
        public CTM_TradeDetailBody TradeDetailBody
        {
            get
            {
                return this.tradeDetailBodyField;
            }
            set
            {
                this.tradeDetailBodyField = value;
            }
        }
    }
}