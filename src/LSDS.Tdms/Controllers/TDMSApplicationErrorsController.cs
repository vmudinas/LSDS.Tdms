using Microsoft.AspNet.Mvc;

namespace Tdms.Controllers
{
    public class TDMSApplicationErrorsController : Controller
    {
        public IActionResult TDMSApplicationErrors()
        {
            return View();
        }
	}
}