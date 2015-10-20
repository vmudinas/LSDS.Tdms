using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    public class CTM_TradeDetailBodyConfirmDisclosureData
    {
        [Key]   [System.Xml.Serialization.XmlIgnore]
        public int CtmId { get; set; }

        private string _UserDefinedDisclosureCode;
        private string _ConfirmDisclosureBypassIndicator;

        [MaxLength(16)]
        public string UserDefinedDisclosureCode
        {
            get
            {
                return this._UserDefinedDisclosureCode;
            }
            set
            {
                this._UserDefinedDisclosureCode = value;
            }
        }

        [MaxLength(4)]
        public string ConfirmDisclosureBypassIndicator
        {
            get
            {
                return this._ConfirmDisclosureBypassIndicator;
            }
            set
            {
                this._ConfirmDisclosureBypassIndicator = value;
            }
        }
    }
}