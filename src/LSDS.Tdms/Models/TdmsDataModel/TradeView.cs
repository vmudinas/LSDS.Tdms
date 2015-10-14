using LSDS.Tdms.Models.Code;
using LSDS.Tdms.Models.KendoModel;
using System.Data.Common;
using System.Data.SqlClient;
using System.Threading.Tasks;


namespace LSDS.Tdms.Models.TdmsDataModel
{
    public class TradeView
    {
        public ReturnDataToKendo ReturnTradeViewDataAsync(KendoGridItems item, string userName,TdmsDbContext context)
        {
            const string source = "TradeBrowser";
            const string storedProcedureName = "usp_returnTradeList_Query";
            var returnQuickFind = new ReturnQuickFindSort(context);
            // Create required Parameter for a query
            var parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("user_name", userName);
            var tempSortQ = returnQuickFind.ReturnQuickSort(userName, source);
            if (!string.IsNullOrWhiteSpace(tempSortQ.Trim()))
            {
                tempSortQ = string.Format(" Order By {0}", tempSortQ.Trim());
            }
           
            var queryStringParameter = string.Format(" {0} {1}", returnQuickFind.ReturnQueryString(userName, source),
                tempSortQ);

            parameters[1] = new SqlParameter("QueryString", SetFillter(item, queryStringParameter));


            var returnData = new ReturnDataToKendo(context);
            // Return query parameter together with Kendo Grid default parameters
            // Sorting and Filtering to be added
            return  returnData.ReturnKendoDataAsync<TradeListModel>(item, userName, source, parameters, storedProcedureName);
        }
        public  ReturnDataToKendo ReturnTradeViewData(KendoGridItems item, string userName, TdmsDbContext context)
        {
            const string source = "TradeBrowser";
            const string storedProcedureName = "usp_returnTradeList_Query";
            var returnQuickFind = new ReturnQuickFindSort(context);
            // Create required Parameter for a query
            var parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("user_name", userName);
            var tempSortQ = returnQuickFind.ReturnQuickSort(userName, source);
            if (!string.IsNullOrWhiteSpace(tempSortQ.Trim()))
            {
                tempSortQ = string.Format(" Order By {0}", tempSortQ.Trim());
            }

            var queryStringParameter = string.Format(" {0} {1}", returnQuickFind.ReturnQueryString(userName, source),
                tempSortQ);

           
            parameters[1] = new SqlParameter("QueryString", SetFillter(item, queryStringParameter));


            var returnData = new ReturnDataToKendo(context);
            // Return query parameter together with Kendo Grid default parameters
            // Sorting and Filtering to be added
            return  returnData.ReturnKendoData<TradeListModel>(item, userName, source, parameters, storedProcedureName);
        }

        public ReturnDataToKendo ReturnTradeViewDataAll(string userName, TdmsDbContext context)
        {
            const string source = "TradeBrowser";
            const string storedProcedureName = "usp_returnTradeList_Query";
            var returnQuickFind = new ReturnQuickFindSort(context);
            // Create required Parameter for a query
            var parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("user_name", userName);
            var tempSortQ = returnQuickFind.ReturnQuickSort(userName, source);
            if (!string.IsNullOrWhiteSpace(tempSortQ.Trim()))
            {
                tempSortQ = string.Format(" Order By {0}", tempSortQ.Trim());
            }

            var queryStringParameter = string.Format(" {0} {1}", returnQuickFind.ReturnQueryString(userName, source),
                tempSortQ);
            parameters[1] = new SqlParameter("QueryString", queryStringParameter);


            var returnData = new ReturnDataToKendo(context);
            // Return query parameter together with Kendo Grid default parameters
            // Sorting and Filtering to be added
            return returnData.ReturnKendoDataAll<TradeListModel>(userName, source, parameters, storedProcedureName);
        }

