using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LSDS.Tdms.Models.TdmsDataModel
{
    public partial class tdGridsterModel
    {
        [Key]
        public int GridsterId { get; set; }
        public string id { get; set; }
        public string col { get; set; }
        public string row { get; set; }
        public string size_x { get; set; }
        public string size_y { get; set; }
        public string htmlContent { get; set; }
        public string user_name { get; set; }
    }
}
