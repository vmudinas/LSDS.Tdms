using System;

namespace CTMLibrary
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [Serializable]
    public partial class CTM_MessageInvalidInvalidBodySynchErrorErrorParameter
    {

        private string errorParameterTypeField;

        private string errorParameterValueField;

        private string[] textField;

        /// <remarks/>
        public string ErrorParameterType
        {
            get
            {
                return this.errorParameterTypeField;
            }
            set
            {
                this.errorParameterTypeField = value;
            }
        }

        /// <remarks/>
        public string ErrorParameterValue
        {
            get
            {
                return this.errorParameterValueField;
            }
            set
            {
                this.errorParameterValueField = value;
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