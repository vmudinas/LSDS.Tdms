using System;
using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [Serializable]
    public partial class CTM_MessageInvalid
    {
        [Key]
        public int CtmId { get; set; }

        private CTM_MessageInvalidInvalidHeader invalidHeaderField;

        private CTM_MessageInvalidInvalidBody invalidBodyField;

        private string[] textField;

        /// <remarks/>
        public CTM_MessageInvalidInvalidHeader InvalidHeader
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
        public CTM_MessageInvalidInvalidBody InvalidBody
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