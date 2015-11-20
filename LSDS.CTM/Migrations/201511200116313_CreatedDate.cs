namespace LSDS.CTM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CTM_Message", "CreatedDate", c => c.DateTime(nullable: false));
            CreateIndex("dbo.CTM_Message", "CreatedDate", name: "IX_CTM_Message_CreatedDate");
        }
        
        public override void Down()
        {
            DropIndex("dbo.CTM_Message", "IX_CTM_Message_CreatedDate");
            DropColumn("dbo.CTM_Message", "CreatedDate");
        }
    }
}
