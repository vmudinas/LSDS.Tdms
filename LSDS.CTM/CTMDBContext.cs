using LSDS.CTM.CtmMessages;
using System.Data.Entity;

namespace LSDS.CTM
{
  

    public class CTMDBContext : DbContext
    {
        // Your context has been configured to use a 'CTMDBContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CTMEntity.CTMDBContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'CTMDBContext' 
        // connection string in the application configuration file.
        public CTMDBContext()
            : base("name=CTMDBContext")
        {
        }
        public CTMDBContext(string connectionString)
           : base(connectionString)
        {
        }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<CTM_Message> MyMessage { get; set; }
        public virtual DbSet<CTM_CancelBody> CancelBodyMsg { get; set; }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}