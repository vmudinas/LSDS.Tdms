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


        protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
       
    }
}
