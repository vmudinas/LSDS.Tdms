using LSDS.Tdms.Models.TdmsDataModel;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace LSDS.Tdms.Repository
{
    public class QuickFindSortRepository : Repository
    {
      

        public IEnumerable<QuickfindMC> ReturnQuickFind(string source, bool system, string userName)
        {
            IEnumerable<QuickfindMC> linqQuery = null;

            var parameters = new object[]
            {
                new SqlParameter("@user_name", userName),
                new SqlParameter("@SourceName",source),
                new SqlParameter("@System",system)
            };
            var repo = new GenericRepository<QuickfindMC>();
            linqQuery = repo.ExecuteStoredProcedure("usp_returnquickfind",parameters);
         

            return linqQuery;
        }


        public IEnumerable<QuickfindMC> SaveQuickFind(string userName, string source, string description, bool lastUsed, bool lastUsedToday)
        {
            IEnumerable<QuickfindMC>  linqQuery = null;

            var parameters = new object[]
            {
                new SqlParameter("@user_name", userName),
                new SqlParameter("@SourceName",
                            source),
                new SqlParameter("@Description",
                            description),
                new SqlParameter("@LastUsed",
                            lastUsed),
                new SqlParameter("@LastUsedToday",
                            lastUsedToday)
            };
            var repo = new GenericRepository<QuickfindMC>();
            linqQuery = repo.ExecuteStoredProcedure("usp_SaveQuickFind", parameters);


            return linqQuery;
        }

       

    }
}