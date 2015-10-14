namespace CTMLibrary.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MessageTradeDetailTradeDetailBodyTradeDetailReferences
    {

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