        private static string SetFillter(KendoGridItems item, string queryStringParameter)
        {
            var filter = "";
             if (item.filter != null)
            {
                if (item.filter.Filters.Length > 0)
                {
                    if (item.filter.Filters[0].Field != null && item.filter.Filters[0].Value != null &&
                        item.filter.Filters[0].Operator != null)
                    {
                        switch (item.filter.Filters[0].Operator)
                        {
                            case "startswith":
                                filter = string.Format(" {0} LIKE '{1}%' ",
                                    item.filter.Filters[0].Field,
                                    item.filter.Filters[0].Value);
                                break;
                            case "endswith":
                                filter = string.Format(" {0} LIKE '%{1}' ",
                                    item.filter.Filters[0].Field,
                                    item.filter.Filters[0].Value);
                                break;
                            case "contains":
                                filter = string.Format(" {0} LIKE '%{1}%' ",
                                    item.filter.Filters[0].Field,
                                    item.filter.Filters[0].Value);
                                break;
                            case "doesnotcontain":
                                filter = string.Format(" NOT ({0} LIKE '%{1}%')",
                                    item.filter.Filters[0].Field,
                                    item.filter.Filters[0].Value);
                                break;
                            default:
                                filter = string.Format("{0} {1} '{2}'",
                                    item.filter.Filters[0].Field,
                                    item.filter.Filters[0].Operator.Replace("neq", "!=").Replace("eq", "="),
                                    item.filter.Filters[0].Value);
                                break;
                        }

                    }
                }
                if (item.filter.Filters.Length > 1)
                {
                    if (item.filter.Filters[1].Field != null && item.filter.Filters[1].Value != null &&
                        item.filter.Filters[1].Operator != null && item.filter.Logic != null)
                    {

                        switch (item.filter.Filters[1].Operator)
                        {
                            case "startswith":
                                filter = string.Format(" {3} {2} {0} LIKE '{1}%' ",
                                    item.filter.Filters[1].Field,
                                    item.filter.Filters[1].Value, item.filter.Logic, filter);
                                break;
                            case "endswith":
                                filter = string.Format(" {3} {2}  {0} LIKE '%{1}' ",
                                    item.filter.Filters[1].Field,
                                    item.filter.Filters[1].Value, item.filter.Logic, filter);
                                break;
                            case "contains":
                                filter = string.Format(" {3} {2}  {0} LIKE '%{1}%' ",
                                    item.filter.Filters[1].Field,
                                    item.filter.Filters[1].Value, item.filter.Logic, filter);
                                break;
                            case "doesnotcontain":
                                filter = string.Format(" {3} {2}  NOT ({0} LIKE '%{1}%')",
                                    item.filter.Filters[1].Field,
                                    item.filter.Filters[1].Value, item.filter.Logic, filter);
                                break;
                            default:
                                filter = string.Format(" {4} {3} {0} {1} '{2}'",
                                    item.filter.Filters[1].Field,
                                    item.filter.Filters[1].Operator.Replace("neq", "!=").Replace("eq", "="),
                                    item.filter.Filters[1].Value, item.filter.Logic, filter);
                                break;
                        }

                    }
                }
                var tempFilter = "";
                foreach (var filterItem in item.filter.Filters)
                {
                    if (item.filter.Filters.Length > 0 && filterItem.Filters != null)
                    {
                        if (filterItem.Filters[0].Field != null && filterItem.Filters[0].Value != null &&
                            filterItem.Filters[0].Operator != null)
                        {
                            switch (filterItem.Filters[0].Operator)
                            {
                                case "startswith":
                                    tempFilter = string.Format(" {0} LIKE '{1}%' ",
                                        filterItem.Filters[0].Field,
                                        filterItem.Filters[0].Value);
                                    break;
                                case "endswith":
                                    tempFilter = string.Format(" {0} LIKE '%{1}' ",
                                        filterItem.Filters[0].Field,
                                        filterItem.Filters[0].Value);
                                    break;
                                case "contains":
                                    tempFilter = string.Format(" {0} LIKE '%{1}%' ",
                                        filterItem.Filters[0].Field,
                                        filterItem.Filters[0].Value);
                                    break;
                                case "doesnotcontain":
                                    tempFilter = string.Format(" NOT ({0} LIKE '%{1}%')",
                                        filterItem.Filters[0].Field,
                                        filterItem.Filters[0].Value);
                                    break;
                                default:
                                    tempFilter = string.Format("{0} {1} '{2}'",
                                        filterItem.Filters[0].Field,
                                        filterItem.Filters[0].Operator.Replace("neq", "!=").Replace("eq", "="),
                                        filterItem.Filters[0].Value);
                                    break;
                            }
                        }


                        if (filterItem.Filters.Length > 1 && filterItem.Filters != null)
                        {
                            if (filterItem.Filters[1].Field != null && filterItem.Filters[1].Value != null &&
                                filterItem.Filters[1].Operator != null && filterItem.Logic != null)
                            {

                                switch (filterItem.Filters[1].Operator)
                                {
                                    case "startswith":
                                        tempFilter = string.Format(" {3} {2}  {0} LIKE '{1}%' ",
                                            filterItem.Filters[1].Field,
                                            filterItem.Filters[1].Value, filterItem.Logic, tempFilter);
                                        break;
                                    case "endswith":
                                        tempFilter = string.Format(" {3} {2}  {0} LIKE '%{1}' ",
                                            filterItem.Filters[1].Field,
                                            filterItem.Filters[1].Value, filterItem.Logic, tempFilter);
                                        break;
                                    case "contains":
                                        tempFilter = string.Format(" {3} {2}  {0} LIKE '%{1}%' ",
                                            filterItem.Filters[1].Field,
                                            filterItem.Filters[1].Value, filterItem.Logic, tempFilter);
                                        break;
                                    case "doesnotcontain":
                                        tempFilter = string.Format(" {3} {2}  NOT ({0} LIKE '%{1}%')",
                                            filterItem.Filters[1].Field,
                                            filterItem.Filters[1].Value, filterItem.Logic, tempFilter);
                                        break;
                                    default:
                                        tempFilter = string.Format(" {4} {3} {0} {1} '{2}'",
                                            filterItem.Filters[1].Field,
                                            filterItem.Filters[1].Operator.Replace("neq", "!=").Replace("eq", "="),
                                            filterItem.Filters[1].Value, filterItem.Logic, tempFilter);
                                        break;
                                }
                            }
                        }
                    }
                    if (!string.IsNullOrWhiteSpace(tempFilter))
                    {
                        filter = string.Format(" {0} AND {1} ", filter, tempFilter);
                    }
                }

            }
             if (string.IsNullOrWhiteSpace(queryStringParameter) && !string.IsNullOrWhiteSpace(filter))
             {
                 queryStringParameter = filter;
             }
             else if (!string.IsNullOrWhiteSpace(queryStringParameter) && !string.IsNullOrWhiteSpace(filter))
             {
                 queryStringParameter = string.Format("({0}) AND ({1})", queryStringParameter, filter);
             }

             return queryStringParameter;
        }
    }
}