using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_InfoRequestBody
    {
        [Key]
        public int CtmId { get; set; }
        private string viewRequestedIndicatorField;

        private string queryTypeField;

        private CTM_InfoRequestBodyExecutingBroker executingBrokerField;

        private CTM_InfoRequestBodyAccessPath accessPathField;

        /// <remarks/>
        public string ViewRequestedIndicator
        {
            get
            {
                return this.viewRequestedIndicatorField;
            }
            set
            {
                this.viewRequestedIndicatorField = value;
            }
        }

        /// <remarks/>
        public string QueryType
        {
            get
            {
                return this.queryTypeField;
            }
            set
            {
                this.queryTypeField = value;
            }
        }

        /// <remarks/>
        public CTM_InfoRequestBodyExecutingBroker ExecutingBroker
        {
            get
            {
                return this.executingBrokerField;
            }
            set
            {
                this.executingBrokerField = value;
            }
        }

        /// <remarks/>
        public CTM_InfoRequestBodyAccessPath AccessPath
        {
            get
            {
                return this.accessPathField;
            }
            set
            {
                this.accessPathField = value;
            }
        }
    }
}