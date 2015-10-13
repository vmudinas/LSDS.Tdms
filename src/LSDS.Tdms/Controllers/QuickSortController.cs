using LSDS.Tdms.Models.Code;
using LSDS.Tdms.Repository;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Immutable;

namespace Tdms.Controllers
{
    public class QuickSortController : Controller
    {
        private static readonly QuickFindSortRepository _DataAccessLibrary = new QuickFindSortRepository();
        // GET: /QuickSort/
     [AcceptVerbs]
        public IActionResult QuickSortPage(string source)
        {
            var tableDetail = new GetTableDetail();

            return PartialView(tableDetail.ReturnTableDetailData(source, User.Identity.Name, true));
        }

        public IActionResult GetAutoComplete(string columnName, string source)
        {
            return Json(_DataAccessLibrary.GetAutoComplete(columnName,source, User.Identity.Name));
        }
        [HttpPost]
        public IActionResult Save()
        {
            return null;
            /*
            var sortValues = "dddd"; //Request.Form?.GetValues("idsortValues");
            var defaultValue = "";  //Request.Form.GetValues("defaultSortCheckbox");
            var quickSortText = ""; // Request.Form.GetValues("quickSortText");
            var selectList = "llllll"; //Request.Form.GetValues("idSaveQuickSortID"); 
            var intDefault = 0;
           
            if (defaultValue != null)
            {
                intDefault = 1;
            }
           
            var quickSort = new DataAccessLibrary.EntityModels.QuickSort {SourceName = "TradeBrowser"};
            if (quickSortText != null) quickSort.Description = quickSortText[0];
            quickSort.LastUsed = false;
            quickSort.LastUsedToday = intDefault;
            if (sortValues != null) quickSort.QuickSort_Query = sortValues[0].Replace("ASC", " ASC,").Replace("DESC", " DESC,").TrimEnd(',').Replace("  ","");
            quickSort.user_name = User.Identity.Name;
            if (selectList != null  )
            {
                if (selectList[0] != "-1")
                {
                    try
                    {
                        quickSort.QuickSortID = Convert.ToInt32(selectList[0].Trim());
                    }
                    catch (System.Exception)
                    {
                        // ignored
                    }
                }
            }
            quickSort.SystemQS = false;
            var newItem = new ReturnQuickFindSort();
           newItem.InsertQuickSort(quickSort);
           return RedirectToAction("TradeList", "TradeList");
           */
        }

        [AcceptVerbs]
        public JsonResult DeleteSort(string sortId)
        {
            _DataAccessLibrary.DeleteSort(sortId);
            // Take sort name and username and remove it
            return Json(new { items = new[] { new { result = "true" } } });
        }

        [AcceptVerbs]
        public JsonResult ReturnSortName(string userName, string source)
        {
            var quickSortName = new ReturnQuickFindSort();
            return Json(quickSortName.ReturnQuickSort(userName, source));
        }
	}
}