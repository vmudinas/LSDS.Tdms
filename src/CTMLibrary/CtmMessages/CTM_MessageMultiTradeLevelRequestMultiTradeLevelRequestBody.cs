namespace CTMLibrary.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MessageMultiTradeLevelRequestMultiTradeLevelRequestBody
    {

        private string multiTradeLevelResponseIndicatorField;

        private string byOrAgainstFlagField;

        private ulong minLastUpdateDateTimeField;

        /// <remarks/>
        public string MultiTradeLevelResponseIndicator
        {
            get
            {
                return this.multiTradeLevelResponseIndicatorField;
            }
            set
            {
                this.multiTradeLevelResponseIndicatorField = value;
            }
        }

        /// <remarks/>
        public string ByOrAgainstFlag
        {
            get
            {
                return this.byOrAgainstFlagField;
            }
            set
            {
                this.byOrAgainstFlagField = value;
            }
        }

        /// <remarks/>
        public ulong MinLastUpdateDateTime
        {
            get
            {
                return this.minLastUpdateDateTimeField;
            }
            set
            {
                this.minLastUpdateDateTimeField = value;
            }
        }
    }
}