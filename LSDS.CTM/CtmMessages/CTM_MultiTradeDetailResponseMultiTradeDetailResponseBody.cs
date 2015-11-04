using System;
using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MultiTradeDetailResponseMultiTradeDetailResponseBody
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int TradeDetailResponseBodyCtmId { get; set; }
        private byte recordsReturnedCountField;

        private string moreFlagField;

        private DateTime goodThroughDateTimeField;

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
        public DateTime GoodThroughDateTime
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