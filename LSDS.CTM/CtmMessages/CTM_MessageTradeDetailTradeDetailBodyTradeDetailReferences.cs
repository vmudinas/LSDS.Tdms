using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MessageTradeDetailTradeDetailBodyTradeDetailReferences
    {
        [Key]
        public int CtmId { get; set; }
        private string clientAllocationReferenceField;

        /// <remarks/>
        public string ClientAllocationReference
        {
            get
            {
                return this.clientAllocationReferenceField;
            }
            set
            {
                this.clientAllocationReferenceField = value;
            }
        }
    }
}