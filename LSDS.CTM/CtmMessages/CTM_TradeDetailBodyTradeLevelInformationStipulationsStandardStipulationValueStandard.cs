﻿using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    public class CTM_TradeDetailBodyTradeLevelInformationStipulationsStandardStipulationValueStandard
    {
        public int CtmId { get; set; }
        private float stipulationNumeric;
        private string stipulationAlphaNumeric;
        private int stipulationDate;
        private string stipulationY;
        private string stipulationStateCode;


        [MaxLength(2)]
        public string StipulationStateCode
        {

            get
            {
                return this.stipulationStateCode;
            }
            set
            {
                this.stipulationStateCode = value.ToUpper();
            }
        }
        [MaxLength(1)]
        public string StipulationY
        {

            get
            {
                return this.stipulationY;
            }
            set
            {
                this.stipulationY = value.ToUpper();
            }
        }

        [MaxLength(8)]
        public int StipulationDate
        {

            get
            {
                return this.stipulationDate;
            }
            set
            {
                this.stipulationDate = value;
            }
        }

        [MaxLength(17)]
        public string StipulationAlphaNumeric
        {

            get
            {
                return this.stipulationAlphaNumeric;
            }
            set
            {
                this.stipulationAlphaNumeric = value;
            }
        }


        [MaxLength(17)]
        public float StipulationNumeric
        {
            
            get
            {
                return this.stipulationNumeric;
            }
                 set
            {
                this.stipulationNumeric = value;
            }
        }


    }
}