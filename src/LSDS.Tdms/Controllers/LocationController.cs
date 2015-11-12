using LSDS.Tdms.Models;
using LSDS.Tdms.Repository;
using Microsoft.AspNet.Mvc;
using System.Linq;
using System.Threading.Tasks;
using LSDS.Tdms.Models.TdmsDataModel;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using System;
using Microsoft.AspNet.Authentication;
using Microsoft.AspNet.Authorization;
using LSDS.Tdms.Models.Code;
using System.Data.SqlClient;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Framework.DependencyInjection;
using Microsoft.AspNet.Identity;
using System.Security.Claims;
using LSDS.Webcomponents;

namespace LSDS.Tdms.Controllers
{
    public class LocationController : Controller
    {
        //private static readonly LocationRepository DataAccessLibrary = new LocationRepository();
        private TdmsDbContext _context;
        public LocationController(TdmsDbContext context)
        {
            _context = context;
        }
        [AcceptVerbs]
        public JsonResult GetLocationList()
        {

            var groupId = _context.UserData.FromSql("EXEC usp_returnUserData @p0", User.Identity.Name);//.Select(a=>a.tdUserGroupId).FirstOrDefault();
            _context.Database.ExecuteSqlCommand("EXEC sp_SetAppUser @p0", User.Identity.Name);
            var locationList = _context.LocationUserData.FromSql("EXEC usp_ReturnUserGroups");

            //foreach (var item in locationList.ToList())
            //{
            //    item.Selected = false; // || item.tdUserGroupID == groupId
            //}

            return Json(locationList);
        }
  

         [AcceptVerbs]
        public JsonResult UpdateLocationList(string tdUserGroupId)
        {
            var repo = new LocationRepository(_context);
            return Json(new { result = repo.UpdageLocation(User.Identity.Name,tdUserGroupId) });
        }
	}
}