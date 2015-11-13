using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

using LSDS.Tdms.Models.TdmsDataModel;
using System.Threading.Tasks;
using LSDS.Tdms.Models;
using Microsoft.Data.Entity;

namespace LSDS.Tdms.Repository
{
    public class LocationRepository 
    {
        private readonly Gridster _gridster = new Gridster();
        private TdmsDbContext _context;
        public LocationRepository(TdmsDbContext context)
        {
            _context = context;
        }
        public Gridster Gridster
        {
            get { return _gridster; }
        }

        public IEnumerable<LocationUserData>  GetLocationList(string userName)
        {
            IEnumerable<LocationUserData> locationList = null;
           

                object[] usrName = {
                    new SqlParameter("@user_name", userName)
                };
            object[] appUsrId = {
                    new SqlParameter("@app_usr_id", userName)
                };
         
            var groupId = _context.UserData.FromSql("EXEC usp_returnUserData @p0", userName).Select(a => a.tdUserGroupId).FirstOrDefault();
           
            _context.LocationUserData.FromSql("EXEC sp_SetAppUser @p0", appUsrId);
            locationList = _context.LocationUserData.FromSql("EXEC usp_ReturnUserGroups");
           
                var locationUserDatas = locationList.ToArray();
                foreach (var item in locationUserDatas)
                {
                    item.Selected = false || item.tdUserGroupID == groupId;
                }
           
            return locationUserDatas;
        }

        public string UpdageLocation(string userName, string tdUserGroupId)
        {

            object[] appUsrId = {
                    new SqlParameter("@app_usr_id", userName)
                };
            object[] tdUserGroupIdParam = {
                    new SqlParameter("@tdUserGroupId", tdUserGroupId)
                };
                var rep = new GenericRepository<usp_returnUserData>(_context);
                rep.ExecueUpdate("sp_SetAppUser", appUsrId);
                rep.ExecueUpdate("usp_ChangeUserLocation", tdUserGroupIdParam);
               
            return "success";
        }
    }
}