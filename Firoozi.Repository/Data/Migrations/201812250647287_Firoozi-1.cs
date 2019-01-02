namespace Firoozi.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Firoozi1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Latiude = c.Single(nullable: false),
                        longitude = c.Single(nullable: false),
                        Province_Id = c.Int(nullable: false),
                        Province_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Provinces", t => t.Province_Id1)
                .Index(t => t.Province_Id1);
            
            CreateTable(
                "dbo.Provinces",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PhoneCode = c.Int(nullable: false),
                        latitude = c.Single(nullable: false),
                        longitude = c.Single(nullable: false),
                        Country_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.Country_Id, cascadeDelete: true)
                .Index(t => t.Country_Id);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Abbrevation = c.String(maxLength: 5),
                        Name = c.String(nullable: false, maxLength: 50),
                        NickName = c.String(maxLength: 200),
                        PhoneCode = c.Int(),
                        flag = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Provinces", "Country_Id", "dbo.Countries");
            DropForeignKey("dbo.Cities", "Province_Id1", "dbo.Provinces");
            DropIndex("dbo.Provinces", new[] { "Country_Id" });
            DropIndex("dbo.Cities", new[] { "Province_Id1" });
            DropTable("dbo.Countries");
            DropTable("dbo.Provinces");
            DropTable("dbo.Cities");
        }
    }
}
