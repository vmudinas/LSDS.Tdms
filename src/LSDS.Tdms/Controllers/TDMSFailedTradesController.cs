using LSDS.Tdms.Models;
using LSDS.Tdms.Repository;
using Microsoft.AspNet.Mvc;
using System.Linq;

namespace LSDS.Tdms.Controllers
{
    public class TDMSFailedTradesController : Controller
    {
        private TdmsDbContext _context;
        public TDMSFailedTradesController(TdmsDbContext context)
        {
            _context = context;
        }
        //private static readonly Repository _DataAccessLibrary = new Repository();
        // GET: /TDMSFailedTrades/
        [AcceptVerbs]
        public IActionResult TDMSFailedTrades(string idList)
         {
             ViewBag.idList = idList;

                var rep =  new Repository.Repository(_context);
                var reasonCodes = rep.ReturnFailCodesList();
                ViewBag.reasonCodes = reasonCodes.ToList();

                var gridData = Json(rep.ReturnFailedTradeGrid(idList,User.Identity.Name));
                 ViewBag.gridData = gridData;

            return PartialView();
        }
         [AcceptVerbs]
         public IActionResult TDMSFailedTradesSave(string idList, int tdxfailurereason, string resolveddate, string comment)
         {
             ViewBag.idList = idList;
            var rep = new Repository.Repository(_context);
            return Json(new { success = rep.TdmsFailedTradesSave(idList, tdxfailurereason, resolveddate, comment,User.Identity.Name) });
         }
        
	}
}