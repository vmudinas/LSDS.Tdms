using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LSDS.Tdms.Models.TdmsDataModel
{
    public class UspReturnTradeDetail
    {
        [MaxLength(9)]
        public string ABANo { get; set; }
        
        public string AccountNumber { get; set; }
       // [DisplayName("Actual Settle:")]
       // [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd MMM yyyy}")]
        public string ActualSettle { get; set; }
        public double? AdditionalFee1 { get; set; }
     
        public double? AdditionalFee2 { get; set; }

       // [DisplayName("Affirm:")]
       // [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd MMM yyyy}")]
        [DataType(DataType.Date)]
        public DateTime? AffirmDate { get; set; }
        public string AffirmStatus { get; set; }
        public int? Age { get; set; }
       // [DisplayName("Agent MEI:")]
        public string AgentMEI { get; set; }
        public int? Archived { get; set; }
       // [DisplayName("Asset Type:")]
        public string AssetType { get; set; }
        public double? AssignmentFee { get; set; }
        public string BankName { get; set; }
        [MaxLength(10)]
        public string BrokerFINNo { get; set; }
       // [DisplayName("Broker MEI:")]
        public string BrokerMEI { get; set; }

        public string BrokerName { get; set; }
        [MaxLength(1)]
        public string ClassCode1 { get; set; }
        [MaxLength(1)]
        public string ClassCode2 { get; set; }

        [MaxLength(1)]
        public string ClassCode3 { get; set; }

        [MaxLength(1)]
        public string ClassCode4 { get; set; }

        [MaxLength(1)]
        public string ClassCode5 { get; set; }

        [MaxLength(1)]
        public string ClassCode6 { get; set; }

        public string ClearingBrokerBIC { get; set; }
        public string ClearingBrokerFIN { get; set; }
        public string ClearingBrokerFINNo { get; set; }
        
        
        public string ClearingBrokerName { get; set; }

        public double? ClearParFee { get; set; }
       // [DisplayName("ClearPar Ref:")]
        public string ClearParSubtradeTicketNo { get; set; }
        public string CommentType { get; set; }
        public string ConfirmFileName { get; set; }
        public int? ConfirmLog { get; set; }
        public string ConfirmRefNo { get; set; }
      
       // [DisplayName("Contractual Settle:")]
       // [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd MMM yyyy}")]
        [DataType(DataType.Date)]
        public DateTime? ContractualSettlementDate { get; set; }

        public double? CostofCarry { get; set; }
        
        public double? CostofCarryRate { get; set; }

        public string CurrencyCode { get; set; }
        
        public double? CurrentQuantity { get; set; }

       // [DisplayName("Sec ID:")]
        public string CUSIPNo { get; set; }

        
        public string CustFINNo { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Date_Stamp { get; set; }
       // [DisplayName("Delayed Comp:")]
        public string DelayedComp { get; set; }
        public byte DiscAffirmingParty { get; set; }
        public byte DiscBrokerFinNo { get; set; }

        public byte DiscBuySellIndicator { get; set; }

        public byte DiscCommission { get; set; }
        public byte DiscFederalTax { get; set; }
        public byte DiscIncome { get; set; }
        public byte DiscInstitutionNo { get; set; }
        public byte DiscNetAmount { get; set; }
        public byte DiscNumberofShares { get; set; }
        
        public byte DiscOtherFee { get; set; }

        public byte DiscPrincipalAmount { get; set; }
        public string discrepancy { get; set; }
        [MaxLength(15)]
        public string Discrepancy_Confirm1 { get; set; }
        [MaxLength(15)]
        public string Discrepancy_Confirm10 { get; set; }
        [MaxLength(15)]
        public string Discrepancy_Confirm11 { get; set; }

        [MaxLength(15)]
        public string Discrepancy_Confirm12 { get; set; }

        [MaxLength(15)]
        public string Discrepancy_Confirm13 { get; set; }

        [MaxLength(15)]
        public string Discrepancy_Confirm14 { get; set; }

        [MaxLength(15)]
        public string Discrepancy_Confirm15 { get; set; }

        [MaxLength(15)]
        public string Discrepancy_Confirm2 { get; set; }

        [MaxLength(15)]
        public string Discrepancy_Confirm3 { get; set; }

        [MaxLength(15)]
        public string Discrepancy_Confirm4 { get; set; }

        [MaxLength(15)]
        public string Discrepancy_Confirm5 { get; set; }

        [MaxLength(15)]
        public string Discrepancy_Confirm6 { get; set; }

        [MaxLength(15)]
        public string Discrepancy_Confirm7 { get; set; }

        [MaxLength(15)]
        public string Discrepancy_Confirm8 { get; set; }

        [MaxLength(15)]
        public string Discrepancy_Confirm9 { get; set; }

        [MaxLength(15)]
        public string Discrepancy_Label1 { get; set; }

        public string Discrepancy_Label10 { get; set; }
        [MaxLength(15)]
        public string Discrepancy_Label11 { get; set; }

        [MaxLength(15)]
        public string Discrepancy_Label12 { get; set; }

        [MaxLength(15)]
        public string Discrepancy_Label13 { get; set; }

        [MaxLength(15)]
        public string Discrepancy_Label14 { get; set; }

        [MaxLength(15)]
        public string Discrepancy_Label15 { get; set; }

        [MaxLength(15)]
        public string Discrepancy_Label2 { get; set; }

        [MaxLength(15)]
        public string Discrepancy_Label3 { get; set; }

        [MaxLength(15)]
        public string Discrepancy_Label4 { get; set; }

        [MaxLength(15)]
        public string Discrepancy_Label5 { get; set; }

        [MaxLength(15)]
        public string Discrepancy_Label6 { get; set; }

        [MaxLength(15)]
        public string Discrepancy_Label7 { get; set; }

        [MaxLength(15)]
        public string Discrepancy_Label8 { get; set; }

        [MaxLength(15)]
        public string Discrepancy_Label9 { get; set; }

        [MaxLength(15)]
        public string Discrepancy_Trade1 { get; set; }

        public string Discrepancy_Trade10 { get; set; }
        [MaxLength(15)]
        public string Discrepancy_Trade11 { get; set; }

        [MaxLength(15)]
        public string Discrepancy_Trade12 { get; set; }

        [MaxLength(15)]
        public string Discrepancy_Trade13 { get; set; }
        [MaxLength(15)]
        public string Discrepancy_Trade14 { get; set; }

        [MaxLength(15)]
        public string Discrepancy_Trade15 { get; set; }
        [MaxLength(15)]
        public string Discrepancy_Trade2 { get; set; }

        [MaxLength(15)]
        public string Discrepancy_Trade3 { get; set; }

        [MaxLength(15)]
        public string Discrepancy_Trade4 { get; set; }
        [MaxLength(15)]
        public string Discrepancy_Trade5 { get; set; }

        [MaxLength(15)]
        public string Discrepancy_Trade6 { get; set; }

        [MaxLength(15)]
        public string Discrepancy_Trade7 { get; set; }
        [MaxLength(15)]
        public string Discrepancy_Trade8 { get; set; }

        [MaxLength(15)]
        public string Discrepancy_Trade9 { get; set; }

        
        public byte DiscSECFees { get; set; }

        public byte DiscSettlementDate { get; set; }
        public byte DiscTradeDate { get; set; }
        
        public byte DiscTransactionCode { get; set; }
        public byte DiscUnitCost { get; set; }

        public byte DiscUnitPrice { get; set; }

        public byte DoNotAffirm { get; set; }
        public double? EconomicBenefit { get; set; }
        public string ExecutingBrokerBIC { get; set; }
        
        public string ExecutingBrokerName { get; set; }

        public string ExecutingFIN { get; set; }
        public int Failed { get; set; }
        public byte FlagBondIndicator { get; set; }
        public byte FlagDeleted { get; set; }
        public byte FlagImpliedCommission { get; set; }
        public byte FlagIPO { get; set; }
        public byte FlagManualChange { get; set; }
        public byte FlagModifiedByComputer { get; set; }
        public byte FlagTradeAffirmed { get; set; }
       // [DisplayName("Fund MEI:")]
        public string FundMEI { get; set; }
        public double? FxRate { get; set; }
        public int? History { get; set; }
        public int? IDNumber { get; set; }
       // [DisplayName("ISIN:")]
        public string ISIN { get; set; }
       // [DisplayName("Isitc Type:")]
        public string ISITCIssueType { get; set; }
       public string IsOnHold { get; set; }
        public string issue_desc { get; set; }
        public string lastchangedby { get; set; }
        [DataType(DataType.Date)]
        public DateTime? lastchangeddate { get; set; }
        public string LoanXId { get; set; }
       // [DisplayName("Long/Short:")]
        public string LongShort { get; set; }
       // [DisplayName("Markit Entity:")]
        public string MarkitEntityID { get; set; }
        public string MatchStatus { get; set; }
        public double? mCommission { get; set; }
        public double? mCurrenFactor { get; set; }
        public double? mFederalTax { get; set; }
        [MaxLength(1)]
        public string MgrCode1 { get; set; }

        [MaxLength(1)]
        public string MgrCode2 { get; set; }

        [MaxLength(1)]
        public string MgrCode3 { get; set; }

        [MaxLength(1)]
        public string MgrCode4 { get; set; }

        [MaxLength(1)]
        public string MgrCode5 { get; set; }

        [MaxLength(1)]
        public string MgrCode6 { get; set; }

        public double? mIncome { get; set; }
        public string mInstitutionNo { get; set; }
        public double? mNetAmount { get; set; }
        public double? mNumberofShares { get; set; }
        public double? mOriginalFace { get; set; }

        public double? mOtherFee { get; set; }

        public double? mPrincipalAmount { get; set; }
        
        public double? mSECFees { get; set; }
       // [DisplayName("Settle:")]
       // [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd MMM yyyy}")]
        [DataType(DataType.Date)]
        public DateTime? mSettlementDate { get; set; }

       // [DisplayName("Traded:")]
        [DataType(DataType.Date)]
       // [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime? mTradeDate { get; set; }
       // [DisplayName("B/S:")]
        public string mTransactionCode { get; set; }

        public double? mUnitCost { get; set; }

        
        
        public double? mUnitPrice { get; set; }

        
        public double? NetBack { get; set; }

        
        public string NotifyComment { get; set; }

        
       // [DisplayName("Notify:")]
       // [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd MMM yyyy}")]
        [DataType(DataType.Date)]
        public DateTime? NotifyDate { get; set; }
       // [DisplayName("Notify Status:")]
        public string NotifyStatus { get; set; }
 
        public string nullport { get; set; }

        public double? OriginalCostBase { get; set; }

        public double OriginalCostLocal { get; set; }
       // [DisplayName("Name:")]
        public string PortName { get; set; }
        public string PortNo { get; set; }
       // [DisplayName("Port 2:")]
        public string PortNo2 { get; set; }

        public string portnum { get; set; }

        
        
        public string ProblemCode { get; set; }

        public string Reference { get; set; }
        public string SecurityType { get; set; }
        
        public int? Settled { get; set; }

        
        public string SettlementInstructions { get; set; }

        
        public string SettlementLoc { get; set; }

        public string SettlementNumber { get; set; }
       // [DisplayName("Settlement Type:")]
        public string SettlementType { get; set; }
       // [DisplayName("Broker:")]
        public string ShawBrokerCode { get; set; }

        
        public string ShawBrokerReasonCode { get; set; }

        public string ShawOrderLineNo { get; set; }
       // [DisplayName("Port No:")]
        public string ShawPortNo { get; set; }
        
        public string Side2 { get; set; }

        
        
        public double? StampDuty { get; set; }
       // [DisplayName("Security:")]
        public string StockName { get; set; }
       // [DisplayName("Symbol:")]
        public string StockSymbol { get; set; }

        
        public string StockSymbol2 { get; set; }

        
        
        public int? tblShawPort { get; set; }

        
        public int? tdConfirm { get; set; }

        
        
        
        
        public int? tdFilePath { get; set; }
        public string tdTradeString { get; set; }
        public string tdTradesListString { get; set; }
        public int? tdTrade { get; set; } 
        
        public int? tdxLocationID { get; set; } 
       // [DisplayName("Security Type:")]
        public int? tdxSecurityType { get; set; }

     
        public int tdxSettlementType { get; set; }

     
        public byte[] timestamp { get; set; }

      
        public double? TotalNetProceeds { get; set; }

       // [DisplayName("Block ID:")]
        public long? trade_block { get; set; }

        
        public string TradeComments { get; set; }

        public int TradeFlat { get; set; }


       // [DisplayName("Match")]
       // [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd MMM yyyy}")]
        [DataType(DataType.Date)]
        public DateTime? TradeMatchDate { get; set; }

        public int? TradeNotifyCode { get; set; }

       // [DisplayName("Trade Ref:")]
        public string TradeRefNo { get; set; } 
       // [DisplayName("Trade As:")]
        public string TradesAs { get; set; }

        
        
        
        
        public string TranCode { get; set; }


       // [DisplayName("Posted:")]
       // [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd MMM yyyy}")]
        [DataType(DataType.Date)]
        public DateTime? TranDate { get; set; }

        
       // [DisplayName("Loaded:")]
       // [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd MMM yyyy}")]
        [DataType(DataType.Date)]
        public DateTime? TransactionLoadDate { get; set; }
       // [DisplayName("User Code:")]
        public string UserCode { get; set; } 
       // [DisplayName("User Transactions:")]
        public string UserTransactionID1 { get; set; }

        
        public string UserTransactionID2 { get; set; }

        
        
        
        
        
        public double? ValueAddedTax { get; set; } 
        
        
        
    }
}