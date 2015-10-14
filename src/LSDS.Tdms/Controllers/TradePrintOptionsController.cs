using LSDS.Tdms.Models;
using LSDS.Tdms.Repository;
using Microsoft.AspNet.Mvc;

namespace LSDS.Tdms.Controllers
{
    public class TradePrintOptionsController : Controller
    {
    //    Repository _DataAccessLibrary = new Repository();
        private TdmsDbContext _context;
        public TradePrintOptionsController(TdmsDbContext context)
        {
            _context = context;
        }    

        public IActionResult TradePrintOptions()
        {
            return PartialView();
        }
                
        public JsonResult ReturnComment()
        {
            var rep = new Repository.Repository(_context);
            return Json(rep.ReturnComment());
        }
       
      
        public JsonResult ReturnPortfolioContact()
        {
            var rep = new Repository.Repository(_context);
            return Json(rep.ReturnPortfolioContact());
        }
    }
}