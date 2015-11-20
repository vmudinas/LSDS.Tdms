namespace LSDS.CTM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNewmyKeyField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CTM_Message", "myKey", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CTM_Message", "myKey");
        }
    }
}
