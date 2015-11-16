using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CtmTradeDetailIdentifiers
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int TradeDetailIdentifiersCtmId { get; set; }
        private string clientAllocationReferenceField;
        private string _CTMTradeDetailID;
        private CTM_TradeDetailBodyTradeDetailLinkages _tradeDetailLinkages;
        private string _tradeDetailProcessingReference;


        [MaxLength(16)]
        public string TradeDetailProcessingReference
        {
            get
            {
                return this._tradeDetailProcessingReference;
            }
            set
            {
                this._tradeDetailProcessingReference = value;
            }
        }
        public CTM_TradeDetailBodyTradeDetailLinkages TradeDetailLinkages
        {
            get
            {
                return this._tradeDetailLinkages;
            }
            set
            {
                this._tradeDetailLinkages = value;
            }
        }
        [MaxLength(16)]
        public string CTMTradeDetailID
        {
            get
            {
                return this._CTMTradeDetailID;
            }
            set
            {
                this._CTMTradeDetailID = value;
            }
        }
        /// <remarks/>
        /// 
        [MaxLength(16)]
        public string ClientAllocationReference
        {
            get
            {
                return this.clientAllocationReferenceField;
            }
            set
            {
                this.clientAllocationReferenceField = value;
            }
        }
    }
}
