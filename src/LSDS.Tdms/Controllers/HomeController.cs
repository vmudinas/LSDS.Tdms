
using Microsoft.AspNet.Authentication;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Authorization;
using LSDS.Tdms.Models.TdmsDataModel;
using LSDS.Tdms.Models.Code;
using Microsoft.Data.Entity;
using LSDS.Tdms.Models;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Framework.DependencyInjection;
using System.Threading.Tasks;
using System.Data;

namespace LSDS.Tdms.Controllers
{
    
    [Authorize]
    public class HomeController : Controller
    {
        // private static readonly Repository.Repository _tdmsDataAccess = new Repository();
        private TdmsDbContext _context;
        public HomeController(TdmsDbContext context)
        {
            _context = context;
        }
        public IActionResult TdmsPortal()
        {
            ViewBag.Message = "Welcome to TDMS";
            return View();
        }



        #region Widgets
        [AcceptVerbs]
        public async Task<JsonResult> BrokerPerformance(string time)
        {
            var rep  = new Repository.Repository(_context);
            var brokers =await rep.BrokerPerformance(time, User.Identity.Name);
            return Json(brokers.ToList());
        }
        
        [AcceptVerbs]
        public async Task<JsonResult> ReturnWidgetLocation(string userName)
        {
            var rep = new Repository.Repository(_context);
            var widgetLocation = await rep.ReturnWidgetLocation(User.Identity.Name);
            return Json(widgetLocation.ToList());

        }


        
        [AcceptVerbs]
        public async Task<JsonResult> NotificationJobStatus(string userId)
        {
            var rep = new Repository.Repository(_context);
            var notificationJobStatus = await rep.NotificationJobStatus(User.Identity.Name);
            return Json(notificationJobStatus.ToList());
      
        }
        [AcceptVerbs]
        public async Task<JsonResult> SavedReports(string userId)
        {
            var rep = new Repository.Repository(_context);
            var savedReports = await rep.SavedReports(User.Identity.Name);
            return Json(savedReports.ToList());

    
        }

        [AcceptVerbs]
        public async Task<JsonResult> ImportSummary(string userId, string days)
        {
            var rep = new Repository.Repository(_context);
            var importSummary = await rep.ImportSummary(User.Identity.Name, days);
            return Json(importSummary.ToList());
        }

        [AcceptVerbs]
        public async Task<JsonResult> SystemStatus()
        {
            var rep = new Repository.Repository(_context);
            var systemStatus = await rep.SystemStatus();
            return Json(systemStatus.ToList());
        }

        [AcceptVerbs]
        public async Task<JsonResult> RepairStatusData(string source, string userId, bool totals = true, bool txnSide = true, bool notifyType = true)
        {
            var rep = new Repository.Repository(_context);


            switch (source)
                {
                    case "TradeRepairStatusModule":
                        var dRepariStatus = await _context.Set<usp_ReturnRepairStatusData_Result>().FromSql("usp_ReturnRepairStatusData", User.Identity.Name, source, 1).ToListAsync();
                            return Json(dRepariStatus.ToList());
                    default:
                        var columnName =await GetQuickFindColumnList(userId, source, 1);
                                        
                    var dMatchStatus = await _context.Set<usp_ReturnRepairStatusData_Result>().FromSql("usp_ReturnTradeStatusData", User.Identity.Name, source, 1, totals, txnSide, notifyType).ToListAsync();

                    var newColumnList = columnName.Select(value => new usp_ReturnRepairStatusData_Result
                        {
                            Description = value, Total = 0
                        }).ToList();
                        var uspReturnRepairStatusDataResults = dMatchStatus as IList<usp_ReturnRepairStatusData_Result> ?? dMatchStatus.ToList();
                        foreach (var item in newColumnList)
                        {
                            var item1 = item;
                            foreach (var itemTotals in uspReturnRepairStatusDataResults.Where(itemTotals => item1.Description == itemTotals.Description))
                            {
                                item.Total = itemTotals.Total;
                            }
                        }
                        
                        return Json(newColumnList.ToList());
                 }
        }
      
     

        private async Task<IEnumerable<string>> GetQuickFindColumnList(string userId, string sourceName, int system)
        {
            var repo = new Repository.Repository(_context);
            return await repo.GetQuickFindColumnList(User.Identity.Name,sourceName,system);
        }


        #endregion

       
        #region Gridster
        // GET: /Gridster/
        [HttpPost]
        public async Task<IActionResult> UpdateGridster(List<tdGridsterModel> list)
        {
            var repo = new Repository.LocationRepository(_context);
            await repo.Gridster.UpdateGridster(list,User.Identity.Name );

            return Json(new { result = "success" });
        }

        [AcceptVerbs]
        public async Task<IActionResult> GetGridster()
        {
            var repo = new Repository.LocationRepository(_context);
            var newGridster = await repo.Gridster.GetGridster(User.Identity.Name);
            return Json(newGridster);
        }

        #endregion
        private static List<Dictionary<string, object>> ReturnJsonString(DataTable dt)
        {
            var rows = (from DataRow dr in dt.Rows select dt.Columns.Cast<DataColumn>().ToDictionary(col => col.ColumnName, col => dr[col])).ToList();
            return rows;
        }
    }
}