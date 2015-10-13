using Microsoft.AspNet.Mvc;


namespace Tdms.Controllers
{
    public class UploadFileController : Controller
    {
        // GET: UploadFile
        public IActionResult UploadFile()
        {
            return PartialView();
        }
    }
}