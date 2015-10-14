using System;
using System.ComponentModel.DataAnnotations;

namespace LSDS.Tdms.Models.TdmsDataModel
{
    public class ManualMatchTrade
    {
        [Key]
        public int tdTrade { get; set; }
        public int tdConfirm { get; set; }
        public DateTime TransactionLoadDate { get; set; }
        public string PortNo { get; set; }
        public string ShawPortNo { get; set; }
        public string UserCode { get; set; }
        public DateTime Traded { get; set; }
        public DateTime mTradeDate { get; set; }
        public DateTime Settlement { get; set; }
        public DateTime mSettlementDate { get; set; }
        public int TN { get; set; }
        public string Ticker { get; set; }
        public string CUSIP { get; set; }
        public string CUSIPNo { get; set; }
        public string Security { get; set; }
        public string IssueDesc { get; set; }
        public string mTransactionCode { get; set; }
        public string BCode { get; set; }
        public string BFin { get; set; }
        public string BrokerFINNo { get; set; }
        public string BrokerName { get; set; }
        public string ReasonCode { get; set; }
        public string TdRef { get; set; }
        public string ConfirmRefNo { get; set; }
        public float Shares { get; set; }
        public float mNUmberofShares { get; set; }
        public float UnitPrice { get; set; }
        public float mUnitPrice { get; set; }
        public float mPrincipalAmount { get; set; }
        public float Principal { get; set; }
        public float SECFees { get; set; }
        public float mSECFees { get; set; }
        public float Income { get; set; }
        public float FederalTax { get; set; }
        public float mCommission { get; set; }
        public float Commission { get; set; }
        public float OtherFee { get; set; }
        public float NetAmount { get; set; }
        public float mNetAmount { get; set; }
        public float UnitCost { get; set; }
        public float mOriginalFace { get; set; }
        public string SecurityType { get; set; }
        public string Status { get; set; }
        public DateTime MatchDate { get; set; }
        public string Bond { get; set; }
        public DateTime TranDate { get; set; }
        public string PDiscrepancy { get; set; }
        public string IAID { get; set; }
        public string ProbCd { get; set; }
        public string TradeComments { get; set; }
        public string NotifyCode { get; set; }
        public string Deleted { get; set; }
        public string TradeSource { get; set; }
        public string CurrencyCode { get; set; }
        public decimal UnitCommission { get; set; }
        public string Affirmed { get; set; }
        public string Notified { get; set; }
        public string DTCAgentId { get; set; }
        public string DTCAgentInternalAccountNo { get; set; }
        public int Archived { get; set; }
        public string Side2 { get; set; }
        public int History { get; set; }
        public string InstitutionNo { get; set; }
        public int tblShawPort { get; set; }
        public int Failed { get; set; }
        public string ActualSettle { get; set; }
        public int SN { get; set; }
        public string BrokerAgentID { get; set; }
        public string BrokerAgentInternalAccount { get; set; }
        public string InterestedParty1AgentID { get; set; }
        public string InterestedParty1AgentAcct { get; set; }
        public string InterestedParty2AgentID { get; set; }
        public string InterestedParty2AgentAcct { get; set; }
        public string BRAXDescrepencyCodes { get; set; }
        public string ClearingBrokerFINNo { get; set; }
        public string ClearingBrokerId { get; set; }
        public string PortNo2 { get; set; }
        public int trade_block { get; set; }
        public float FxRate { get; set; }
        public string StockName { get; set; }
        public float mOtherFee { get; set; }
        public float mIncome { get; set; }
        public string CustAgentId { get; set; }
        public string CustAgentInternalAccount { get; set; }
        public float CurrentFace { get; set; }
        public float mFederalTax { get; set; }
    }
}