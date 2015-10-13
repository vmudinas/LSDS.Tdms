using System;
using System.Collections.Generic;

namespace LSDS.Tdms.Models.TdmsDataModel
{
    public partial class tblSettlementInstructionsMC
    {
        public int tblSettlementInstructions { get; set; }
        public string BrokerCode { get; set; }
        public string SecurityType { get; set; }
        public int tdxSecurityClass { get; set; }
        public string CurrencyCode { get; set; }
        public string SettlementInstructions { get; set; }
        public string BIC { get; set; }
        public string BankName { get; set; }
        public string ABANo { get; set; }
        public string AccountNumber { get; set; }
        public string Reference { get; set; }
        public string Euroclear { get; set; }
        public int tblBrokerInfo { get; set; }
        public byte[] timestamp { get; set; }
        public string WireInstruction { get; set; }
        public int tdxGenericSecurityClass { get; set; }
        public Nullable<int> tdxSettlementType { get; set; }
        public string SettlementNumber { get; set; }
        public string SettlementLoc { get; set; }
        public string ExecBrokerAccount { get; set; }
        public string ClearingBrokerAccount { get; set; }
        public string CustodianBIC { get; set; }
        public string CustodianAccount { get; set; }
        public string ExecutingBrokerBIC { get; set; }
        public string ClearingBrokerBIC { get; set; }
        public string CorrespondentBankName { get; set; }
        public string CorrespondentBIC { get; set; }
        public string CorrespondentAccount { get; set; }
        public string CorrespondentPaymentSysNo { get; set; }
        public string CorrespondentPaymentSysType { get; set; }
        public string BeneName { get; set; }
        public string BeneBIC { get; set; }
        public string BeneAccount { get; set; }
        public string BenePaymentSysNo { get; set; }
        public string BenePaymentSysType { get; set; }
        public string IntermediaryName { get; set; }
        public string IntermediaryBIC { get; set; }
        public string IntermediaryAccount { get; set; }
        public string IntermediaryPaymentSysNo { get; set; }
        public string IntermediaryPaymentSysType { get; set; }
        public virtual tblBrokerInfoMC tblBrokerInfoMC { get; set; }
        public virtual tdxCurrencyCode tdxCurrencyCode { get; set; }
        public virtual tdxSettlementLoc tdxSettlementLoc { get; set; }
    }
}
