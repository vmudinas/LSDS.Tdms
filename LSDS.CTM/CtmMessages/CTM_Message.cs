using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]

   
    public partial class CTM_Message
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int CtmId { get; set; }
        [System.Xml.Serialization.XmlIgnore]
        public DateTime LastUpdated { get; set; }
        private CTM_Invalid invalidField;
        private CTM_TradeLevel tradeLevelField;
        private CTM_Valid validField;
        private CTM_TradeDetail tradeDetailField;
        private CTM_MultiTradeDetailResponse multiTradeDetailResponseField;
        private CTM_MultiTradeDetailRequest multiTradeDetailRequestField;
        private CTM_InfoRequest infoRequestField;
        private CTM_MultiTradeLevelRequest multiTradeLevelRequestField;
        private CTM_MultiTradeLevelResponse multiTradeLevelResponseField;
        private CTM_Cancel CancelField;
        private string[] textField;
        
        
        /// <remarks/>
        public CTM_TradeLevel TradeLevel
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
        public CTM_InfoRequest InfoRequest
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
        public CTM_Invalid Invalid
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
        public CTM_MultiTradeDetailResponse MultiTradeDetailResponse
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
        public CTM_MultiTradeDetailRequest MultiTradeDetailRequest
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
        public CTM_MultiTradeLevelResponse MultiTradeLevelResponse
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
        public CTM_MultiTradeLevelRequest MultiTradeLevelRequest
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
        public CTM_Valid Valid
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
  
       

        /// <remarks/>
        public CTM_TradeDetail TradeDetail
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
        public CTM_Cancel Cancel
        {
            get
            {
                return this.CancelField;
            }
            set
            {
                this.CancelField = value;
            }
        }
         
    }
}
