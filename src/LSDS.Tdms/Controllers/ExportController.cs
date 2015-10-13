


using LSDS.Tdms.Models.TdmsDataModel;
using Microsoft.AspNet.Mvc;

namespace Tdms.Controllers
{
    public class ExportController : Controller
    {
        // GET: Export
        [HttpPost]
        public IActionResult ExcelExport()
        {
            var newTradeView = new TradeView();
            return Json(newTradeView.ReturnTradeViewDataAll(User.Identity.Name));
        }
    }
}