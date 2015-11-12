using LSDS.Tdms.Models.TdmsDataModel;
using LSDS.Tdms.Repository;
using Microsoft.AspNet.Mvc;
using System.Data.SqlClient;
using System.Linq;
using LSDS.Tdms.Models;
using Microsoft.AspNet.Identity;


namespace LSDS.Tdms.Controllers
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
            return Json(null); 
            var controller = RouteData.Values["controller"].ToString(); //"";//Request?.UrlReferrer?.Segments?.Skip(1).Take(1)?.SingleOrDefault()?.Trim('/');
            
            if (string.IsNullOrWhiteSpace(controller)) return Json(null);

            var DataAccessLibrary = new GenericRepository<usp_ReturnSecurityAccess_Result>();
         
            var sqlParams = new[] {
            new SqlParameter("@user_name", User.Identity.Name) 
            };
            
            return Json(new {result = DataAccessLibrary.ExecuteStoredProcedure("usp_ReturnSecurityAccess @user_name", sqlParams).Where(c => c.item_name == controller)});
        }
	}
}