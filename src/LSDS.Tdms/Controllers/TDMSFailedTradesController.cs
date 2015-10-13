using LSDS.Tdms.Repository;
using Microsoft.AspNet.Mvc;
using System.Linq;

namespace Tdms.Controllers
{
    public class TDMSFailedTradesController : Controller
    {
        private static readonly Repository _DataAccessLibrary = new Repository();
        // GET: /TDMSFailedTrades/
         [AcceptVerbs]
        public IActionResult TDMSFailedTrades(string idList)
         {
             ViewBag.idList = idList;

                var reasonCodes = _DataAccessLibrary.ReturnFailCodesList();
                ViewBag.reasonCodes = reasonCodes.ToList();

                var gridData = Json(_DataAccessLibrary.ReturnFailedTradeGrid(idList,User.Identity.Name));
                 ViewBag.gridData = gridData;

            return PartialView();
        }
         [AcceptVerbs]
         public IActionResult TDMSFailedTradesSave(string idList, int tdxfailurereason, string resolveddate, string comment)
         {
             ViewBag.idList = idList;
             return Json(new { success = _DataAccessLibrary.TdmsFailedTradesSave(idList, tdxfailurereason, resolveddate, comment,User.Identity.Name) });
         }
        
	}
}