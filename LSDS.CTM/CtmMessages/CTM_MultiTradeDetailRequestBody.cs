using System;
using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [Serializable]
    public partial class CTM_MultiTradeDetailRequestBody
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int RequestBodyCtmId { get; set; }
        private string multiTradeDetailResponseRequestedField;

        private string byOrAgainstFlagField;

     //   private CTM_MultiTradeDetailRequestBodyMultiTradeDetailStatusQuery multiTradeDetailStatusQueryField;

        private DateTime? minLastUpdateDateTimeField;

        private string[] textField;

        /// <remarks/>
        public string MultiTradeDetailResponseRequested
        {
            get
            {
                return this.multiTradeDetailResponseRequestedField;
            }
            set
            {
                this.multiTradeDetailResponseRequestedField = value;
            }
        }

        /// <remarks/>
        public string ByOrAgainstFlag
        {
            get
            {
                return this.byOrAgainstFlagField;
            }
            set
            {
                this.byOrAgainstFlagField = value;
            }
        }

        /// <remarks/>
        //public CTM_MultiTradeDetailRequestBodyMultiTradeDetailStatusQuery MultiTradeDetailStatusQuery
        //{
        //    get
        //    {
        //        return this.multiTradeDetailStatusQueryField;
        //    }
        //    set
        //    {
        //        this.multiTradeDetailStatusQueryField = value;
        //    }
        //}

        /// <remarks/>
        public DateTime? MinLastUpdateDateTime
        {
            get
            {
                return this.minLastUpdateDateTimeField;
            }
            set
            {
                this.minLastUpdateDateTimeField = value;
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
    }
}