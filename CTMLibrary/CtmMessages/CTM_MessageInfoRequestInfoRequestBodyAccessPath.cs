namespace CTMLibrary.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MessageInfoRequestInfoRequestBodyAccessPath
    {

        private string iDOwnerField;

        private CTM_MessageInfoRequestInfoRequestBodyAccessPathTradeLevelIdentifiers tradeLevelIdentifiersField;

        /// <remarks/>
        public string IDOwner
        {
            get
            {
                return this.iDOwnerField;
            }
            set
            {
                this.iDOwnerField = value;
            }
        }

        /// <remarks/>
        public CTM_MessageInfoRequestInfoRequestBodyAccessPathTradeLevelIdentifiers TradeLevelIdentifiers
        {
            get
            {
                return this.tradeLevelIdentifiersField;
            }
            set
            {
                this.tradeLevelIdentifiersField = value;
            }
        }
    }
}