﻿using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_TradeDetailBodyTradeDetailDataCommFeesTaxesChargesOrTaxes
    {
        [Key]
        public int CtmId { get; set; }
        private string chargeTaxTypeField;

        private CTM_TradeDetailBodyTradeDetailDataCommFeesTaxesChargesOrTaxesChargeAmount chargeAmountField;

        /// <remarks/>
        public string ChargeTaxType
        {
            get
            {
                return this.chargeTaxTypeField;
            }
            set
            {
                this.chargeTaxTypeField = value;
            }
        }

        /// <remarks/>
        public CTM_TradeDetailBodyTradeDetailDataCommFeesTaxesChargesOrTaxesChargeAmount ChargeAmount
        {
            get
            {
                return this.chargeAmountField;
            }
            set
            {
                this.chargeAmountField = value;
            }
        }
    }
}