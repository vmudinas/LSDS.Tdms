using Microsoft.AspNet.Mvc;
using LSDS.Tdms.Repository;
using System.Collections;

namespace Tdms.Controllers
{
    public class AttachFileController : Controller
    {
        [HttpPost]
        public IActionResult AttachmentUpload()
        {
            //var file = Request.Files["myFile"];
            //var idList = Request.Form.GetValues("hiddenInput");

            //if (file == null) return Json(new { result = "No File Selected." });
            //var s = file.InputStream;
            //var appData = new byte[file.ContentLength + 1];
            //s.Read(appData, 0, file.ContentLength);
            //if (idList != null)
            //    SaveToFileStore(file.FileName, appData, User.Identity.Name, file.ContentType, idList[0]);

            return View("TradeList", "TradeList");
        }
        private  bool SaveToFileStore(string fileName, IEnumerable fileImage, string userId, string fileType, string tdTradeList)
        {
            var blSuccess = false;
            try
            {
                FileRepository repo = new FileRepository();
                repo.SaveToFileStore(fileName, fileImage, userId, fileType, tdTradeList);

                blSuccess = true;
            }
            catch (System.Exception ex)
            {
                //Log exception
                blSuccess = false;
                // throw new TDMSDalcException(this.AppUserId, String.Format(CultureInfo.CurrentCulture, ResourceMgr.GetString("RES_ExceptionSaveToFileStore"), ex.Message), ex, this.ToString());
            }
            return blSuccess;
        }
    }
}