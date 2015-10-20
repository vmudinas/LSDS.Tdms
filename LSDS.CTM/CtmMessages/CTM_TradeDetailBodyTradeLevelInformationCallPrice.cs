﻿using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    public class CTM_TradeDetailBodyTradeLevelInformationCallPrice
    {

        [Key]
        public int CtmId { get; set; }
        private double amount;
        private string currencyCodeField;


        [MaxLength(17)]
        public double Amount
        {
            get
            {
                return this.amount;
            }
            set
            {
                this.amount = value;
            }
        }

        [MaxLength(3)]
        public string CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }

    }
}