


using LSDS.Tdms.Models;
using LSDS.Tdms.Models.TdmsDataModel;
using Microsoft.AspNet.Mvc;

namespace LSDS.Tdms.Controllers
{
    public class ExportController : Controller
    {
        private TdmsDbContext _context;
        public ExportController(TdmsDbContext context)
        {
            _context = context;
        }
        // GET: Export
        [HttpPost]
        public IActionResult ExcelExport()
        {
            var newTradeView = new TradeView();
            return Json(newTradeView.ReturnTradeViewDataAll(User.Identity.Name, _context));
        }
    }
}