using LSDS.Tdms.Models.TdmsDataModel;
using LSDS.Tdms.Repository;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace LSDS.Tdms.Models.Code
{
    public class GetTableDetail
    {
        public IEnumerable<usp_returnTableDetail_Result> ReturnTableDetailData(string sourceName, string userName,
            bool search = false)
        {
            IEnumerable<usp_returnTableDetail_Result> result = null;

            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(sourceName))
            {
                return result;
            }
            var paramSourceName = new[] {

            new SqlParameter("@SourceName", sourceName) ,

            new SqlParameter("@user_name", userName)

            };
            var rep = new GenericRepository<usp_returnTableDetail_Result>();

            return  search
                    ? rep.ExecuteStoredProcedure("usp_returnTableDetail @SourceName @user_name",
                         paramSourceName).Where(a => a.QuickFind == true)
                    : rep.ExecuteStoredProcedure("usp_returnTableDetail  @SourceName @user_name",
                        paramSourceName);
                      
        }

        public string ReturnColumnListCommaSeparated(List<usp_returnTableDetail_Result> dataList)
        {
            if (dataList == null)
            {
                return "";
            }
            var count = 0;
            var tempstring = "";
            foreach (var item in dataList)
            {
                var columnName = "";
                if (item.Column_Name != null && item.Column_Name != "null")
                {
                    columnName = item.Column_Name;
                }
                if (count == 0)
                {
                    tempstring = columnName + " ";
                }
                else
                {
                    tempstring = tempstring + " , " + columnName + " ";
                }

                count++;
            }
            return tempstring;
        }
    }
}