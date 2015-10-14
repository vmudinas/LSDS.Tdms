namespace CTMLibrary
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MessageMultiTradeLevelResponseMultiTradeLevelResponseBodyMTLRTradeLevelReferences
    {

        private ulong masterReferenceField;

        private uint cTMTradeSideIdField;

        /// <remarks/>
        public ulong MasterReference
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

        /// <remarks/>
        public uint CTMTradeSideId
        {
            get
            {
                return this.cTMTradeSideIdField;
            }
            set
            {
                this.cTMTradeSideIdField = value;
            }
        }
    }
}

namespace CTMLibrary.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MessageMultiTradeLevelResponseMultiTradeLevelResponseBodyMTLRTradeLevelReferences
    {

        private string masterReferenceField;

        private uint cTMTradeSideIdField;

        /// <remarks/>
        public string MasterReference
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

        /// <remarks/>
        public uint CTMTradeSideId
        {
            get
            {
                return this.cTMTradeSideIdField;
            }
            set
            {
                this.cTMTradeSideIdField = value;
            }
        }
    }
}