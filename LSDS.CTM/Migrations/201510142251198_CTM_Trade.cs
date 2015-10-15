namespace LSDS.CTM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CTM_Trade : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.TdmsCTM", newName: "CTM_Trade");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.CTM_Trade", newName: "TdmsCTM");
        }
    }
}
