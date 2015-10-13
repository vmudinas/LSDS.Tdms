using LSDS.Tdms.Repository;
using Microsoft.AspNet.Mvc;

namespace Tdms.Controllers
{
    public class TradePrintOptionsController : Controller
    {
        Repository _DataAccessLibrary = new Repository();
      
       
        public IActionResult TradePrintOptions()
        {
            return PartialView();
        }
                
        public JsonResult ReturnComment()
        {
            return Json(_DataAccessLibrary.ReturnComment());
        }
       
      
        public JsonResult ReturnPortfolioContact()
        {
            return Json(_DataAccessLibrary.ReturnPortfolioContact());
        }
    }
}