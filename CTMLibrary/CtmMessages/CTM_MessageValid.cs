﻿namespace CTMLibrary.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_MessageValid
    {

        private CTM_MessageValidResponseHeader responseHeaderField;

        private CTM_MessageValidValidBody validBodyField;

        /// <remarks/>
        public CTM_MessageValidResponseHeader ResponseHeader
        {
            get
            {
                return this.responseHeaderField;
            }
            set
            {
                this.responseHeaderField = value;
            }
        }

        /// <remarks/>
        public CTM_MessageValidValidBody ValidBody
        {
            get
            {
                return this.validBodyField;
            }
            set
            {
                this.validBodyField = value;
            }
        }
    }
}