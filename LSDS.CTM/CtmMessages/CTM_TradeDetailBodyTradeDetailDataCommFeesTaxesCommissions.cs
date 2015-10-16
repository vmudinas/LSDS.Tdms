﻿using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_TradeDetailBodyTradeDetailDataCommFeesTaxesCommissions
    {
        [Key]
        public int CtmId { get; set; }
        private string commissionSharingBasisIndicatorField;

        private string commissionTypeField;

        private CTM_TradeDetailBodyTradeDetailDataCommFeesTaxesCommissionsCommission commissionField;

        /// <remarks/>
        public string CommissionSharingBasisIndicator
        {
            get
            {
                return this.commissionSharingBasisIndicatorField;
            }
            set
            {
                this.commissionSharingBasisIndicatorField = value;
            }
        }

        /// <remarks/>
        public string CommissionType
        {
            get
            {
                return this.commissionTypeField;
            }
            set
            {
                this.commissionTypeField = value;
            }
        }

        /// <remarks/>
        public CTM_TradeDetailBodyTradeDetailDataCommFeesTaxesCommissionsCommission Commission
        {
            get
            {
                return this.commissionField;
            }
            set
            {
                this.commissionField = value;
            }
        }
    }
}