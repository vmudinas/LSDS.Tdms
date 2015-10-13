using LSDS.Tdms.Models.KendoModel;
using LSDS.Tdms.Models.TdmsDataModel;
using LSDS.Tdms.Repository;
using LSDS.TradeManagement;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Mvc;
using Microsoft.Net.Http.Headers;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace Tdms.Controllers
{
    public class TdmsManualMatchController : Controller
    {
        private static readonly ManualMatchRepository manualMatchRepo = new ManualMatchRepository();
        [AcceptVerbs]
        public IActionResult TdmsManualMatch(string idList)
        {
            //ViewBag.TradeIds = idList;
            return PartialView();
        }

        [HttpPost]
        public IActionResult TdmsManualMatchData(KendoGridItems item)
        {
            if (!item.ConfirmCheck)
            {
             return
                Json(
                    manualMatchRepo.TdmsManualMatchData<ManualMatchTrade>(User.Identity.Name,item.IdList, item.Source, item.StoreProcedureName));
            }
            return
                Json(
                    manualMatchRepo.TdmsManualMatchData<ManualMatchTrade>(item.tdTrade, item.ChkPortNo, item.ChkTraded, item.ChkSecId, item.ChkBs, item.ChkBrokerFIN, item.ConfirmRefNo, User.Identity.Name, item.Source, item.StoreProcedureName));
        }


        private int ReturnInt(bool value)
        {
            return value ? 1 : 0;
        }

        private int UploadPostedFileMatch(IFormFile file, string fileName)
        {

            int filePathId = 0;
            try
            {
              //  //string fileName = "";
              //  string strFileType = "";
              //  DataRow objRow;
               


              //  NotificationDalc notificationDalc = new NotificationDalc(User.Identity.Name);
              //  //Return new Log Ids
              //  notificationDalc.CreateNotificationLogEntry(User.Identity.Name);
               
              //  //Extract the file name
              ////  fileName = postedFile.FileName.Substring(postedFile.FileName.LastIndexOf(@"\") + 1, postedFile.FileName.Length - (postedFile.FileName.LastIndexOf(@"\") + 1));
              //  //Extract the file type
              //  if (fileName.LastIndexOf(".") == -1)
              //      strFileType = "txt";
              //  else
              //      strFileType = fileName.Substring(fileName.LastIndexOf(".") + 1, fileName.Length - (fileName.LastIndexOf(".") + 1));

              //  FileStoreDalc fileStore = new FileStoreDalc(User.Identity.Name);

              //  //Read the File Data
              //  Stream fileDataStream = file.OpenReadStream();
           

              //  //Get length of file
              //  var fileLength = file.ContentType.Length;
              //  //Create a byte array with file length
              //  byte[] fileData = new byte[fileLength];
              //  //Read the stream into the byte array
              //  fileDataStream.Read(fileData, 0, fileLength);

              //  //Save the file to the File Store with the message Log Id and Filename as identifiers
              //  notificationDalc.AddEventToLog(notificationDalc.MasterLogID, 1095, "Save Confirm file to File Store.", 0);
              //  fileStore.SaveToFileStore(fileName, fileData, User.Identity.Name, strFileType, notificationDalc.MessageLogID);

              //  //Save to the File Path table and retrieve the id
              //  FilePathDS filePathDS = new FilePathDS();
              //  objRow = filePathDS.Tables["FilePath"].NewRow();

              // // _confirmUploadFileName = fileName;
              ////  _confirmUploadLogId = notificationDalc.MessageLogID;

              //  objRow["iomessageLog"] = notificationDalc.MessageLogID;
              //  objRow["FileName"] = fileName;
              //  objRow["user_name"] = User.Identity.Name;
              //  objRow["date_time"] = DateTime.Now;
              //  objRow["tdMasterLog"] = notificationDalc.MasterLogID;

              //  filePathDS.Tables["FilePath"].Rows.Add(objRow);

              //  //Update the File Path table
              //  FilePathDalc filePathDalc = new FilePathDalc(User.Identity.Name);
              //  notificationDalc.AddEventToLog(notificationDalc.MasterLogID, 1095, "Update File Path.", 0);
              //  filePathDalc.UpdateFilePath(filePathDS);
              //  //return the File Path Id
              //  filePathId = (int)objRow["tdFilePath"];

            }
            catch (System.Exception e)
            {
                //Log Me please;
                return 0;

           }
            return filePathId;        
        }
         [HttpPost]
        public IActionResult ManualMatch(IList<IFormFile> files)
        {
            var returnResult= "";
            foreach (var file in files)
            {
                var fileName = ContentDispositionHeaderValue
                .Parse(file.ContentDisposition)
                .FileName
                .Trim('"');
                // IFormFile m["btnFindHardCopy"]
                var control = new TDMSControllerNavGraph();
             
                var confirmId = 0;
                var confirmList = CheckForNull(Request.Form["confirmList"]);
                if (file != null)
                {
                    confirmId = UploadPostedFileMatch(file, fileName);
                }
                if (confirmId != 0)
                {
                    confirmList = "";
                }
                ////Comma separated values
                returnResult = control.ManualMatchStr(User.Identity.Name, CheckForNull(Request.Form["tradeList"]), confirmList, CheckForNull(Request.Form["manulMatchComment"]), CheckForNullBool(Request.Form["chkdoNotAffirm"]), confirmId);
                }
             
                return Json(new { result = returnResult, tdList = CheckForNull(Request.Form["tradeList"]) });
            }
        private static string CheckForNull(string value)
        {
            return !string.IsNullOrWhiteSpace(value) ? value : "";
        }
        private static bool CheckForNullBool(string value)
        {
            return value != null && Convert.ToBoolean(value[0]);
        }
    }
}

