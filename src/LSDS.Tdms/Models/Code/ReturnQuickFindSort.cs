using LSDS.Tdms.Models.TdmsDataModel;
using LSDS.Tdms.Repository;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace LSDS.Tdms.Models.Code
{
    public class ReturnQuickFindSort
    {
       
        public IEnumerable<QuickfindMC> ReturnQuickFind(string userName, string source, bool system)
        {
          

            object[] parameters = 
            {
                new SqlParameter
                {
                    ParameterName = "@user_name",
                    Value = userName
                },

                new SqlParameter
                {
                    ParameterName = "@SourceName",
                    Value = source
                },
                new SqlParameter
                {
                    ParameterName = "@System",
                    Value = system
                }
            };
            var repo = new  GenericRepository<QuickfindMC>();
            var result = repo.ExecuteStoredProcedure("usp_returnquickfind",
                parameters);

            return result;
        }

        public string ReturnQuickFindQueryString(string userName, string source, bool system, int? quickFindId)
        {
            var result = "";

            object[] parameters =
             {
                    new SqlParameter
                    {
                        ParameterName = "@user_name",
                        Value = userName
                    },
                        new SqlParameter
                    {
                        ParameterName = "@SourceName",
                        Value = source
                    },
                    new SqlParameter
                    {
                        ParameterName = "@System",
                        Value = system
                    },new SqlParameter
                    {
                        ParameterName = "@QuickFindId",
                        Value = quickFindId
                    }
                };
            var repo = new GenericRepository<QuickFind_Query>();
            var resultQuery = repo.ExecuteStoredProcedure("usp_returnquickfindquery",
                parameters);
            result = resultQuery.Aggregate(result,
                (current, item) =>
                    string.Format(string.IsNullOrWhiteSpace(current) ? "{0} {1} " : "{0} AND {1} ", item.QueryString,
                        current));

            return result;
        }

        public IList<QuickSort> ReturnQuickSort(string userName, string source, bool system)
        {
            IList<QuickSort> result = null;

            object[] parameters =
             {
                    new SqlParameter
                    {
                        ParameterName = "@user_name",
                        Value = userName
                    },
                        new SqlParameter
                    {
                        ParameterName = "@SourceName",
                        Value = source
                    },
                    new SqlParameter
                    {
                        ParameterName = "@System",
                        Value = system
                    }
                };

            var repo = new GenericRepository<QuickSort>();
            result = repo.ExecuteStoredProcedure("usp_returnquicksort", parameters).ToList();

            return result;
        }

        public string ReturnQuickSort(string userName, string source)
        {
            var returnQFindSort = new ReturnQuickFindSort();


            var resultLastSort = from sort in returnQFindSort.ReturnQuickSort(userName, source, true)
                                 where sort.LastUsedToday == 1
                                 select sort.QuickSort_Query;

          //  var lastSort = resultLastSort as string[] ?? resultLastSort.ToArray();
            if (resultLastSort.Any())
            {
                var sortReturn = string.Join(" ", resultLastSort);
                return sortReturn;
            }
            else
            {
                var result = from sort in returnQFindSort.ReturnQuickSort(userName, source, true)
                             where sort.LastUsed == true
                             select sort.QuickSort_Query;

                var sortReturn = "";
                if (result.Any())
                {
                    sortReturn =string.Join(" ", result);
                }

                return sortReturn;
            }
        }

        public string ReturnQueryString(string userName, string source)
        {
            var returnQFindSort = new ReturnQuickFindSort();
            var qiuckFind = returnQFindSort.ReturnQuickFind(userName, source, true);
            var quickfindMcs = qiuckFind as QuickfindMC[] ?? qiuckFind.ToArray();
            var query = (from find in quickfindMcs
                         where find.LastUsedToday == 1
                         select find.QuickfindID);
            var quickFindId = -1;
            var enumerable = query as int[] ?? query.ToArray();
            if (enumerable.Any())
            {
                quickFindId = enumerable.FirstOrDefault();
            }
            else
            {
                quickFindId = (from find in quickfindMcs
                               where find.LastUsed == true
                               select find.QuickfindID).FirstOrDefault();
            }

            return returnQFindSort.ReturnQuickFindQueryString(userName, source, true, quickFindId);
        }

        public async void RemoveLastUsedTodayFindUserName(string userName)
        {
            //1. Remove LastUsedToday From the User Sort Table

            var rep = new GenericRepository<QuickfindMC>();
            var query = rep.GetAll().Where(s => s.User_name == userName).ToList();
        
            foreach (var item in query)
            {
                item.LastUsedToday = 0;
                item.LastUsed = false;
                await rep.EditAsync(item);
            }         


        }

        public async void RemoveLastUsedTodayFindAll(string userName, string source)
        {
            //1. Remove LastUsedToday From the User Sort Table
            var rep = new GenericRepository<QuickfindMC>();

            var query = rep.GetAll().Where(s => s.SourceName == source && (s.User_name == userName || s.User_name == null)).ToList();

            foreach (var item in query)
            {
                item.LastUsedToday = 0;
                item.LastUsed = false;
                await rep.EditAsync(item);
            }
            
        }

        public async void RemoveLastSearchFindQuery(string userName, string source)
        {
            //1. Remove LastUsedToday From the User Sort Table

            var rep = new GenericRepository<QuickfindMC>();
            var query = rep.GetAll().Where(s => s.QuickfindID == GetQuickFindId(userName, source, "Last Search")).ToList();

            foreach (var item in query)
            {           
                await rep.DeleteAsync(item);
            }        
          
        }

        public async void RemoveLastUsedTodaySortingAll(string userName, string source)
        {
            //1. Remove LastUsedToday From the User Sort Table

            var rep = new GenericRepository<QuickfindMC>();
            var query = rep.GetAll().Where(s => s.SourceName == source && (s.User_name == userName || s.User_name == null)).ToList();

            foreach (var item in query)
            {
                item.LastUsedToday = 0;            
                await rep.EditAsync(item);
            }
        }

        public async void RemoveLastUsedTodaySortingForUsername(string userName)
        {
            //1. Remove LastUsedToday From the User Sort Table
            var rep = new GenericRepository<QuickSort>();

            var query = rep.GetAll().Where(s => s.User_name == userName);
                foreach (var value in query)
                {
                    value.LastUsedToday = 0;
                    await rep.EditAsync(value);
                }

           
        }
        public async void SetLastUsedTodayFind(string userName, string source, string description)
        {
            //1. Remove LastUsedToday From the User Sort Table
            var rep = new GenericRepository<QuickfindMC>();
            var query = rep.GetAll().Where(s => s.User_name == userName && s.SourceName == source && s.Description == description);
                foreach (var value in query)
                {
                    value.LastUsedToday = 1;
                    await rep.EditAsync(value);
                }
            
        }

        public async void UpdateSorting(string userName, string source, int quickSortId)
        {
            RemoveLastUsedTodaySortingAll(userName, source);
            var quickSortQuery = "";
            //1. Get QuickSort  LastUsedToday
            var rep = new GenericRepository<QuickSort>();
            quickSortQuery =
                    rep.GetAll().Where(s => s.QuickSortID == quickSortId).Select(s => s.QuickSort_Query).First();
         
            //1. Update QuickSort  LastUsedToday for Last Search
           
                var quickSortLastSortV =
                    rep.GetAll().Where(s => s.User_name == userName && s.QuickSortID == quickSortId);
                if (quickSortLastSortV.Any())
                {
                    quickSortLastSortV.First().LastUsedToday = 1;
                }

                var quickSortLastSort =
                    rep.GetAll().Where(s => s.User_name == userName && s.Description == "Last Sort");
                if (quickSortLastSort.Any())
                {
                    quickSortLastSort.First().LastUsedToday = 0;
                    quickSortLastSort.First().QuickSort_Query = quickSortQuery;
                }
                else
                {
                    var newQuickSort = new QuickSort
                    {
                        Description = "Last Sort",
                        QuickSort_Query = quickSortQuery,
                        SourceName = source,
                        LastUsed = false,
                        LastUsedToday = 1,
                        SystemQS = false,
                        User_name = userName
                    };

                    await rep.InsertAsync(newQuickSort);
                }
          
        }

        public async void UpdateFind(string userName, string source, int quickFindId)
        {
            RemoveLastUsedTodayFindAll(userName, source);
            RemoveLastSearchFindQuery(userName, source);
            //1. Update QuickFind  LastUsedToday for Last Search
            var rep = new GenericRepository<QuickfindMC>();

            var parameters = new[]
            {
                    new SqlParameter
                    {
                        ParameterName = "@user_name",
                        Value = userName
                    },
                    new SqlParameter
                    {
                        ParameterName = "@SourceName",
                        Value = source
                    },
                    new SqlParameter
                    {
                        ParameterName = "@System",
                        Value = true
                    }
                };

            var getAllQuickFinds =
                rep.ExecuteStoredProcedure("usp_returnquickfind", parameters).Where(a => a.QuickfindID == quickFindId);

            var allQuickFinds = getAllQuickFinds as IList<QuickfindMC> ?? getAllQuickFinds.ToList();

            var firstOrDefault = allQuickFinds.FirstOrDefault();
            if (firstOrDefault != null)
            {
                var param = new[]
              {
                   new SqlParameter
                    {
                        ParameterName = "@QuickFindID",
                        Value = quickFindId
                    },new SqlParameter
                        {
                            ParameterName = "@user_name",
                            Value = userName
                        }, new SqlParameter
                    {
                        ParameterName = "@SourceName",
                        Value = source
                    }, new SqlParameter
                        {
                            ParameterName = "@Description",
                            Value = allQuickFinds.Any() ? firstOrDefault.Description : "Last Search"
                        }, new SqlParameter
                    {
                        ParameterName = "@LastUsed",
                        Value = 1
                    },new SqlParameter
                        {
                            ParameterName = "@LastUsedToday",
                            Value = 1
                        }
};
                await rep.ExecueUpdateAsync("usp_UpdateQuickFind", param);

            }

        }

        private static void UpdateFindQuery(int quickFindId, int quickFindSeach)
        {
            //  var quickFindList = new IEnumerable<QuickFind_Query>();
            var rep = new GenericRepository<QuickFind_Query>();
            var quickFindQ = rep.GetAll().Where(s => s.QuickFindID == quickFindId);
                if (quickFindQ.Any())
                {
                    // var quickFindQuery = dbConLastUsedToday.QuickFind_Queries.Where(s => s.QuickFindID == quickFindId);
                    foreach (var value in quickFindQ)
                    {
                        var newLastSearchQuery = new QuickFind_Query
                        {
                            QuickFindID = quickFindSeach,
                            QF_ColumnName = value.QF_ColumnName,
                            QueryString = value.QueryString,
                            QF_Operator = value.QF_Operator,
                            QF_Value1 = value.QF_Value1,
                            QF_Value2 = value.QF_Value2
                        };

                        InsertQuickFindQuery(newLastSearchQuery);
                    }
                }

           
        }

        private static int GetQuickFindId(string userName, string source, string descriptionParameter)
        {
            var quickFindId = -1;
            //1. Get QuickSort  LastUsedToday
            var rep = new GenericRepository<QuickfindMC>();
            quickFindId =
                    rep.GetAll().Where(
                        s => s.SourceName == source && s.User_name == userName && s.Description == descriptionParameter)
                        .Select(s => s.QuickfindID)
                        .First();
         
            return quickFindId;
        }

        private async static void InsertQuickFindQuery(QuickFind_Query queryObject)
        {
            var rep = new GenericRepository<QuickFind_Query>();
            await rep.InsertAsync(queryObject);
           
        }

        public async void InsertQuickSort(QuickSort quickSortObject)
        {
            
                var rep = new GenericRepository<QuickSort>();
                if (quickSortObject.LastUsedToday == 1)
                {
                    var some = rep.GetAll().Where(x => x.User_name.Contains(quickSortObject.User_name)).ToList();
                    some.ForEach(a => a.LastUsedToday = 0);
                }

                await rep.InsertAsync(quickSortObject);

        }
    }
}