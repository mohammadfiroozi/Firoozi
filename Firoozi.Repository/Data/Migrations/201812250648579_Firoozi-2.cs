namespace Firoozi.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Firoozi2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cities", "Province_Id1", "dbo.Provinces");
            DropIndex("dbo.Cities", new[] { "Province_Id1" });
            DropColumn("dbo.Cities", "Province_Id");
            RenameColumn(table: "dbo.Cities", name: "Province_Id1", newName: "Province_Id");
            AlterColumn("dbo.Cities", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Cities", "Latiude", c => c.Single());
            AlterColumn("dbo.Cities", "longitude", c => c.Single());
            AlterColumn("dbo.Cities", "Province_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Provinces", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Provinces", "PhoneCode", c => c.Int());
            AlterColumn("dbo.Provinces", "latitude", c => c.Single());
            AlterColumn("dbo.Provinces", "longitude", c => c.Single());
            CreateIndex("dbo.Cities", "Province_Id");
            AddForeignKey("dbo.Cities", "Province_Id", "dbo.Provinces", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cities", "Province_Id", "dbo.Provinces");
            DropIndex("dbo.Cities", new[] { "Province_Id" });
            AlterColumn("dbo.Provinces", "longitude", c => c.Single(nullable: false));
            AlterColumn("dbo.Provinces", "latitude", c => c.Single(nullable: false));
            AlterColumn("dbo.Provinces", "PhoneCode", c => c.Int(nullable: false));
            AlterColumn("dbo.Provinces", "Name", c => c.String());
            AlterColumn("dbo.Cities", "Province_Id", c => c.Int());
            AlterColumn("dbo.Cities", "longitude", c => c.Single(nullable: false));
            AlterColumn("dbo.Cities", "Latiude", c => c.Single(nullable: false));
            AlterColumn("dbo.Cities", "Name", c => c.String());
            RenameColumn(table: "dbo.Cities", name: "Province_Id", newName: "Province_Id1");
            AddColumn("dbo.Cities", "Province_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Cities", "Province_Id1");
            AddForeignKey("dbo.Cities", "Province_Id1", "dbo.Provinces", "Id");
        }
    }
}
