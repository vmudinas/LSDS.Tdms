using System.Collections.Generic;

namespace LSDS.Tdms.Models.TdmsDataModel
{
    public class TradeDetailViewModel
    {
        public string strTradeId { get; set; }
        public int intTradeId { get; set; }
        public string  TradeIdList { get; set; }
        public int? CurrentPage { get; set; }
        public int? PageCount { get; set; }
        public IEnumerable<UspReturnIsitcIssueType> IsitcIssueType { get; set; }
        public IEnumerable<UspReturnSecurityTypeList> SecurityTypeList { get; set; }
        public IEnumerable<UspReturnSettlementLocList> SettlementLocList { get; set; }
        public IEnumerable<UspReturnSettlementTypeList> SettlementTypeList { get; set; }
        public IEnumerable<UspReturnTradeDetail> TradeDetail { get; set; }
        public IEnumerable<UspReturnTradeNotifyList> TradeNotifyList { get; set; }
        public IEnumerable<UspReturnTradeRepairLog> TradeRepairLog { get; set; }
        public IEnumerable<UspReturnMatchedTradesConfirms>  MatchedTradesConfirms { get; set; }
        public IEnumerable<UspLookupNotifyStatus> LookupNotifyStatus { get; set; }
        public IEnumerable<UspLookupMatchStatus> LookupMatchStatus { get; set; }

    }
}
