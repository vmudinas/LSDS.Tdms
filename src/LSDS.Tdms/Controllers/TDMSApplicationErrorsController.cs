using Microsoft.AspNet.Mvc;

namespace LSDS.Tdms.Controllers
{
    public class TDMSApplicationErrorsController : Controller
    {
        public IActionResult TDMSApplicationErrors()
        {
            return View();
        }
	}
}