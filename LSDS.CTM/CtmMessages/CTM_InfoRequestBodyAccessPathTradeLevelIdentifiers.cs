using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_InfoRequestBodyAccessPathTradeLevelIdentifiers
    {
        [Key]
        public int CtmId { get; set; }
         [MaxLength(16)]  private string masterReferenceField;

        /// <remarks/>
         [MaxLength(16)]  public string MasterReference
        {
            get
            {
                return this.masterReferenceField;
            }
            set
            {
                this.masterReferenceField = value;
            }
        }
    }
}