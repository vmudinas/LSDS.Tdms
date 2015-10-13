//using System.Collections;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Linq.Dynamic;
//using System.Threading.Tasks;
//using Microsoft.Data.Entity;

//namespace LSDS.Tdms.Repository
//{
//    public partial class Repository 
//    {
//        public int ExecuteNonQuery(string storeProcedureName, SqlParameter[] procedureParametersList = null)
//        {
//            var d = new DbContext();
            
//            var result = 0;

//            using (var dbContext = new DbContext())
//            {
//                result = procedureParametersList == null
//                    ? dbContext(storeProcedureName,
//                        CommandType.StoredProcedure)
//                    : dbContext.Database.ExecuteSqlCommand(storeProcedureName,
//                        CommandType.StoredProcedure, procedureParametersList);

//                dbContext.SaveChanges();
//            }
//            return result;
//        }
//        public int ExecuteNonQuery(string storeProcedureName, SqlParameter procedureParameter = null)
//        {
//            var result = 0;

//            using (var dbContext = new EntitiesModel())
//            {
//                result = procedureParameter == null
//                    ? dbContext.Database.ExecuteSqlCommand(storeProcedureName,
//                        CommandType.StoredProcedure)
//                    : dbContext.Database.ExecuteSqlCommand(storeProcedureName,
//                        CommandType.StoredProcedure, procedureParameter);

//                dbContext.SaveChanges();
//            }
//            return result;
//        }
        

//        public Task<int> ExecuteNonQueryAsync(string storeProcedureName, SqlParameter[] procedureParametersList = null)
//        {

//            return Ext.ToTaskAsync(() => ExecuteNonQuery(storeProcedureName, procedureParametersList));
//        }


//        public IEnumerable<T> ExecuteStoredProcedure<T>(string storeProcedureName, SqlParameter[] procedureParametersList = null, string columnList = "")
//        {
//            //IEnumerable<T> query;
//            //var repo = new GenericRepository<T>();
            
                
//            //         query = procedureParametersList == null
//            //                ? ExecuteStoredProcedure(storeProcedureName,
//            //                    CommandType.StoredProcedure)
//            //                : dbContext.Database.SqlQuery<T>(storeProcedureName,
//            //                    CommandType.StoredProcedure, procedureParametersList);

                   

//            return query;
//        }

      
//        public List<T> ExecuteStoredProcedureIList<T>(string storeProcedureName, SqlParameter[] procedureParametersList = null, string columnList = "")
//        {
//            List<T> query;
//            using (var dbContext = new EntitiesModel())
//            {

//                query = procedureParametersList == null
//                    ? dbContext.Database.SqlQuery<T>(storeProcedureName,
//                        CommandType.StoredProcedure).ToList()
//                    : dbContext.Database.SqlQuery<T>(storeProcedureName,
//                        CommandType.StoredProcedure, procedureParametersList).ToList();


//                dbContext.SaveChanges();
//            }
//            return query;
//        }

//        public IEnumerable ExecuteStoredProcedureWithColumnList<T>(string storeProcedureName, SqlParameter[] procedureParametersList = null, string columnList = "")
//        {
//            IEnumerable query;
//            using (var dbContext = new EntitiesModel())
//            {
//                query = procedureParametersList == null
//                        ? dbContext.Database.SqlQuery<T>(storeProcedureName,
//                            CommandType.StoredProcedure).Select(columnList)
//                        : dbContext.Database.SqlQuery<T>(storeProcedureName,
//                            CommandType.StoredProcedure, procedureParametersList).Select(columnList);


//                dbContext.SaveChanges();
//            }
//            return query;
//        }

        

//        public Task<IEnumerable<T>> ExecuteStoredProcedureAsync<T>(string storeProcedureName, SqlParameter[] procedureParametersList = null, string columnList = "")
//        {

//            return Ext.ToTaskAsync(() => ExecuteStoredProcedure<T>(storeProcedureName, procedureParametersList, columnList));
//        }
//        public Task<List<T>> ExecuteStoredProcedureIListAsync<T>(string storeProcedureName, SqlParameter[] procedureParametersList = null, string columnList = "")
//        {

//            return Ext.ToTaskAsync(() => ExecuteStoredProcedureIList<T>(storeProcedureName, procedureParametersList, columnList));
//        }
//        public   Task<IEnumerable<T>> ExecuteStoredProcedureAsync<T>(string storeProcedureName, string userName, string source, int system)
//        {
//            var tradeRepairParam = new[] {
//            new SqlParameter("@user_name", userName),
//            new SqlParameter("@QuickfindIds", GetQuickFindIdList(userName, source, 1))
//            };
          

//            return Ext.ToTaskAsync(() => ExecuteStoredProcedure<T>(storeProcedureName, tradeRepairParam, ""));
//        }
        
//        public async Task<IEnumerable<T>> ExecuteStoredProcedureAsync<T>(string storeProcedureName,string userName, string source, int system, bool totals, bool txnSide, bool notifyType)
//         {
//            var parameters = new[] 
//            {

//                new SqlParameter("@user_name", userName) ,
//                new SqlParameter("@QuickfindIds", await GetQuickFindIdList(userName, source, 1)),
//                new SqlParameter("@Totals", totals) ,
//                new SqlParameter("@TxnSide", txnSide) ,
//                new SqlParameter("@NotifyType",notifyType)

//            };

//            return  ExecuteStoredProcedure<T>(storeProcedureName, parameters, "");
//         }
//        private static async Task<string> GetQuickFindIdList(string userId, string sourceName, int system)
//        {

//            var list = new List<string>();
//            var parameters = new[]
//           {
//                new SqlParameter("@user_name", userId) ,
//                new SqlParameter("@SourceName", sourceName),
//                new SqlParameter("@system", system)

//            };
       

//            var tdmsDataAccess = new Repository();
//            var quickFindIds = await tdmsDataAccess.ExecuteStoredProcedureAsync<usp_returnquickfindquery_Result>("usp_returnquickfind", parameters);
//            list.AddRange(quickFindIds.Select(item => item.QuickFindID.ToString()));

//            var quickFindIdsString = "";
//            foreach (var item in list)
//            {
//                if (string.IsNullOrWhiteSpace(quickFindIdsString))
//                {
//                    quickFindIdsString = item;
//                }
//                else
//                {
//                    quickFindIdsString = quickFindIdsString + "$" + item;
//                }
//            }
//            return quickFindIdsString;

//        }

//    }
//}