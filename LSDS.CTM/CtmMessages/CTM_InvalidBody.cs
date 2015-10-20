using System;
using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [Serializable]
    public partial class CTM_InvalidBody
    {
        [Key]   [System.Xml.Serialization.XmlIgnore]
        public int CtmId { get; set; }
        private CTM_InvalidBodySynchError synchErrorField;

        private string originalMessageField;

        private string[] textField;

        /// <remarks/>
        public CTM_InvalidBodySynchError SynchError
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