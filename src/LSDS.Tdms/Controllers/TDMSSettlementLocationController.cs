using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Mvc;

namespace Tdms.Controllers
{
    public class TDMSSettlementLocationController : Controller
    {
        //
        // GET: /TDMSSettlementLocation/
        public IActionResult TDMSSettlementLocation()
        {
            return View();
        }
	}
}