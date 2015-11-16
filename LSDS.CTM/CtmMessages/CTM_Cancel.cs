using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_Cancel
    {
            [Key]
            [System.Xml.Serialization.XmlIgnore]
            public int CancelCtmId { get; set; }


            private CTM_Header submitHeaderField;

            private CTM_CancelBody CancelField;

            /// <remarks/>
            public CTM_Header SubmitHeader
            {
                get
                {
                    return this.submitHeaderField;
                }
                set
                {
                    this.submitHeaderField = value;
                }
            }

            /// <remarks/>
            public CTM_CancelBody CancelBody
        {
                get
                {
                    return this.CancelField;
                }
                set
                {
                    this.CancelField = value;
                }
            }
        }
 }
