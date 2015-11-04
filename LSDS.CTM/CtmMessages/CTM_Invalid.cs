using System;
using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [Serializable]
    public partial class CTM_Invalid
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int InvalidCtmId { get; set; }

        private CTM_ResponseHeader invalidHeaderField;

        private CTM_InvalidBody invalidBodyField;

        private string[] textField;

        /// <remarks/>
        public CTM_ResponseHeader InvalidHeader
        {
            get
            {
                return this.invalidHeaderField;
            }
            set
            {
                this.invalidHeaderField = value;
            }
        }

        /// <remarks/>
        public CTM_InvalidBody InvalidBody
        {
            get
            {
                return this.invalidBodyField;
            }
            set
            {
                this.invalidBodyField = value;
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