using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Mvc;

namespace LSDS.Tdms.Controllers
{
    public class TDMSPortfolioProfileController : Controller
    {
        //
        // GET: /TDMSPortfolioProfile/
        public IActionResult TDMSPortfolioProfile()
        {
            return View();
        }
	}
}