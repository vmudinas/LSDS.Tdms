//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace LSDS.Tdms.Models.TdmsDataModel
{
    public partial class usp_ReturnFailedTrade_Result
    {
        public int ReturnFailedTradeID { get; set; }
        public Nullable<int> tdTradeFailed { get; set; }
        public Nullable<DateTime> mTradeDate { get; set; }
        public string TradeRefNo { get; set; }
        public string CUSIPNo { get; set; }
        public string ShawPortNo { get; set; }
        public string mTransactionCode { get; set; }
        public string EnteredBy { get; set; }
        public Nullable<DateTime> EnteredDate { get; set; }
        public Nullable<int> tdxFailureReason { get; set; }
        public string FailureReason { get; set; }
        public string ResolvedBy { get; set; }
        public Nullable<DateTime> ResolvedDate { get; set; }
        public Nullable<int> SystemFail { get; set; }
        public string Comment { get; set; }
        public string CommentBy { get; set; }
        public Nullable<DateTime> CommentDate { get; set; }
        public Nullable<int> CommentReason { get; set; }
        public Nullable<int> tdTradeFailedComments { get; set; }
    }
}
