using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LSDS.CTM;
using LSDS.CTM;

namespace LSDS.CTM
{
    /// <remarks/>
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]

    [Table("CTM_Trade")]
    public partial class CTM_Message
    {
        [Key]
        public int CtmId { get; set; }
        private CTM_MessageInvalid invalidField;
        private CTM_MessageTradeLevel tradeLevelField;
        private CTM_MessageValid validField;

        private CTM_MessageMultiTradeDetailResponse multiTradeDetailResponseField;
        private CTM_MessageMultiTradeDetailRequest multiTradeDetailRequestField;
        private CTM_MessageInfoRequest infoRequestField;
        private CTM_MessageMultiTradeLevelRequest multiTradeLevelRequestField;
        private CTM_MessageMultiTradeLevelResponse multiTradeLevelResponseField;
        private string[] textField;
        
        
        /// <remarks/>
        public CTM_MessageTradeLevel TradeLevel
        {
            get
            {
                return this.tradeLevelField;
            }
            set
            {
                this.tradeLevelField = value;
            }
        }
        /// <remarks/>
        public CTM_MessageInfoRequest InfoRequest
        {
            get
            {
                return this.infoRequestField;
            }
            set
            {
                this.infoRequestField = value;
            }
        }

        /// <remarks/>
        public CTM_MessageInvalid Invalid
        {
            get
            {
                return this.invalidField;
            }
            set
            {
                this.invalidField = value;
            }
        }



        /// <remarks/>
        public CTM_MessageMultiTradeDetailResponse MultiTradeDetailResponse
        {
            get
            {
                return this.multiTradeDetailResponseField;
            }
            set
            {
                this.multiTradeDetailResponseField = value;
            }
        }


       

       

        /// <remarks/>
        public CTM_MessageMultiTradeDetailRequest MultiTradeDetailRequest
        {
            get
            {
                return this.multiTradeDetailRequestField;
            }
            set
            {
                this.multiTradeDetailRequestField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

      
        /// <remarks/>
        public CTM_MessageMultiTradeLevelResponse MultiTradeLevelResponse
        {
            get
            {
                return this.multiTradeLevelResponseField;
            }
            set
            {
                this.multiTradeLevelResponseField = value;
            }
        }
    
     


        /// <remarks/>
        public CTM_MessageMultiTradeLevelRequest MultiTradeLevelRequest
        {
            get
            {
                return this.multiTradeLevelRequestField;
            }
            set
            {
                this.multiTradeLevelRequestField = value;
            }
        }
  
       

        /// <remarks/>
        public CTM_MessageValid Valid
        {
            get
            {
                return this.validField;
            }
            set
            {
                this.validField = value;
            }
        }
  
        private CTM_MessageTradeDetail tradeDetailField;

        /// <remarks/>
        public CTM_MessageTradeDetail TradeDetail
        {
            get
            {
                return this.tradeDetailField;
            }
            set
            {
                this.tradeDetailField = value;
            }
        }
    }
}
