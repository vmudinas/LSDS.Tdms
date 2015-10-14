using LSDS.Tdms.Models;
using LSDS.Tdms.Models.Code;
using LSDS.Tdms.Models.TdmsDataModel;
using LSDS.Tdms.Repository;
using Microsoft.AspNet.Mvc;
using System.Collections.Generic;


namespace LSDS.Tdms.Controllers
{
    public class QuickFindController : Controller
    {
        //  private static readonly QuickFindSortRepository DataAccessLibrary = new QuickFindSortRepository();
        //   private static readonly Repository Repository = new Repository();
        private TdmsDbContext _context;
        // GET: /QuickFind/
        [AcceptVerbs]
        public IActionResult QuickFindPage(string source)
        {
            var tableDetail = new GetTableDetail();
            ViewBag.NameList = ReturnQuickFind(source, false);
            return View(tableDetail.ReturnTableDetailData(source, User.Identity.Name, true));
        }

        public IActionResult GetAutoComplete(string columnName, string source)
        {
            var repo = new Repository.Repository(_context);
            return Json(repo.GetAutoComplete(columnName, source, User.Identity.Name));
        }
        private IEnumerable<QuickfindMC> ReturnQuickFind(string source, bool system)
        {
            var repo = new QuickFindSortRepository(_context);
            return repo.ReturnQuickFind(source,system,User.Identity.Name);
        }
        [AcceptVerbs]
        public bool GetCheckBox(string itemid)
        {
            //using (var dbContext = new EntitiesModel())
            //{
            //    var columnList = "new (" + itemid + ")";
            //    var parameters = new DbParameter[1];
            //    parameters[0] = new OAParameter("user_name", User.Identity.Name);

            //    var linqQuery = dbContext.ExecuteQuery<TradeListModel>("usp_returnTradeList_Query",
            //        CommandType.StoredProcedure, parameters).Select(columnList).Distinct();
            //    var result = false;
            //    foreach (var item in linqQuery)
            //    {
            //        result = item;
            //    }


            //}
            return false;
        }
	}
}