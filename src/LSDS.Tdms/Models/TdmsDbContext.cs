using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LSDS.Tdms.Models;
using LSDS.Tdms.Models.TdmsDataModel;
using LSDS.CTM.CtmMessages;


namespace LSDS.Tdms.Models
{
    public class TdmsDbContext:DbContext
    {
        public DbSet<UspReturnVersion> Version { get; set; }
        public DbSet<usp_returnUserbyUserName_Result> UserByUserName { get; set; }
        public DbSet<usp_LoginReport_Result> LoginReport { get; set; }
      //  public DbSet<object> LoginAttemt { get; set; }
        public DbSet<QuickfindMC> QuickfindMC { get; set; }
        public DbSet<Quickfind_Default> Quickfind_Default { get; set; }
        public DbSet<QuickFind_Query> QuickFind_Query { get; set; }
        public DbSet<usp_returnquickfindquery_Result> QuickfindqueryResult { get; set; }
        public DbSet<usp_returnquickfind> Returnquickfind { get; set; }
        
        public DbSet<QuickSort> QuickSort { get; set; }
        public DbSet<QuickSortItem> QuickSortItem { get; set; }

        public DbSet<usp_returnTDMSMenu_Result> GetMenu { get; set; }
        public DbSet<usp_returnUserData> UserData { get; set; }
        public DbSet<LocationUserData> LocationUserData { get; set; }
        public DbSet<tdGridsterModel> Gridster { get; set; }
        public DbSet<usp_ReturnBrokerPerformance_Result> BrokerPreformance  { get; set; }
        public DbSet<usp_ReturnImportSummary_Result> ImportSummary { get; set; }
        public DbSet<usp_ReturnWidgetLocation_Result> WidgetLocation { get; set; }
        public DbSet<usp_ReturnPackageMaintenanceListHome> PackageMaintenanceListHome { get; set; }
        public DbSet<usp_ReturnUserSavedReports_Result> UserSavedReports { get; set; }
        public DbSet<usp_ReturnRepairStatusData_Result> RepairStatusData { get; set; }
        public DbSet<usp_ReturnSystemStatus> SystemStatus { get; set; }
     // public DbSet<LSDS.Tdms.> CtmMessage { get; set;  }
       
        


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
       
    }
    public class CTMDbContext : DbContext
    {
        public virtual  DbSet<CTM_Message> CTMMessage { get; set; }
        public virtual  DbSet<CTM_Invalid> Invalid { get; set; }
        public virtual  DbSet<CTM_Valid> Valid { get; set; }
        public virtual DbSet<CTM_TradeDetail> TradeDetail { get; set; }
        public virtual DbSet<CTM_TradeLevel> TradeLevel { get; set; }
        public virtual DbSet<CTM_MultiTradeDetailRequest> MultiTradeDetailRequest { get; set; }
        public virtual DbSet<CTM_MultiTradeDetailResponse> MultiTradeDetaillResponse { get; set; }
        public virtual DbSet<CTM_MultiTradeLevelRequest> MultiTradeLevelRequest { get; set; }
        public virtual DbSet<CTM_MultiTradeLevelResponse> MultiTradeLevelResponse { get; set; }
        public virtual DbSet<CTM_InfoRequest> InfoRequest { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
         
        }

    }
}
