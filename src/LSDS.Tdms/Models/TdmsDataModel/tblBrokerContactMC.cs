using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LSDS.Tdms.Models.TdmsDataModel
{
    public partial class tblBrokerContactMC
    {
        [Key]
        public int tblBrokerContact { get; set; }
        public string BrokerCode { get; set; }
        public int tdxLocationID { get; set; }
        public string ContactName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Comment { get; set; }
        public string EmailAddress { get; set; }
        public Nullable<int> tdxCountryCode { get; set; }
        public string AltFaxNumber { get; set; }
        public int ContactNo { get; set; }
        public string SecurityType { get; set; }
        public Nullable<int> tdxSecurityClass { get; set; }
        public int tblBrokerInfo { get; set; }
        public byte[] timestamp { get; set; }
        public Nullable<int> CountryCode { get; set; }
        public virtual tblBrokerInfoMC tblBrokerInfoMC { get; set; }
    }
}
