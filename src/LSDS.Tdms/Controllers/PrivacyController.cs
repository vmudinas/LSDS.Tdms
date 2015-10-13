using LSDS.Tdms.Models.TdmsDataModel;
using LSDS.Tdms.Repository;
using Microsoft.AspNet.Mvc;
using System.Data.SqlClient;
using System.Linq;


namespace Tdms.Controllers
{
    public class PrivacyController : Controller
    {
        
        // GET: /Privacy/
        public IActionResult Privacy()
        {
            return View();
        }

        [AcceptVerbs]
        public JsonResult CheckSecurity()
        {
            var controller = "";//Request?.UrlReferrer?.Segments?.Skip(1).Take(1)?.SingleOrDefault()?.Trim('/');
            
            if (controller == null) return Json(null);

            var DataAccessLibrary = new GenericRepository<usp_ReturnSecurityAccess_Result>();
            var sqlParams = new[] {
            new SqlParameter("@user_name", User.Identity.Name) 
            };
             ;
            return Json(new {result = DataAccessLibrary.ExecuteStoredProcedure("usp_ReturnSecurityAccess @user_name", sqlParams).Where(c => c.item_name == controller)});
        }
	}
}