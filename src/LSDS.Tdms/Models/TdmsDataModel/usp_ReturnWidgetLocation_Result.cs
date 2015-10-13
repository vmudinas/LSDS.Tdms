
using System;

namespace LSDS.Tdms.Models.TdmsDataModel
{
    public partial class usp_ReturnWidgetLocation_Result
    {
        public int WidgetId { get; set; }
        public string WidgetIdName { get; set; }
        public Nullable<int> DataRow { get; set; }
        public Nullable<int> DataCol { get; set; }
        public Nullable<int> DataSizex { get; set; }
        public Nullable<int> DataSizey { get; set; }
        public Nullable<bool> Visible { get; set; }
        public string WidgetCheckBoxId { get; set; }
        public string user_name { get; set; }
        public Nullable<int> WidgetRefreshRate { get; set; }
        public string WidgetDisplayId { get; set; }
        public Nullable<bool> WidgetTotal { get; set; }
        public Nullable<bool> WidgetTxnSide { get; set; }
        public Nullable<bool> WidgetNotifyType { get; set; }
        public Nullable<int> WidgetTimePeriod { get; set; }
    }
}
