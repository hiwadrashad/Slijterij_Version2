namespace SlijterijSjonnieLoper_version2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelUpdate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BestellingModels", "Whiskey_id", "dbo.WhiskeyModels");
            DropIndex("dbo.BestellingModels", new[] { "Whiskey_id" });
            AddColumn("dbo.CustomerModels", "EmailAdress", c => c.String(nullable: false));
            AlterColumn("dbo.BestellingModels", "DateOfReservation", c => c.DateTime());
            AlterColumn("dbo.BestellingModels", "DateOfCompletionOrder", c => c.DateTime());
            DropColumn("dbo.BestellingModels", "AmountOfBottles");
            DropColumn("dbo.BestellingModels", "Whiskey_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BestellingModels", "Whiskey_id", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.BestellingModels", "AmountOfBottles", c => c.Int(nullable: false));
            AlterColumn("dbo.BestellingModels", "DateOfCompletionOrder", c => c.DateTime(nullable: false));
            AlterColumn("dbo.BestellingModels", "DateOfReservation", c => c.DateTime(nullable: false));
            DropColumn("dbo.CustomerModels", "EmailAdress");
            CreateIndex("dbo.BestellingModels", "Whiskey_id");
            AddForeignKey("dbo.BestellingModels", "Whiskey_id", "dbo.WhiskeyModels", "id", cascadeDelete: true);
        }
    }
}
