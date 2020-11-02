namespace SlijterijSjonnieLoper_version2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intialupdate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BestellingModels",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        AmountOfBottles = c.Int(nullable: false),
                        DateOfReservation = c.DateTime(nullable: false),
                        DateOfCompletionOrder = c.DateTime(nullable: false),
                        CompletedOrder = c.Boolean(nullable: false),
                        City = c.String(nullable: false),
                        StreetName = c.String(nullable: false),
                        StreetNumber = c.Int(nullable: false),
                        HouseNumberAddition = c.String(),
                        PostalCode = c.String(nullable: false),
                        Customer_id = c.String(nullable: false, maxLength: 128),
                        Whiskey_id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.CustomerModels", t => t.Customer_id, cascadeDelete: true)
                .ForeignKey("dbo.WhiskeyModels", t => t.Whiskey_id, cascadeDelete: true)
                .Index(t => t.Customer_id)
                .Index(t => t.Whiskey_id);
            
            CreateTable(
                "dbo.CustomerModels",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        DateOfBirth = c.DateTime(nullable: false),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        PrepositionName = c.String(),
                        City = c.String(nullable: false),
                        StreetName = c.String(nullable: false),
                        StreetNumber = c.Int(nullable: false),
                        HouseNumberAddition = c.String(),
                        PostalNumber = c.String(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                        BirthPlace = c.String(),
                        WhiskeyModel_id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.WhiskeyModels", t => t.WhiskeyModel_id)
                .Index(t => t.WhiskeyModel_id);
            
            CreateTable(
                "dbo.WhiskeyModels",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false),
                        age = c.Int(nullable: false),
                        ProductionSite = c.Int(nullable: false),
                        alcoholPercentages = c.Int(nullable: false),
                        typesOfWhiskey = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        NumberOfBottlesOnStorage = c.Int(nullable: false),
                        NumberOfBottlesReserved = c.Int(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.EmployeeModels",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        PrepositionName = c.String(),
                        City = c.String(nullable: false),
                        StreetName = c.String(nullable: false),
                        StreetNumber = c.Int(nullable: false),
                        HouseNumberAddition = c.String(),
                        PostalCode = c.String(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                        BirthPlace = c.String(nullable: false),
                        UserName = c.String(nullable: false),
                        PassWord = c.String(nullable: false),
                        WorkingSince = c.DateTime(nullable: false),
                        RoleEmployee = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.BestellingModels", "Whiskey_id", "dbo.WhiskeyModels");
            DropForeignKey("dbo.CustomerModels", "WhiskeyModel_id", "dbo.WhiskeyModels");
            DropForeignKey("dbo.BestellingModels", "Customer_id", "dbo.CustomerModels");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.CustomerModels", new[] { "WhiskeyModel_id" });
            DropIndex("dbo.BestellingModels", new[] { "Whiskey_id" });
            DropIndex("dbo.BestellingModels", new[] { "Customer_id" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.EmployeeModels");
            DropTable("dbo.WhiskeyModels");
            DropTable("dbo.CustomerModels");
            DropTable("dbo.BestellingModels");
        }
    }
}
