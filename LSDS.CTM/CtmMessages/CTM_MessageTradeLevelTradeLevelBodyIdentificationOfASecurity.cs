﻿using System.ComponentModel.DataAnnotations;

namespace CtmProcessor.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MessageTradeLevelTradeLevelBodyIdentificationOfASecurity
    {
        [Key]
        public int CtmId { get; set; }
        private CTM_MessageTradeLevelTradeLevelBodyIdentificationOfASecuritySecurityCodeType securityCodeTypeField;

        private uint securityCodeField;

        /// <remarks/>
        public CTM_MessageTradeLevelTradeLevelBodyIdentificationOfASecuritySecurityCodeType SecurityCodeType
        {
            get
            {
                return this.securityCodeTypeField;
            }
            set
            {
                this.securityCodeTypeField = value;
            }
        }

        /// <remarks/>
        public uint SecurityCode
        {
            get
            {
                return this.securityCodeField;
            }
            set
            {
                this.securityCodeField = value;
            }
        }
    }
}