using LSDS.Tdms.Models.TdmsDataModel;
using System.Collections.Generic;


namespace LSDS.Tdms.Models.Code
{
    public partial class QuickSortCode
    {
        public QuickSortItem QuickSortName { get; set; }

        public IEnumerable<QuickSort> GetQuickSortName(string userName, string source, TdmsDbContext context)
        {
            var newItem = new ReturnQuickFindSort(context);
            return newItem.ReturnQuickSort(userName, source, true);
        }
    }
}
