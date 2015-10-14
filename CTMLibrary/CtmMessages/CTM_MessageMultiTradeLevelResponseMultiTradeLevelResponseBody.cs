namespace CTMLibrary
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MessageMultiTradeLevelResponseMultiTradeLevelResponseBody
    {

        private byte recordsReturnedCountField;

        private string moreFlagField;

        private ulong goodThroughDateTimeField;

        private string multiTradeLevelResponseIndicatorField;

        private string byOrAgainstFlagField;

        private CTM_MessageMultiTradeLevelResponseMultiTradeLevelResponseBodyMTLR[] mTLRField;

        /// <remarks/>
        public byte RecordsReturnedCount
        {
            get
            {
                return this.recordsReturnedCountField;
            }
            set
            {
                this.recordsReturnedCountField = value;
            }
        }

        /// <remarks/>
        public string MoreFlag
        {
            get
            {
                return this.moreFlagField;
            }
            set
            {
                this.moreFlagField = value;
            }
        }

        /// <remarks/>
        public ulong GoodThroughDateTime
        {
            get
            {
                return this.goodThroughDateTimeField;
            }
            set
            {
                this.goodThroughDateTimeField = value;
            }
        }

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
        [System.Xml.Serialization.XmlElementAttribute("MTLR")]
        public CTM_MessageMultiTradeLevelResponseMultiTradeLevelResponseBodyMTLR[] MTLR
        {
            get
            {
                return this.mTLRField;
            }
            set
            {
                this.mTLRField = value;
            }
        }
    }
}

namespace CTMLibrary.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MessageMultiTradeLevelResponseMultiTradeLevelResponseBody
    {

        private byte recordsReturnedCountField;

        private string moreFlagField;

        private ulong goodThroughDateTimeField;

        private string multiTradeLevelResponseIndicatorField;

        private string byOrAgainstFlagField;

        private CTM_MessageMultiTradeLevelResponseMultiTradeLevelResponseBodyMTLR mTLRField;

        /// <remarks/>
        public byte RecordsReturnedCount
        {
            get
            {
                return this.recordsReturnedCountField;
            }
            set
            {
                this.recordsReturnedCountField = value;
            }
        }

        /// <remarks/>
        public string MoreFlag
        {
            get
            {
                return this.moreFlagField;
            }
            set
            {
                this.moreFlagField = value;
            }
        }

        /// <remarks/>
        public ulong GoodThroughDateTime
        {
            get
            {
                return this.goodThroughDateTimeField;
            }
            set
            {
                this.goodThroughDateTimeField = value;
            }
        }

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
        public CTM_MessageMultiTradeLevelResponseMultiTradeLevelResponseBodyMTLR MTLR
        {
            get
            {
                return this.mTLRField;
            }
            set
            {
                this.mTLRField = value;
            }
        }
    }
}