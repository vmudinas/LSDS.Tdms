using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LSDS.Tdms.Models;
using LSDS.Tdms.Models.TdmsDataModel;

namespace LSDS.Tdms.Models
{
    public class TdmsDbContext:DbContext
    {
        public DbSet<UspReturnVersion> Version { get; set; }
        public DbSet<usp_returnUserbyUserName_Result> UserByUserName { get; set; }
        public DbSet<usp_LoginReport_Result> LoginReport { get; set; }
        public DbSet<object> LoginAttemt { get; set; }
        public DbSet<QuickfindMC> QuickfindMC { get; set; }
        public DbSet<Quickfind_Default> Quickfind_Default { get; set; }
        public DbSet<QuickFind_Query> QuickFind_Query { get; set; }
        public DbSet<QuickSort> QuickSort { get; set; }
        public DbSet<QuickSortItem> QuickSortItem { get; set; }

        public DbSet<usp_returnTDMSMenu_Result> GetMenu { get; set; }
        //  public DbSet<T> Generic { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
       
    }
}
