using System;

namespace CTMLibrary
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [Serializable]
    public partial class CTM_MessageInvalidInvalidHeader
    {

        private string protocolVersionField;

        private CTM_MessageInvalidInvalidHeaderOriginatorOfMessage originatorOfMessageField;

        private string[] textField;

        /// <remarks/>
        public string ProtocolVersion
        {
            get
            {
                return this.protocolVersionField;
            }
            set
            {
                this.protocolVersionField = value;
            }
        }

        /// <remarks/>
        public CTM_MessageInvalidInvalidHeaderOriginatorOfMessage OriginatorOfMessage
        {
            get
            {
                return this.originatorOfMessageField;
            }
            set
            {
                this.originatorOfMessageField = value;
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