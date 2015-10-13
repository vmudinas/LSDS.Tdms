namespace LSDS.Tdms.Models.TdmsDataModel
{
    public class SearchModel
    {
        public bool IsCheckBox { get; set; }
        public string Value { get; set; }
        public string Filter { get; set; }
        public int DateRange1 { get; set; }
        public int DateRange2 { get; set; }
        public string DateRangeFilter { get; set; }
    }
}
