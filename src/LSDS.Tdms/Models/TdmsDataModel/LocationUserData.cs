using System;
using System.ComponentModel.DataAnnotations;

namespace LSDS.Tdms.Models.TdmsDataModel
{
    public class LocationUserData
    {
        [Key]
        public int tdUserGroupID { get; set; }
        public int tdxLocationID { get; set; }
        public string User_Group_Name { get; set; }
        public string User_Group_Description { get; set; }
        public DateTime Last_Update { get; set; }
        public string Update_By { get; set; }
        public bool Selected { get; set; }
    }
}