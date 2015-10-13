namespace LSDS.Tdms.Models.KendoModel
{
    public class Filter1
    {
        public string Field { get; set; }
        public string Operator { get; set; }
        public string Value { get; set; }
        public string Logic { get; set; }
        public Filter2[] Filters { get; set; }
    }
}