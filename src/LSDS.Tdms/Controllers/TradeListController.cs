using Microsoft.AspNet.Mvc;
using LSDS.Tdms.Models.Code;
using LSDS.Tdms.Models.TdmsDataModel;
using Microsoft.AspNet.Authorization;
using LSDS.Tdms.Models.KendoModel;

using Microsoft.Dnx.Runtime;
using LSDS.TradeManagement;
using LSDS.Tdms.Models;
using Microsoft.AspNet.Identity;

namespace LSDS.Tdms.Controllers
{
  
    public class TradeListController : Controller
    {
        private readonly IApplicationEnvironment _appEnvironment;
        private readonly TdmsDbContext _context;
        private readonly ApplicationUser _appUser;
        private UserManager<ApplicationUser> _userManager;

        public TradeListController()
        {
            
        }

        public IActionResult TradeList()
        {
            return View();
        }
        // GET: /TradeView/
         [HttpPost]
        public JsonResult TradewViewData(KendoGridItems item)
        {
            var newTradeView = new TradeView();
            var result =  newTradeView.ReturnTradeViewData(item, User.Identity.Name, _context);      
         
            return Json(result);
        }
        

        [AcceptVerbs]
        public IActionResult PrintTradeViewSelect(string contactType, string notifyType, string comment, string tradeList, string type)
        {
            var tradeViewPath = "";
            var control = ""; new TDMSControllerNavGraph {Ajax = true};
            var archive = true;
            var history = true;

           // switch (type)
           // {
           //     case "fax": 
           //         tradeViewPath = string.IsNullOrWhiteSpace(tradeList) ? control.FaxTradeView(User.Identity.Name, comment, int.Parse(notifyType), int.Parse(contactType)) : control.FaxTradeView(User.Identity.Name, tradeList, comment, int.Parse(notifyType), int.Parse(contactType), archive, history);
           //break;
           //     case"print":
           //tradeViewPath = string.IsNullOrWhiteSpace(tradeList) ? control.PrintTradeViewFileName(User.Identity.Name, _appEnvironment.ApplicationBasePath + "~/Content/PrintPDF/", comment, int.Parse(notifyType), int.Parse(contactType)) : control.PrintTradeViewFileName(User.Identity.Name, tradeList, _appEnvironment.ApplicationBasePath + "~/Content/PrintPDF/", comment, int.Parse(notifyType), int.Parse(contactType), archive, history);
         
           //         break;
           // }
                                                                                         
            var json = new
            {
                items = new[]
                {
                    new { filePath =_appEnvironment.ApplicationBasePath +"Content/PrintPDF/" + tradeViewPath, fileName = tradeViewPath }
                }
            };

            return Json(json);
        }
        public FileResult Download(string fileName,string filePath)
        {
            //usp_InsertTradesAttachment_Result attachment;
            //using (var db = new DbContext())
            //{
            //    attachment = db.FileAttachments.FirstOrDefault(x => x.Id == id);
            //}

            return File(filePath, "application/force-download"); 
        }

   
        [AcceptVerbs]
        public JsonResult TradeSort()
        {
            var newTradeViewSort = new ReturnQuickFindSort(_context);
            return Json(newTradeViewSort.ReturnQuickSort(User.Identity.Name, "TradeBrowser",true));
        }

        [AcceptVerbs]
        public JsonResult TradeFind()
        {
            var newTradeViewFind = new ReturnQuickFindSort(_context);
            return Json(newTradeViewFind.ReturnQuickFind(User.Identity.Name, "TradeBrowser", true));
        }
        [HttpPost]
        public IActionResult TradeSortUpdate(int quickSortId)
        {
            //Update QuickSort
            var sortUpdate = new ReturnQuickFindSort(_context);
            sortUpdate.UpdateSorting(User.Identity.Name, "TradeBrowser",quickSortId);
            return Json(new { success = true });
        }

        [HttpPost]
        public IActionResult TradeFindUpdate(int quickFindtId)
        {
            //Update QuickSort table LastUsedToday column 
            var findUpdate = new ReturnQuickFindSort(_context);
            findUpdate.UpdateFind(User.Identity.Name, "TradeBrowser", quickFindtId);
            return Json(new { success = true });
        }

         [AcceptVerbs]
        public IActionResult ArchiveTrade(string selectedTrades)
        {
            if (string.IsNullOrWhiteSpace(selectedTrades))
            {
                return Json(new { result = "No trades Archived." });
            }
            var returnString = ArchiveUnArchiveItems(selectedTrades, true);


            return Json(new { result = returnString});
        }
         [AcceptVerbs]
        public IActionResult UnArchiveTrade(string selectedTrades)
        {
            if (string.IsNullOrWhiteSpace(selectedTrades))
            {
                return Json(new { result = "No trades Un-Archived." });
            }
            var returnString = ArchiveUnArchiveItems(selectedTrades, false);


            return Json(new { result = returnString });
        }
      
        private string ArchiveUnArchiveItems(string selectedTrades, bool archive)
        {

            var returnString = "";

            var control = new TDMSControllerNavGraph { Ajax = true };

            returnString = control.ArchiveTrades(selectedTrades, archive, User.Identity.Name);

            if (control.Exception)
            {
                returnString = control.ReturnControllerException();
            }
            return returnString;
        }
    }

}