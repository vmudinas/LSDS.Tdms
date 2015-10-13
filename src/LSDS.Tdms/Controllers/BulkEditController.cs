using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using LSDS.Tdms.Models.TdmsDataModel;
using LSDS.Tdms.Repository;
using System.Data.SqlClient;

namespace Tdms.Controllers
{
    public class BulkEditController : Controller
    {
       
        // GET: BulkEdit
        public IActionResult BulkEdit()
        {
            return PartialView();        }
       
        public IActionResult BulkEditType()
        {
            var rep = new GenericRepository<usp_returnBulkCopyOptions_Result>();
            var parameters = new SqlParameter[1];
            parameters[0].ParameterName = "@user_name";
            parameters[0].Value = "TradeBrowser";

            return Json(rep.ExecuteStoredProcedure("usp_returnBulkCopyOptions @SourceName", parameters));
        }
        public async Task<IActionResult> BulkEditCommentExecute(string selectedTrades, string bulkComment, string bulkCommentType)
        {
            var rep = new Repository();
            return Json(await rep.BulkEditCommentExecute(selectedTrades,bulkComment,bulkCommentType,User.Identity.Name));
        }
        

    }
}