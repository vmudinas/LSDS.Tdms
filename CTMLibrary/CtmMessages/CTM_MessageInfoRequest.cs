namespace CTMLibrary.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MessageInfoRequest
    {

        private CTM_MessageInfoRequestSubmitHeader submitHeaderField;

        private CTM_MessageInfoRequestInfoRequestBody infoRequestBodyField;

        /// <remarks/>
        public CTM_MessageInfoRequestSubmitHeader SubmitHeader
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
        public CTM_MessageInfoRequestInfoRequestBody InfoRequestBody
        {
            get
            {
                return this.infoRequestBodyField;
            }
            set
            {
                this.infoRequestBodyField = value;
            }
        }
    }
}