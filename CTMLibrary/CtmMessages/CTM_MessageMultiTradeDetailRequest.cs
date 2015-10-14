using System;

namespace CTMLibrary
{
    /// <remarks/>
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MessageMultiTradeDetailRequest
    {

        private CTM_MessageMultiTradeDetailRequestSubmitHeader submitHeaderField;

        private CTM_MessageMultiTradeDetailRequestMultiTradeDetailRequestBody multiTradeDetailRequestBodyField;

        private string[] textField;

        /// <remarks/>
        public CTM_MessageMultiTradeDetailRequestSubmitHeader SubmitHeader
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
        public CTM_MessageMultiTradeDetailRequestMultiTradeDetailRequestBody MultiTradeDetailRequestBody
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