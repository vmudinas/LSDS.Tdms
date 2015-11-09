using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Dynamic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using LSDS.Tdms.Models.TdmsDataModel;
using LSDS.Tdms.Models.KendoModel;
using LSDS.Tdms.Models;
using LSDS.Tdms.Models.Code;

namespace LSDS.Tdms.Repository
{
    public partial class  Repository
    {
        private TdmsDbContext _context;

        public Repository(TdmsDbContext context)
        {
            _context = context;
        }

        public IQueryable  GetAutoComplete(string columnName, string source, string userName)
        {
            var parameters = new[]
             {
                new SqlParameter("@user_name", userName)
                };
            var columnList = "new (" + columnName + ")";
            var repo = new GenericRepository<TradeListModel>(_context);

            return  repo.ExecuteStoredProcedure("usp_returnTradeList_Query", parameters).Select(columnList).FirstOrDefault();
        }

        public async void DeleteSort(string sortId)
        {
            var parameters = new[]
               {
                new SqlParameter("@QuickSortID", sortId)
                };
            var repo = new GenericRepository<QuickfindMC>(_context);
            await repo.ExecueUpdateAsync("usp_deleteQuickSort", parameters);
           
        }


        public IEnumerable<usp_returnTDMSMenu_Result> GetMenu(string userName)
        {
                var parameters = new[]
                {
                new SqlParameter("@user_name", userName)
                };
            var repo = new GenericRepository<usp_returnTDMSMenu_Result>(_context);
            return  repo.ExecuteStoredProcedure("usp_returnTDMSMenu", parameters);
        }


        public async Task<IEnumerable<usp_returnBulkCopyOptions_Result>> BulkEditType()
        {
            var parameters = new[]
            {
                new SqlParameter("@SourceName", "TradeBrowser")
            };
            var repo = new GenericRepository<usp_returnBulkCopyOptions_Result>(_context);
            return await repo.ExecuteStoredProcedureAsync("usp_returnBulkCopyOptions", parameters);
        }
        public async Task<IEnumerable<usp_returnBulkCopyOptions_Result>> BulkEditCommentExecute(string selectedTrades, string bulkComment, string bulkCommentType, string userName)
        {
            var parameters = new[]
            {
                new SqlParameter("@tdTradeList", selectedTrades),
                new SqlParameter("@user_name", userName),
                   new SqlParameter("@bulkData", bulkComment),
                new SqlParameter("@bulkColumn", bulkCommentType)
            };
            var repo = new GenericRepository<usp_returnBulkCopyOptions_Result>(_context);
            return await repo.ExecuteStoredProcedureAsync("usp_returnBulkCopyOptions", parameters);

        }


        public IEnumerable ReturnComment()
        {
            var repo = new GenericRepository<usp_ReturnFailCodes_Result>(_context);
            return repo.ExecuteStoredProcedure("usp_ReturnProblemCodes");
        }


        public IEnumerable ReturnPortfolioContact()
        {
            var repo = new GenericRepository<usp_ReturnFailCodes_Result>(_context);
            return repo.ExecuteStoredProcedure("usp_ReturnContactTypeList");
        }

        public IList<usp_ReturnFailCodes_Result> ReturnFailCodesList()
        {
                var repo = new GenericRepository<usp_ReturnFailCodes_Result>(_context);
                return repo.ExecuteStoredProcedure("usp_ReturnFailCodesList").ToList();

        }

        public ReturnDataToKendo ReturnFailedTradeGrid(string idList, string userName)
        {
            var parameters = new[]
            {
                new SqlParameter("@tdtradeList", idList),
                new SqlParameter("@user_name", userName)
            };

            var returnData = new ReturnDataToKendo(_context);
            return returnData.ReturnKendoData<usp_ReturnFailedTrade_Result>(userName, "FailEdit", parameters,
                    "usp_ReturnFailedTrades");

        }       
      
        public  int TdmsFailedTradesSave(string idList, int tdxfailurereason, string resolveddate, string comment, string userName)
        {
            
            var count = 0;
            var parameters = new[]
            {
                new SqlParameter("@tdtradeList", idList),
                new SqlParameter("@enteredby", userName),
                new SqlParameter("@tdxfailurereason", tdxfailurereason),
                new SqlParameter("@resolveddate", resolveddate),
                new SqlParameter("@comment", comment)
            };
            var repo = new GenericRepository<EmptyUpdateModel>(_context);
            count =  repo.ExecueUpdate("usp_UpdateFailedTrades", parameters);          

            return count;
        }
        public async Task<IEnumerable<usp_ReturnBrokerPerformance_Result>> BrokerPerformance(string time, string userName)
        {
            var intTimePeriod = 0;
            int.TryParse(time, out intTimePeriod);

            var parameters = new[]
            {
                new SqlParameter("@user_name", userName),
                new SqlParameter("@TimePeriod", intTimePeriod)
            };
            var repo = new GenericRepository<usp_ReturnBrokerPerformance_Result>(_context);
            return  await repo.ExecuteStoredProcedureAsync("usp_ReturnBrokerPerformance", parameters);
        }


