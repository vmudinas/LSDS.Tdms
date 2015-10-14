using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LSDS.Tdms.Models.TdmsDataModel
{
    public partial class tblBrokerInfoMC
    {
        public tblBrokerInfoMC()
        {
            this.tblBrokerContactMCs = new List<tblBrokerContactMC>();
            this.tblSettlementInstructionsMCs = new List<tblSettlementInstructionsMC>();
        }
        [Key]
        public int tblBrokerInfo { get; set; }
        public string BrokerCode { get; set; }
        public string BrokerName { get; set; }
        public string AccountNumber { get; set; }
        public string ABANo { get; set; }
        public string WireInstruction { get; set; }
        public Nullable<int> Status { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNo { get; set; }
        public string FaxNo { get; set; }
        public string Comment { get; set; }
        public string BrokerContact { get; set; }
        public Nullable<short> AssetType { get; set; }
        public string DTCClearingFINNo { get; set; }
        public string ExternalBrokerCode { get; set; }
        public string ClearingBrokerName { get; set; }
        public Nullable<byte> FlagDeleted { get; set; }
        public string ExecutingBrokerBIC { get; set; }
        public string ClearingBrokerBIC { get; set; }
        public int tdxLocationID { get; set; }
        public int tdUserGroupID { get; set; }
        public Nullable<int> SendMethod { get; set; }
        public string ParentBroker { get; set; }
        public byte[] timestamp { get; set; }
        public Nullable<int> tblBrokerMaster { get; set; }
        public string MPID { get; set; }
        public string ALERTID { get; set; }
        public string OASYSID { get; set; }
        public string CRDID { get; set; }
        public string SECID { get; set; }
        public string CICI { get; set; }
        public virtual ICollection<tblBrokerContactMC> tblBrokerContactMCs { get; set; }
        public virtual ICollection<tblSettlementInstructionsMC> tblSettlementInstructionsMCs { get; set; }
    }
}
