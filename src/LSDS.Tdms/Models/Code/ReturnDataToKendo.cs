using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Dynamic;
using System.Xml.Serialization;
using LSDS.Tdms.Models.KendoModel;

namespace LSDS.Tdms.Models.Code
{
    public class ReturnDataToKendo
    {
        [XmlIgnore]
        public int Total { get; set; }

        public IEnumerable TradeList { get; set; }

        public ReturnDataToKendo ReturnKendoDataAsync<TradeListModel>(KendoGridItems item, string userName, string source,
            SqlParameter[] procedureParametersList, string storeProcedureName)
        {
            var newTradeView = new ReturnDataToKendo();
            var getTableDetail = new GetTableDetail();
            var tableDetail = getTableDetail.ReturnTableDetailData(source, userName);
            var columnList = "new (" + getTableDetail.ReturnColumnListCommaSeparated(tableDetail.ToList()) + ")";

            var rep = new Repository.GenericRepository<ReturnDataToKendo>();

            var linqQuery =  rep.ExecuteStoredProcedure(storeProcedureName, procedureParametersList).Select(columnList);
            
                newTradeView.Total = linqQuery.Count();
                newTradeView.TradeList = item.Sort != null
                    ? linqQuery.Skip(item.Skip).Take(item.Take).OrderBy(ReturnOrderByString(item.Sort))
                    : linqQuery.Skip(item.Skip).Take(item.Take);
          

            return newTradeView;
        }
        public  ReturnDataToKendo ReturnKendoData<T>(KendoGridItems item, string userName, string source,
           SqlParameter[] procedureParametersList, string storeProcedureName)
        {
            var newTradeView = new ReturnDataToKendo();
            var getTableDetail = new GetTableDetail();
            var tableDetail = getTableDetail.ReturnTableDetailData(source, userName);
            var columnList = "new (" + getTableDetail.ReturnColumnListCommaSeparated(tableDetail.ToList()) + ")";

            var rep = new Repository.GenericRepository<ReturnDataToKendo>();

            var linqQuery = rep.ExecuteStoredProcedure(storeProcedureName, procedureParametersList).Select(columnList);
                      
            newTradeView.Total = linqQuery.Count();
            newTradeView.TradeList = item.Sort != null
                ? linqQuery.Skip(item.Skip).Take(item.Take).OrderBy(ReturnOrderByString(item.Sort))
                : linqQuery.Skip(item.Skip).Take(item.Take);

            return newTradeView;
        }

        public ReturnDataToKendo ReturnKendoData<T>(string userName, string source,
            SqlParameter[] procedureParametersList, string storeProcedureName)
        {
            var newTradeView = new ReturnDataToKendo();
            var getTableDetail = new GetTableDetail();
            var tableDetail = getTableDetail.ReturnTableDetailData(source, userName);

          
                var columnList = "new (" + getTableDetail.ReturnColumnListCommaSeparated(tableDetail.ToList()) + ")";
                if (columnList.Equals("new ()")) return newTradeView;
                var rep = new Repository.GenericRepository<ReturnDataToKendo>();
           
                var linqQuery =
                    rep.ExecuteStoredProcedure(storeProcedureName, procedureParametersList).Select(columnList);

                newTradeView.Total = linqQuery.Count();
                newTradeView.TradeList = linqQuery;
         

            return newTradeView;
        }

        public ReturnDataToKendo ReturnKendoDataAll<T>(string userName, string source,
            SqlParameter[] procedureParametersList, string storeProcedureName)
        {
            if (string.IsNullOrWhiteSpace(storeProcedureName))
            {
                return null;
            }
            var newTradeView = new ReturnDataToKendo();
            var getTableDetail = new GetTableDetail();
            //var tableDetail = getTableDetail.ReturnTableDetailData(source, userName);

                var rep = new Repository.GenericRepository<ReturnDataToKendo>();
                var linqQuery = rep.ExecuteStoredProcedure(storeProcedureName,
                    procedureParametersList);
                newTradeView.Total = linqQuery.Count();
                newTradeView.TradeList = linqQuery;
          
            return newTradeView;
        }

        private static string ReturnOrderByString(IEnumerable<KendoGridSort> item)
        {
            var result = item.Aggregate("",
                (current, value) => string.Format("{0} {1} {2} ,", current, value.Field, value.Dir));
            return !string.IsNullOrWhiteSpace(result) ? result.Remove(result.Length - 1) : "";
        }
    }
}