        public async Task<IEnumerable<usp_ReturnWidgetLocation_Result>> ReturnWidgetLocation( string userName)
        {
            var parameters = new[]
            {
                new SqlParameter("@user_name", userName)
            };
            var repo = new GenericRepository<usp_ReturnWidgetLocation_Result>(_context);
            return  await repo.ExecuteStoredProcedureAsync("usp_ReturnWidgetLocation", parameters);
        }
        public async Task<IEnumerable<usp_ReturnPackageMaintenanceListHome>> NotificationJobStatus(string userId)
        {
            var parameters = new[]
           {
                new SqlParameter("@userId", userId),
                new SqlParameter("@NotificationOnly", true)
            };
            var repo = new GenericRepository<usp_ReturnPackageMaintenanceListHome>(_context);
            var notificationStatus = await repo.ExecuteStoredProcedureAsync("usp_ReturnPackageMaintenanceListHome", parameters);

            return notificationStatus;
        }
        

        public async Task<IEnumerable<usp_ReturnUserSavedReports_Result>> SavedReports(string userId)
        {
            var parameters = new[]
            {
                new SqlParameter("@user_name", userId)
            };

            var repo = new GenericRepository<usp_ReturnUserSavedReports_Result>(_context);
            return await repo.ExecuteStoredProcedureAsync("usp_ReturnUserSavedReports", parameters);
          
        }

        public async Task<IEnumerable<usp_ReturnImportSummary_Result>> ImportSummary(string userId, string days)
        {
            var parameters = new[]
            {
                new SqlParameter("@user_name", userId),
                new SqlParameter("@days", days)
            };
            var repo = new GenericRepository<usp_ReturnImportSummary_Result>(_context);
            return  await repo.ExecuteStoredProcedureAsync("usp_ReturnImportSummary", parameters);

        }
        public async Task<IEnumerable<UspReturnTradeRepairLog>> GetTradeRepairLog(string userName, int tdTrade)
        {
            var param = new[]
          {
                new SqlParameter("@user_name", userName),
                new SqlParameter("@tdTrade", tdTrade)
            };
            var repo = new GenericRepository<UspReturnTradeRepairLog>(_context);
            return await repo.ExecuteStoredProcedureAsync(
                        "usp_ReturnTradeRepairLog", param);

        }
        public async Task<IEnumerable<UspReturnTradeNotifyList>> GetTradeRepairLogN(string userName, int tdTrade)
        {
            var param = new[]
          {
                new SqlParameter("@user_name", userName),
                new SqlParameter("@tdTrade", tdTrade)
            };
            var repo = new GenericRepository<UspReturnTradeNotifyList>(_context);
            return await repo.ExecuteStoredProcedureAsync(
                        "usp_ReturnTradeRepairLog", param);

        }
        public async Task<IEnumerable<UspReturnTradeNotifyList>> GetNotifyList(string userName, int tdTrade)
        {
         
            var param = new[]
            {
                new SqlParameter("@user_name", userName),
                new SqlParameter("@tdTrade", tdTrade)
            };
            var repo = new GenericRepository<UspReturnTradeNotifyList>(_context);
            return await repo.ExecuteStoredProcedureAsync(
                        "usp_ReturnTradeNotifyList", param);

        }
        
       public async Task<IEnumerable<UspReturnIsitcIssueType>> ReturnSecurityTypeList(int tdTrade)
        {
            var param = new[]
            {
                new SqlParameter("@tdTrade", tdTrade)
            };
            var repo = new GenericRepository<UspReturnIsitcIssueType>(_context);
            return await repo.ExecuteStoredProcedureAsync(
                   "usp_ReturnSecurityTypeList", param);

        }
        public async Task<IEnumerable<UspReturnSecurityTypeList>> ReturnSecurityTypeList(int tdTrade, int isitc = 0)
        {
            var param = new[]
            {
                new SqlParameter("@tdTrade", tdTrade),
                new SqlParameter("@ISITC", isitc)
            };
            var repo = new GenericRepository<UspReturnSecurityTypeList>(_context);
            return await repo.ExecuteStoredProcedureAsync("usp_ReturnSecurityTypeList", param);
            
        }

