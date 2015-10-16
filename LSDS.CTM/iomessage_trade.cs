using System;
using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM
{
    public class iomessage_trade
    {
      
        public int tdTrade { get; set; } //(int, null)
        [StringLength(12)]
        public string ShawPortNo { get; set; } //(char(12), null)
        public DateTime mTradeDate { get; set; } //(smalldatetime, null)
        public DateTime mSettlementDate { get; set; } //(smalldatetime, null)
        [StringLength(1)]
        public string mTransactionCode { get; set; } //(varchar(1), null)
        public int TradeNotifyCode { get; set; } //(int, null)
        [StringLength(24)]
        public string StockName { get; set; } //(varchar(24), null)
        [StringLength(36)]
        public string BrokerName { get; set; } //(varchar(36), null)
        public double mNumberofShares { get; set; } //(float, null)
        public double mUnitPrice { get; set; } //(float, null)
        public double mFees { get; set; } //(float, null)
        public double mCommission { get; set; } //(float, null)
        public double mIncome { get; set; } //(float, null)
        public double mNetAmount { get; set; } //(float, null)
        public double mPrincipalAmount { get; set; } //(float, null)
        public double CouponRate { get; set; } //(float, null)
        public DateTime maturity_date { get; set; } //(smalldatetime, null)
        [StringLength(36)]
        public string issue_desc { get; set; } //(varchar(36), null)
        public double mOriginalFace { get; set; } //(float, null)
        public int iomessageLog { get; set; } //(int, null)
        [StringLength(4)]
        public string UserCode { get; set; } //(varchar(4), null)
        [StringLength(6)]
        public string TradeSource { get; set; } //(varchar(6), null)
        [StringLength(21)]
        public string StockSymbol { get; set; } //(varchar(21), null)
        [StringLength(10)]
        public string SecurityIdType { get; set; } //(varchar(10), null)
        [StringLength(50)]
        public string CUSIPNo { get; set; } //(varchar(50), null)
        [StringLength(15)]
        public string BrokerId { get; set; } //(varchar(15), null)
        [StringLength(10)]
        public string BrokerIdType { get; set; } //(varchar(10), null)
        [StringLength(15)]
        public string TradeRefNo { get; set; } //(varchar(15), null)
        [StringLength(2)]
        public string LocalCurrencyCode { get; set; } //(varchar(3), null)
        public int TradeMatchStatus { get; set; } //(int, null)
        public int sentflag { get; set; } //(int, null)
        public int tblPortContact { get; set; } //(int, null)
        public int FlagIPO { get; set; } //(int, null)
        public int FlagBondIndicator { get; set; } //(int, null)
        [StringLength(9)]
        public string ABANo { get; set; } //(varchar(9), null)
        [StringLength(30)]
        public string WireInstruction { get; set; } //(varchar(30), null)
        [StringLength(36)]
        public string ClearingBroker { get; set; } //(varchar(36), null)
        [StringLength(10)]
        public string DTCClearingFINNo { get; set; } //(varchar(10), null)
        [StringLength(15)]
        public string MatchStatusDesc { get; set; } //(varchar(15), null)
        [StringLength(10)]
        public string ConfirmCodesType { get; set; } //(varchar(10), null)
        [StringLength(1)]
        public string Side2 { get; set; } //(varchar(1), null)
        [StringLength(1)]
        public string ShawBrokerReasonCode { get; set; } //(varchar(1), null)
        [StringLength(128)]
        public string NotifyCode { get; set; } //(varchar(128), null)
        [StringLength(12)]
        public string ShawBrokerCode { get; set; } //(char(12), null)
        [StringLength(20)]
        public string ExternalBrokerCode { get; set; } //(varchar(20), null)
        [StringLength(1)]
        public string SecurityType { get; set; } //(char(1), null)
        [StringLength(12)]
        public string ISIN { get; set; } //(varchar(12), null)
        [StringLength(40)]
        public string BankName { get; set; } //(varchar(40), null)
        [StringLength(9)]
        public string d_ABANo { get; set; } //(varchar(9), null)
        [StringLength(30)]
        public string AccountNumber { get; set; } //(varchar(30), null)
        [StringLength(35)]
        public string Euroclear { get; set; } //(varchar(35), null)
        [StringLength(255)]
        public string SettlementInstructions { get; set; } //(varchar(255), null)
        [StringLength(64)]
        public string Reference { get; set; } //(varchar(64), null)
        public int iomessage_tradeid { get; set; } //(int, not null)
        public int tdxSettlementType { get; set; } //(int, null)
        [StringLength(15)]
        public string ExecutingBrokerBIC { get; set; } //(varchar(15), null)
        [StringLength(20)]
        public string SettlementNumber { get; set; } //(varchar(20), null)
        public int tblShawPort { get; set; } //(int, null)
        [StringLength(20)]
        public string ErrorCode { get; set; } //(varchar(20), null)
        public int tdxSecurityType { get; set; } //(int, null)
    }

}
