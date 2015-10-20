using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    public class CTM_TradeDetailBodyAdditionalData
    {
        [Key]   [System.Xml.Serialization.XmlIgnore]
        public int CtmId { get; set; }
        private string additionalText;
        private string dataXML;

        [MaxLength(35)]
        public string AdditionalText
        {
            get
            {
                return this.additionalText;
            }
            set
            {
                this.additionalText = value;
            }
        }
        [MaxLength(2000)]
        public string DataXML
        {
            get
            {
                return this.dataXML;
            }
            set
            {
                this.dataXML = value;
            }
        }

     
    }
}