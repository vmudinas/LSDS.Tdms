using System;

namespace CTMLibrary
{
    /// <remarks/>
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MessageMultiTradeDetailResponseMultiTradeDetailResponseBody
    {

        private byte recordsReturnedCountField;

        private string moreFlagField;

        private ulong goodThroughDateTimeField;

        private string byOrAgainstFlagField;

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
    }
}