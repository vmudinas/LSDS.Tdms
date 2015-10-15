using System;
using System.ComponentModel.DataAnnotations;

namespace CtmProcessor
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [Serializable]
    public partial class CTM_MessageInvalidInvalidBody
    {
        [Key]
        public int CtmId { get; set; }
        private CTM_MessageInvalidInvalidBodySynchError synchErrorField;

        private string originalMessageField;

        private string[] textField;

        /// <remarks/>
        public CTM_MessageInvalidInvalidBodySynchError SynchError
        {
            get
            {
                return this.synchErrorField;
            }
            set
            {
                this.synchErrorField = value;
            }
        }

        /// <remarks/>
        public string OriginalMessage
        {
            get
            {
                return this.originalMessageField;
            }
            set
            {
                this.originalMessageField = value;
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