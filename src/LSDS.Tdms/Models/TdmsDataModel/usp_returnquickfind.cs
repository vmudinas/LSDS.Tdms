using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LSDS.Tdms.Models.TdmsDataModel
{
    public class usp_returnquickfind
    {
        [Key]
        public int QuickfindID { get; set; }
        [MaxLength(100)]
        public string SourceName { get; set; }
        [MaxLength(100)]
        public string user_name { get; set; }
        
        [MaxLength(250)]
        public string Description { get; set; }
        public bool? SystemQF { get; set; }
        public bool? LastUsed { get; set; }
        public bool? LastUsedToday { get; set; }
        public bool? LastUsedRow { get; set; }
        public bool? LastUsedPage { get; set; }
    }
}
