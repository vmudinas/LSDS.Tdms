using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using LSDS.Tdms.Repository;
using LSDS.Tdms.Models.TdmsDataModel;
using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Http.Internal;
using LSDS.Tdms.Models;

namespace LSDS.Tdms.Controllers
{
    [Authorize]
    public class TradeDetailController : Controller
    {
        private TdmsDbContext _context;
        public TradeDetailController(TdmsDbContext context)
        {
            _context = context;
        }
        // private readonly Repository _DataAccessLibrary = new Repository();
        [HttpPost]
        public async Task<IActionResult> TradeDetail(FormCollection model)
        {
          
            var intTdTrade = 0;
            var tempTradeIdList = model["tempTradeIdList"].ToString().Split(',');
          //  Session["tempTradeIdList"] = model["tempTradeIdList"];
            var index1 = Array.IndexOf(tempTradeIdList, model["tradeSelectedId"]);
            int.TryParse(model["tradeSelectedId"], out intTdTrade);


            if (intTdTrade < 1)
            {
                return Content("<script language='javascript' type='text/javascript'>alert('Not updated!');</script>");
            }

            ViewBag.CurrentPage = index1;
            ViewBag.TotalPages = tempTradeIdList.Count();
            return View(await ReturnModel(index1, intTdTrade, model["tempTradeIdList"], ViewBag.TotalPages));
        }
        [HttpPost]
        public IActionResult TradeDetailPager(string tdTrade, string nextPrev = "")
        {
            //     if (string.IsNullOrEmpty(Session["tempTradeIdList"]?.ToString()))
            //     {
            //      FormsAuthentication.SignOut();
            //        return RedirectToAction("Login", "Login");
            //    }
            //var tempTradeIdList = ""; Session["tempTradeIdList"].ToString().Split(',');
            //    var index1 = Array.IndexOf(tempTradeIdList, tdTrade);
            //    if (string.Equals(nextPrev, "Previous") && index1 != 0)
            //    {
            //        index1 = index1 - 1;
            //    }
            //    else if (string.Equals(nextPrev, "Next") && index1 != (tempTradeIdList.Count() - 1))
            //    {
            //        index1 = index1 + 1;
            //    }
            //    tdTrade = tempTradeIdList[index1];
            //    var intTdTrade = 0;
            //    int.TryParse(tdTrade, out intTdTrade);
            //    if (intTdTrade == 0) return Content("<script language='javascript' type='text/javascript'>alert('Pager error!');</script>");



            //    ViewBag.CurrentPage = index1+1;
            //    ViewBag.TotalPages = tempTradeIdList.Count();
            //    return View("TradeDetail",await ReturnModel(index1, intTdTrade, Session["tempTradeIdList"].ToString(), ViewBag.TotalPages));
           return View();
        }

        [HttpPost]
        public  async Task<IActionResult> UpdateDetail(UspReturnTradeDetail tradeDetailVModel)
        {
            var rep = new Repository.Repository(_context);
            return await rep.UpdateDetail(tradeDetailVModel, User.Identity.Name) > 0
                ? (ActionResult)
                    Content("<script language='javascript' type='text/javascript'>alert('Updated'); window.location='" + Request.Headers["referer"] + "'</script>")
                : Content("<script language='javascript' type='text/javascript'>alert('Not updated!');</script>");
        }
        

        public async Task<JsonResult> GetTradeRepairLog(int tdTradet)
        {
            var rep = new Repository.Repository(_context);
            var notifyList =
                await
                    rep.GetTradeRepairLog(User.Identity.Name, tdTradet);

            return Json(notifyList.ToList());
        }
        public async Task<JsonResult> GetNotifyList( int tdTradet)
        {
            var rep = new Repository.Repository(_context);
            var notifyList = await
                    rep.GetTradeRepairLogN(User.Identity.Name, tdTradet);
           
            return  Json(notifyList.ToList());
        }

        private async Task<TradeDetailViewModel> ReturnModel(int pageIndex, int tdTrade, string tdTradeString, int PageCount)
        {

            var settlementLocListRepo = new GenericRepository<UspReturnSettlementLocList>();
            var settlementTypeListRepo = new GenericRepository<UspReturnSettlementTypeList>();
            var lookupNotifyStatusRepo = new GenericRepository<UspLookupNotifyStatus>();
            var tradeDetailRepo = new GenericRepository<UspLookupMatchStatus>();
            var rep = new Repository.Repository(_context);


            var  tradeDetailModel = new TradeDetailViewModel
            {
                strTradeId = tdTradeString,
                intTradeId = tdTrade,
                PageCount = PageCount,
                TradeDetail =
                    await
                    rep.ReturnTradeDetail(User.Identity.Name, tdTrade),
                MatchedTradesConfirms =
                    await rep.ReturnMatchedTradesConfirms(User.Identity.Name, tdTrade),
                SecurityTypeList =
                   await rep.ReturnSecurityTypeList(tdTrade, 1),
                IsitcIssueType =
                     await rep.ReturnSecurityTypeList(tdTrade),              
                SettlementLocList =
                    await
                        settlementLocListRepo.ExecuteStoredProcedureAsync(
                            "usp_ReturnSettlementLocList"),
                SettlementTypeList =
                    await
                        settlementTypeListRepo.ExecuteStoredProcedureAsync(
                            "usp_ReturnSettlementTypeList"),
                LookupNotifyStatus =
                    await
                        lookupNotifyStatusRepo.ExecuteStoredProcedureAsync("usp_LookupNotifyStatus"),
                LookupMatchStatus =
                    await tradeDetailRepo.ExecuteStoredProcedureAsync("usp_LookupMatchStatus"),
                CurrentPage = pageIndex + 1
            };
               
                return tradeDetailModel;
          
        }
    }
}


