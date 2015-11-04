﻿using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    public class CTM_TradeDetailBodyTradeLevelInformationWhereListed
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int WhereListedCtmId { get; set; }
        private string countryCode;
        private string region;


        [MaxLength(2)]
        public string CountryCode
        {
            get
            {
                return this.countryCode;
            }
            set
            {
                this.countryCode = value;
            }
        }
       


        [MaxLength(35)]
        public string Region
        {
            get
            {
                return this.region;
            }
            set
            {
                this.region = value;
            }
        }

    }
}