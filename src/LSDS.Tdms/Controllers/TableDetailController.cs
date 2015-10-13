using LSDS.Tdms.Models.KendoModel;
using Microsoft.AspNet.Mvc;

namespace Tdms.Controllers
{
    public class TableDetailController : Controller
    {
        [AcceptVerbs]
        public JsonResult ReturnUserTableDetail(string source)
        {
            return Json(new KendoColumns().ReturnKendoColumSettings(User.Identity.Name, source));
        }

    }
}