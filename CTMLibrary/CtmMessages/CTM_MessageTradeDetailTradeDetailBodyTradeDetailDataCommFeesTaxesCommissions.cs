﻿namespace CTMLibrary.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataCommFeesTaxesCommissions
    {

        private string commissionSharingBasisIndicatorField;

        private string commissionTypeField;

        private CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataCommFeesTaxesCommissionsCommission commissionField;

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
        public CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataCommFeesTaxesCommissionsCommission Commission
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