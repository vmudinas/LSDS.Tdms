using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LSDS.Tdms.Models.TdmsDataModel
{
    public class QuickSortItem
    {
        [Key]
        public string val { get; set; }
        public string text { get; set; }
    }
}
