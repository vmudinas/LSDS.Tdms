using System.Collections.Generic;

namespace LSDS.Tdms.Models.KendoModel
{
    public class KendoGridItems
    {
        public int Take { get; set; }
        public int Skip { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public IEnumerable<KendoGridSort> Sort { get; set; }
      //  public KendoGridFilter[] Filter { get; set; }
        public Filter filter { get; set; }
        public string IdList { get; set; }
        public string Source { get; set; }
        public string StoreProcedureName { get; set; }
        public bool ConfirmCheck { get; set; }
        public bool ChkPortNo { get; set; }
        public bool ChkTraded { get; set; }
        public bool ChkSecId { get; set; }
        public bool ChkBs { get; set; }
        public bool ChkBrokerFIN { get; set; }
        public string tdTrade { get; set; }
        public string ConfirmRefNo { get; set; }
    }
}