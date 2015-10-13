using System.Data.Common;
using System.Data.SqlClient;
using LSDS.Tdms.Models.TdmsDataModel;
using LSDS.Tdms.Models.Code;

namespace LSDS.Tdms.Repository
{
    public class ManualMatchRepository : Repository
    {
        public ReturnDataToKendo TdmsManualMatchData<T>(string tdTrade, bool chkPortNo, bool chkTraded, bool chkSecId, bool chkBs, bool chkBrokerFin, string confirmRefNo, string userName, string source, string storeProcedure)
        {
            var paramSourceName = new[]
            {
                new SqlParameter("tdTrade", tdTrade),
                new SqlParameter("PortNo", ReturnInt(chkPortNo)),
                new SqlParameter("Traded", ReturnInt(chkTraded)),
                new SqlParameter("CUSIP", ReturnInt(chkSecId)),
                new SqlParameter("BS", ReturnInt(chkBs)),
                new SqlParameter("BrokerFIN", ReturnInt(chkBrokerFin)),
                new SqlParameter("ConfirmRefNo", confirmRefNo)
            };
            var returnData = new ReturnDataToKendo();
            return returnData.ReturnKendoDataAll<ManualMatchTrade>(userName, source, paramSourceName,
                storeProcedure);
         
        }

        public ReturnDataToKendo TdmsManualMatchData<T>(string userName, string idList, string source, string storeProcedureName)
        {
            var parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("user_name", userName);
            if (!string.IsNullOrWhiteSpace(idList))
            {
                parameters[1] = new SqlParameter("Querystring", "tdTrade IN (" + idList + ")");
            }
            else
            {
                return null;
            }
            var returnData = new ReturnDataToKendo();

            return returnData.ReturnKendoDataAll<ManualMatchTrade>(userName, source, parameters,
                storeProcedureName);
         
        }

        private int ReturnInt(bool value)
        {
            return value ? 1 : 0;
        }
    }
}