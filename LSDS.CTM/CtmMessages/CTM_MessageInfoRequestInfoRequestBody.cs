using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MessageInfoRequestInfoRequestBody
    {
        [Key]
        public int CtmId { get; set; }
        private string viewRequestedIndicatorField;

        private string queryTypeField;

        private CTM_MessageInfoRequestInfoRequestBodyExecutingBroker executingBrokerField;

        private CTM_MessageInfoRequestInfoRequestBodyAccessPath accessPathField;

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
        public CTM_MessageInfoRequestInfoRequestBodyExecutingBroker ExecutingBroker
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
        public CTM_MessageInfoRequestInfoRequestBodyAccessPath AccessPath
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