using System;
using System.ComponentModel.DataAnnotations;

namespace LSDS.Tdms.Models.TdmsDataModel
{
    public class UspReturnVersion
    {
       [Key]
       public string project_name { get; set; }
    }
}