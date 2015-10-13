using Microsoft.AspNet.Mvc;

namespace Tdms.Controllers
{
    public class TDMSAdminReportsController : Controller
    {
        public IActionResult TDMSAdminReports()
        {
            return View();
        }
	}
}