using System;
using System.Collections;
using System.Data.SqlClient;
using System.Linq;
using LSDS.Tdms.Models.TdmsDataModel;


namespace LSDS.Tdms.Repository
{
    public class FileRepository: Repository
    {

        public async void SaveToFileStore(string fileName, IEnumerable fileImage, string userId, string fileType,
            string tdTradeList)
        {
            var parameters = new[] {

            new SqlParameter("@user_name", userId) ,
            new SqlParameter("@FileName", fileName),
             new SqlParameter("@FileDate", DateTime.Now) ,
            new SqlParameter("@FileContent", fileImage),
             new SqlParameter("@FileType", fileType.Split('/').Last()) ,
            new SqlParameter("@tdTradeList", tdTradeList)

            };

            var tdmsDataAccess = new GenericRepository<usp_InsertTradesAttachment_Result>();
           await  tdmsDataAccess.ExecuteStoredProcedureAsync("usp_InsertTradesAttachment", parameters);
        }
    }
}