using LSDS.Tdms.Models;
using LSDS.Tdms.Repository;
using Microsoft.AspNet.Mvc;
using System.Linq;
using System.Threading.Tasks;

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
        public async Task<JsonResult> GetLocationList()
        {
           var repo = new LocationRepository(_context);
            return Json(await repo.GetLocationList(User.Identity.Name));
        }
  

         [AcceptVerbs]
        public JsonResult UpdateLocationList(string tdUserGroupId)
        {
            var repo = new LocationRepository(_context);
            return Json(new { result = repo.UpdageLocation(User.Identity.Name,tdUserGroupId) });
        }
	}
}