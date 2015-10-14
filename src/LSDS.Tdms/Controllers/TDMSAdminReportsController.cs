using Microsoft.AspNet.Mvc;

namespace LSDS.Tdms.Controllers
{
    public class TDMSAdminReportsController : Controller
    {
        public IActionResult TDMSAdminReports()
        {
            return View();
        }
	}
}