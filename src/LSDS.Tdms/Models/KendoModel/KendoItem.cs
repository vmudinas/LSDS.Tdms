using System.Collections.Generic;

namespace LSDS.Tdms.Models.KendoModel
{
    public class KendoItem
    {
        public string field { get; set; }
        public string title { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public string format { get; set; }
        public string type { get; set; }
        public string template { get; set; }
        public string footerTemplate { get; set; }
        public KendoGridModel model { get; set; }
        public KendoGridAttributes attributes { get; set; }
        public string LinkCommand { get; set; }
        public IEnumerable<KendoGridAggregates> aggregateList { get; set; }
        public KendoGridAggregates aggregate { get; set; }
    }
}