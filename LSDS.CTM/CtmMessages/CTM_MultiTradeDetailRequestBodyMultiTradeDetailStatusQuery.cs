using System;
using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [Serializable]
    public partial class CTM_MultiTradeDetailRequestBodyMultiTradeDetailStatusQuery
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int CtmId { get; set; }
        private string[] tDMatchStatusValuesField;

        private string[] textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TDMatchStatusValues")]
        public string[] TDMatchStatusValues
        {
            get
            {
                return this.tDMatchStatusValuesField;
            }
            set
            {
                this.tDMatchStatusValuesField = value;
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