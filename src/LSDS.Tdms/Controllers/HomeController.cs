
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
using System.Security.Claims;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;

namespace LSDS.Tdms.Controllers
{

    [Authorize]
    public class HomeController : Controller
    {
        private TdmsDbContext _context;
        protected ApplicationDbContext ApplicationDbContext { get; set; }
        protected UserManager<ApplicationUser> UserManager { get; set; }


       
        public HomeController(IServiceProvider services)
        {
            UserManager = services.GetRequiredService<UserManager<ApplicationUser>>();
            _context = services.GetService<TdmsDbContext>();
        }
        public IActionResult TdmsPortal()
        {
            
            ViewBag.Message = "Welcome to TDMS";
            return View();
        }



        #region Widgets
        [AcceptVerbs]
        public  JsonResult BrokerPerformance(string time)
        {
            var intTimePeriod = 0;
            int.TryParse(time, out intTimePeriod);

            return Json(_context.Set<usp_ReturnBrokerPerformance_Result>().FromSql(@"EXEC usp_ReturnBrokerPerformance @user_name={0}, @TimePeriod={1}", User.Identity.Name, intTimePeriod)?.ToList());        

        }
        
        [AcceptVerbs]
        public JsonResult ReturnWidgetLocation(string userName)
        {
            return Json(_context.Set<usp_ReturnWidgetLocation_Result>().FromSql(@"EXEC usp_ReturnWidgetLocation @user_name={0}", User.Identity.Name)?.ToList());
        }

        
        [AcceptVerbs]
        public JsonResult NotificationJobStatus(string userId)
        {
            return Json(_context.Set<usp_ReturnPackageMaintenanceListHome>().FromSql(@"EXEC usp_ReturnPackageMaintenanceListHome @NotificationOnly={0}, @UserId={1} ",  true, User.Identity.Name)?.ToList());      
        }
        [AcceptVerbs]
        public JsonResult SavedReports(string userId)
        {
            return Json(_context.Set<usp_ReturnUserSavedReports_Result>().FromSql(@"EXEC usp_ReturnUserSavedReports @user_name={0}", User.Identity.Name)?.ToList());
        }

        [AcceptVerbs]
        public JsonResult ImportSummary(string days)
        {
            var intTimePeriod = 0;
            int.TryParse(days, out intTimePeriod);
            return Json(_context.Set<usp_ReturnImportSummary_Result>().FromSql(@"EXEC usp_ReturnImportSummary @User_name={0}, @Days={1}", User.Identity.Name, intTimePeriod)?.ToList());
        }

        [AcceptVerbs]
        public JsonResult SystemStatus()
        {
            return Json(_context.Set<usp_ReturnSystemStatus>().FromSql(@"EXEC usp_ReturnSystemStatus @AllGroups={0} ", false)?.ToList());
        }

        [AcceptVerbs]
        public  JsonResult RepairStatusData(string source, bool totals = true, bool txnSide = true, bool notifyType = true)
        {
            var columnName = GetQuickFindColumnList(source, 1);         

            switch (source)
                {
                    case "TradeRepairStatusModule":
                    var RepairStatus =_context.Set<usp_ReturnRepairStatusData_Result>().FromSql(@"EXEC usp_ReturnRepairStatusData  @p0, @p1 ", string.Join("$", GetQuickFindColumnIDList(source, 1)), User.Identity.Name).ToList();
                    var newColumnListRepairStatus = columnName.Select(value => new usp_ReturnRepairStatusData_Result
                    {
                        Description = value,
                        Total = 0
                    }).ToList();
                    var uspReturnRepairStatusDataResultsR = RepairStatus as IList<usp_ReturnRepairStatusData_Result> ?? RepairStatus.ToList();
                    foreach (var item in newColumnListRepairStatus)
                    {
                        var item1 = item;
                        foreach (var itemTotals in uspReturnRepairStatusDataResultsR.Where(itemTotals => item1.Description == itemTotals.Description))
                        {
                            item.Total = itemTotals.Total;
                        }
                    }

                    return Json(newColumnListRepairStatus.ToList());
                default:
                      
                                        
                    var dMatchStatus =  _context.Set<usp_ReturnRepairStatusData_Result>().FromSql(@"EXEC usp_ReturnTradeStatusData @p0, @p1, @p2, @p3, @p4 ", string.Join("$", GetQuickFindColumnIDList(source, 1)), User.Identity.Name, totals, txnSide, notifyType).ToList();

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
      
     

        private List<int> GetQuickFindColumnIDList(string sourceName, int system)
        {
            return  _context.Set<usp_returnquickfind>().FromSql(@"EXEC usp_returnquickfind @p0, @p1, @p2", User.Identity.Name, sourceName, system)?.Select(a=>a.QuickfindID)?.ToList();
         
        }
        private List<string> GetQuickFindColumnList(string sourceName, int system)
        {
            return _context.Set<usp_returnquickfind>().FromSql(@"EXEC usp_returnquickfind @p0, @p1, @p2", User.Identity.Name, sourceName, system)?.Select(a => a.Description)?.ToList();

        }


        #endregion


        #region Gridster
        // GET: /Gridster/
        [HttpPost]
        public IActionResult UpdateGridster(List<tdGridsterModel> list)
        {
            var repo = new Repository.LocationRepository(_context);
            repo.Gridster.UpdateGridster(list,User.Identity.Name, _context);

            return Json(new { result = "success" });
        }

        [AcceptVerbs]
        public IActionResult GetGridster()
        {

            return Json( _context.Gridster.Where(x => x.user_name == User.Identity.Name));
        }

        #endregion
        private static List<Dictionary<string, object>> ReturnJsonString(DataTable dt)
        {
            var rows = (from DataRow dr in dt.Rows select dt.Columns.Cast<DataColumn>().ToDictionary(col => col.ColumnName, col => dr[col])).ToList();
            return rows;
        }
    }
}