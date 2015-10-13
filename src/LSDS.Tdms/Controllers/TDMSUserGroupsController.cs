using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Mvc;

namespace Tdms.Controllers
{
    public class TDMSUserGroupsController : Controller
    {
        //
        // GET: /TDMSUserGroups/
        public IActionResult TDMSUserGroups()
        {
            return View();
        }
	}
}