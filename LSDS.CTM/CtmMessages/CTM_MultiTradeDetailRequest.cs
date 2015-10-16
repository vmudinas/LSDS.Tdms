using System;
using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM
{
    /// <remarks/>
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MultiTradeDetailRequest
    {
        [Key]
        public int CtmId { get; set; }
        private CTM_Header submitHeaderField;

        private CTM_MultiTradeDetailRequestBody multiTradeDetailRequestBodyField;

        private string[] textField;

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
        public CTM_MultiTradeDetailRequestBody MultiTradeDetailRequestBody
        {
            get
            {
                return this.multiTradeDetailRequestBodyField;
            }
            set
            {
                this.multiTradeDetailRequestBodyField = value;
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