using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LSDS.Tdms.Models.TdmsDataModel
{
    public class TdmsMenu
    {
        public string text { get; set; }
        public string url { get; set; }
        public string ImageUrl { get; set; }
        [Key]
        public string ItemSortCode { get; set; }
        public string ItemParent { get; set; }
        public string ItemLine { get; set; }
        public List<TdmsMenu> items { get; set; }
    }
}