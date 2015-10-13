using Microsoft.AspNet.Mvc;
using Microsoft.Dnx.Runtime;
using System.IO;

namespace Tdms.Controllers
{
    public class HelpController : Controller
    {
        private readonly IApplicationEnvironment _appEnvironment;
        public HelpController(IApplicationEnvironment appEnvironment)
        {
            _appEnvironment = appEnvironment;
        }
        public IActionResult Help()
        {
            var filePath = _appEnvironment.ApplicationBasePath + "/Content/Support/TDMS Enterprise User Manual v5.0.pdf";
            //var fileStream = new FileStream(filePath,
            //                        FileMode.Open,
            //                        FileAccess.Read
            //                      );
            //var fsResult = new FileStreamResult(fileStream, "application/pdf");
            //return fsResult;
            return File(filePath, "application/pdf");
        }
	}
}