using System.ComponentModel.DataAnnotations;

namespace LSDS.Tdms.Models.TdmsDataModel
{
    public class usp_returnUserData
    {
        [Key]
        public int tdUserGroupId { get; set; }
    }
}