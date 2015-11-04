using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_Valid
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int ValidCtmId { get; set; }

    ///// <remarks/>
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    //[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    //public partial class CTM_Message
    //{

    //    private CTM_MessageValid validField;

    //    /// <remarks/>
    //    public CTM_MessageValid Valid
    //    {
    //        get { return this.validField; }
    //        set { this.validField = value; }
    //    }
    //}

    ///// <remarks/>
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    //public partial class CTM_MessageValid
    //{

        private CTM_MessageValidResponseHeader responseHeaderField;

        private CTM_MessageValidValidBody validBodyField;

        /// <remarks/>
        public CTM_MessageValidResponseHeader ResponseHeader
        {
            get { return this.responseHeaderField; }
            set { this.responseHeaderField = value; }
        }

        /// <remarks/>
        public CTM_MessageValidValidBody ValidBody
        {
            get { return this.validBodyField; }
            set { this.validBodyField = value; }
        }
    }
}

