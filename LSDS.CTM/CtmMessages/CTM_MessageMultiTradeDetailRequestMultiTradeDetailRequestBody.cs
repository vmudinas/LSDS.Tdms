using System;
using System.ComponentModel.DataAnnotations;

namespace CtmProcessor
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [Serializable]
    public partial class CTM_MessageMultiTradeDetailRequestMultiTradeDetailRequestBody
    {
        [Key]
        public int CtmId { get; set; }
        private string multiTradeDetailResponseRequestedField;

        private string byOrAgainstFlagField;

     //   private CTM_MessageMultiTradeDetailRequestMultiTradeDetailRequestBodyMultiTradeDetailStatusQuery multiTradeDetailStatusQueryField;

        private ulong minLastUpdateDateTimeField;

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
        //public CTM_MessageMultiTradeDetailRequestMultiTradeDetailRequestBodyMultiTradeDetailStatusQuery MultiTradeDetailStatusQuery
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
        public ulong MinLastUpdateDateTime
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