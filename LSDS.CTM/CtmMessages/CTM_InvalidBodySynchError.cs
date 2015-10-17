using System;
using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [Serializable]
    public partial class CTM_InvalidBodySynchError
    {
        [Key]
        public int CtmId { get; set; }
        private byte errorIdField;

        private string errorKeyField;

        private string errorTextField;

        private CTM_InvalidBodySynchErrorErrorParameter[] errorParameterField;

        private string[] textField;

        /// <remarks/>
        public byte ErrorId
        {
            get
            {
                return this.errorIdField;
            }
            set
            {
                this.errorIdField = value;
            }
        }

        /// <remarks/>
        public string ErrorKey
        {
            get
            {
                return this.errorKeyField;
            }
            set
            {
                this.errorKeyField = value;
            }
        }

        /// <remarks/>
        public string ErrorText
        {
            get
            {
                return this.errorTextField;
            }
            set
            {
                this.errorTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ErrorParameter")]
        public CTM_InvalidBodySynchErrorErrorParameter[] ErrorParameter
        {
            get
            {
                return this.errorParameterField;
            }
            set
            {
                this.errorParameterField = value;
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