using LSDS.Tdms.Repository;
using Microsoft.AspNet.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Tdms.Controllers
{
    public class LocationController : Controller
    {
        private static readonly LocationRepository DataAccessLibrary = new LocationRepository();
        [AcceptVerbs]
        public async Task<JsonResult> GetLocationList()
        {
            return Json(await DataAccessLibrary.GetLocationList(User.Identity.Name));
        }
  

         [AcceptVerbs]
        public JsonResult UpdateLocationList(string tdUserGroupId)
        {
            return Json(new { result = DataAccessLibrary.UpdageLocation(User.Identity.Name,tdUserGroupId) });
        }
	}
}