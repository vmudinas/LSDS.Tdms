using System.ComponentModel.DataAnnotations;

namespace LSDS.Tdms.Models.TdmsDataModel
{
    public class UspLookupMatchStatus
    {
        [Key]
        public int tdxMatchStatus { get; set; }

        [MaxLength(12)]
        public string MatchStatusCode { get; set; } 
        [MaxLength(64)]
        public string MatchStatusDesc { get; set; }
    }

}
