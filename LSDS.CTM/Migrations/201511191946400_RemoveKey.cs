namespace LSDS.CTM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveKey : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.CTM_Message", "myKey");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CTM_Message", "myKey", c => c.String());
        }
    }
}
