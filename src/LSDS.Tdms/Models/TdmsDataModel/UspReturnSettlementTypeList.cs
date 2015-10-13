using System.ComponentModel.DataAnnotations;

namespace LSDS.Tdms.Models.TdmsDataModel
{
    public class UspReturnSettlementTypeList
    {
        public int tdxSettlementType { get; set; } 
        [MaxLength(12)]
        public string SettlementTypeCode { get; set; } 
        [MaxLength(12)]
        public string Description { get; set; } 
    }

}
