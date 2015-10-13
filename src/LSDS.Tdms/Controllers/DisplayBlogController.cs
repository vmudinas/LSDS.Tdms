using Microsoft.AspNet.Mvc;
using System;
using System.Linq;


namespace Tdms.Controllers
{
    public class DisplayBlogController : Controller
    {
        public IActionResult DisplayBlob()
        {
            return View("EditorTemplates/Currency");
        }

        [HttpGet]
        public FileResult DownloadFile(string strFileName, int logId)
        {
            //var controller = new TDMSNotificationController();
            //var fileStoreDs = controller.GetFileStoreByLogAndFile(User.Identity.Name, logId, strFileName);
            //var strContentType = "";

            //if (fileStoreDs.Tables["FileStore"].Rows.Count <= 0)
            //    return File((byte[]) null, strContentType, strFileName);
            //strContentType = ReturnContentType(fileStoreDs.Tables["FileStore"].Rows[0]["FileType"].ToString());
            //var fileContent = (byte[]) fileStoreDs.Tables["FileStore"].Rows[0]["FileContent"];

            // return File(fileContent, strContentType, strFileName);
            throw new NotImplementedException();
        }

        private static string ReturnContentType(string fileExtension)
        {
            var strReturn = "";

            switch (fileExtension.ToLower())
            {
                case "pdf":
                    strReturn = "application/pdf";
                    break;

                case "txt":
                    strReturn = "text/plain";
                    break;

                case "ok":
                    strReturn = "text/plain";
                    break;

                case "err":
                    strReturn = "text/plain";
                    break;
                case "csv":
                    strReturn = "text/csv";
                    break;
                case "xls":
                    strReturn = "application/vnd.ms-excel";
                    break;

                case "doc":
                    strReturn = "application/msword";
                    break;

                default:
                    //strReturn = "text/html";
                    strReturn = "text/plain";
                    break;
            }

            return strReturn;
        }
    }
}