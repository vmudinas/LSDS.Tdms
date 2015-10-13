using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Mvc;

namespace Tdms.Controllers
{
    public class TDMSTradeResolutionController : Controller
    {
        //
        // GET: /TDMSTradeResolution/
       [AcceptVerbs]
        public IActionResult TDMSTradeResolution()
        {
            return PartialView();
        }
	}
}