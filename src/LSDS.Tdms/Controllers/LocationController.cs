using LSDS.Tdms.Models;
using LSDS.Tdms.Repository;
using Microsoft.AspNet.Authentication;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Authorization;
using LSDS.Tdms.Models.TdmsDataModel;
using LSDS.Tdms.Models.Code;
using Microsoft.Data.Entity;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Framework.DependencyInjection;
using System.Threading.Tasks;
using System.Data;
using System.Security.Claims;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace LSDS.Tdms.Controllers
{
    [Authorize]
    public class LocationController : Controller
    {

        private TdmsDbContext _context;
        public LocationController(TdmsDbContext context)
        {
            _context = context;
        }
        
        [AcceptVerbs]
        public JsonResult GetLocationList()
        {

            var repo = new LocationRepository(_context);
            return Json(repo.GetLocationList(User.Identity.Name));

        }
  

         [AcceptVerbs]
        public JsonResult UpdateLocationList(string tdUserGroupId)
        {
            var repo = new LocationRepository(_context);
            return Json(new { result = repo.UpdageLocation(User.Identity.Name,tdUserGroupId) });
        }
	}
}