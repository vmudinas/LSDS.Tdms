using Microsoft.AspNet.Mvc;

namespace LSDS.Tdms.Controllers
{
    public class TDMSHolidayScheduleController : Controller
    {
        public IActionResult TDMSHolidaySchedule()
        {
            return View();
        }
	}
}