namespace SlijterijSjonnieLoper_version2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBUpdated : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CustomerModels", "WhiskeyModel_id", "dbo.WhiskeyModels");
            DropIndex("dbo.CustomerModels", new[] { "WhiskeyModel_id" });
            DropColumn("dbo.CustomerModels", "BirthDate");
            DropColumn("dbo.CustomerModels", "WhiskeyModel_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CustomerModels", "WhiskeyModel_id", c => c.String(maxLength: 128));
            AddColumn("dbo.CustomerModels", "BirthDate", c => c.DateTime(nullable: false));
            CreateIndex("dbo.CustomerModels", "WhiskeyModel_id");
            AddForeignKey("dbo.CustomerModels", "WhiskeyModel_id", "dbo.WhiskeyModels", "id");
        }
    }
}