        public async Task<IEnumerable<UspReturnTradeDetail>> ReturnTradeDetail(string userName, int tdTrade)
        {
         
            var tradeDetailParam = new[]
            {
                new SqlParameter("@user_name", userName) ,
                new SqlParameter("@tdTrade", tdTrade)
            };
            var repo = new GenericRepository<UspReturnTradeDetail>(_context);
            return await repo.ExecuteStoredProcedureAsync(
                        "usp_ReturnTradeDetail", tradeDetailParam);

        }


        public async Task<IEnumerable<UspReturnMatchedTradesConfirms>> ReturnMatchedTradesConfirms(string userName, int tdTrade)
        {
            var tradeDetailParam = new[]
           {
                new SqlParameter("@user_name", userName) ,
                new SqlParameter("@tdTrade", tdTrade)
            };
            var repo = new GenericRepository<UspReturnMatchedTradesConfirms>(_context);

            return await repo.ExecuteStoredProcedureAsync(
                        "usp_ReturnMatchedTradesConfirms", tradeDetailParam);



        }
        public IList<tdGridsterModel> GetGridsterExt(string userName)
        {
            var newGridster = new List<tdGridsterModel>();
            var repo = new GenericRepository<tdGridsterModel>(_context);
            return repo.GetAll().Where(c => c.user_name == userName).ToList();
        }      

        public async Task<IEnumerable<usp_ReturnSystemStatus>> SystemStatus()
        {
            var parameters = new[]
            {
                new SqlParameter("@AllGroups", false)
            };

            var tdmsDataAccess = new GenericRepository<usp_ReturnSystemStatus>(_context);
            return await tdmsDataAccess.ExecuteStoredProcedureAsync("usp_ReturnSystemStatus", parameters);

        }


        public async Task<int> UpdateDetail(UspReturnTradeDetail tradeDetailVModel, string userName)
        {

            var parameters = new[]
           {
                new SqlParameter("@tdTrade", tradeDetailVModel?.tdTrade) ,
                new SqlParameter("@BrokerFINNo", tradeDetailVModel?.BrokerFINNo),
                new SqlParameter("@mOtherFee", tradeDetailVModel?.mOtherFee),
                new SqlParameter("@ShawBrokerCode", tradeDetailVModel?.ShawBrokerCode),
                new SqlParameter("@FlagDeleted", tradeDetailVModel?.FlagDeleted),
                new SqlParameter("@UserCode", tradeDetailVModel?.UserCode),
                new SqlParameter("@TradeComments", tradeDetailVModel?.TradeComments),
                new SqlParameter("@DoNotAffirm", tradeDetailVModel?.DoNotAffirm),
                new SqlParameter("@lastchangedby", userName),
                new SqlParameter("@lastchangeddate", DateTime.Now),
                new SqlParameter("@ClearingBrokerFINNo", tradeDetailVModel?.ClearingBrokerFINNo),
                new SqlParameter("@tdxSecurityType", tradeDetailVModel?.tdxSecurityType),
                new SqlParameter("@SettlementLoc", tradeDetailVModel?.SettlementLoc),
                new SqlParameter("@StampDuty", tradeDetailVModel?.StampDuty),
                new SqlParameter("@ValueAddedTax", tradeDetailVModel?.ValueAddedTax),
                new SqlParameter("@ISITCIssueType", tradeDetailVModel?.ISITCIssueType),
                new SqlParameter("@timestamp", tradeDetailVModel?.timestamp),
                new SqlParameter("@user_name", userName)
            };
            var repo = new GenericRepository<UspReturnTradeDetail>(_context);
            return  await repo.ExecueUpdateAsync("usp_updateTradeDetail", parameters);
        }


        public async Task<IEnumerable<string>> GetQuickFindColumnList(string userId, string sourceName, int system)
        {
            var parameters = new[]
            {
                new SqlParameter("@user_name", userId) ,
                new SqlParameter("@SourceName", sourceName),
                new SqlParameter("@system", system)

            };

            var tdmsDataAccess = new GenericRepository<usp_returnquickfindquery_Result>(_context);
            var quickFindColumnName = await tdmsDataAccess.ExecuteStoredProcedureAsync("usp_returnquickfind", parameters);

            var list = new List<string>();

            list.AddRange(quickFindColumnName.Select(item => item.Description.ToString()));


              return list;

        }     
       
    }
    
}
