

using LSDS.Tdms.Models;

namespace LSDS.Tdms.Repository
{
    public class SecurityRepository 
    {
        private TdmsDbContext _context;
        public SecurityRepository(TdmsDbContext context)
        {
            _context = context;
        }
        //public async Task<IEnumerable<T>> CheckSecurity<T>(string userName)
        //{
        //    var sqlParams = new[] {
        //    new SqlParameter("@user_name", userName) 
        //    };
        //    IEnumerable<T> result; 

        //        var tdmsDataAccess = new global::LSDS.Tdms.Repository.GenericRepository<T>();
        //        result = await tdmsDataAccess.ExecuteStoredProcedureAsync<T>(
        //            "usp_ReturnSecurityAccess", sqlParams);

        //    return result;
        //}
    }
}