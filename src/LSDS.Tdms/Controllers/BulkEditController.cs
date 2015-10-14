using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using LSDS.Tdms.Models.TdmsDataModel;
using LSDS.Tdms.Repository;
using System.Data.SqlClient;
using LSDS.Tdms.Models;

namespace LSDS.Tdms.Controllers
{
    public class BulkEditController : Controller
    {
        private TdmsDbContext _context;
        public BulkEditController(TdmsDbContext context)
        {
            _context = context;
        }
        // GET: BulkEdit
        public IActionResult BulkEdit()
        {
            return PartialView();        }
       
        public IActionResult BulkEditType()
        {
            var rep = new GenericRepository<usp_returnBulkCopyOptions_Result>(_context);
            var parameters = new SqlParameter[1];
            parameters[0].ParameterName = "@user_name";
            parameters[0].Value = "TradeBrowser";

            return Json(rep.ExecuteStoredProcedure("usp_returnBulkCopyOptions @SourceName", parameters));
        }
        public async Task<IActionResult> BulkEditCommentExecute(string selectedTrades, string bulkComment, string bulkCommentType)
        {
            var rep = new Repository.Repository(_context);
            return Json(await rep.BulkEditCommentExecute(selectedTrades,bulkComment,bulkCommentType,User.Identity.Name));
        }
        

    }
}