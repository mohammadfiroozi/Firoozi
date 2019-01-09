namespace Firoozi.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mari : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cities", "Code", c => c.String());
            AddColumn("dbo.Cities", "GeographicalLocation_Latiude", c => c.Single());
            AddColumn("dbo.Cities", "GeographicalLocation_Longitude", c => c.Single());
            AddColumn("dbo.Provinces", "Code", c => c.String());
            AddColumn("dbo.Provinces", "GeographicalLocation_Latiude", c => c.Single());
            AddColumn("dbo.Provinces", "GeographicalLocation_Longitude", c => c.Single());
            AddColumn("dbo.Countries", "GeographicalLocation_Latiude", c => c.Single());
            AddColumn("dbo.Countries", "GeographicalLocation_Longitude", c => c.Single());
            AddColumn("dbo.Countries", "Code", c => c.String());
            AddColumn("dbo.Countries", "Description", c => c.String());
            DropColumn("dbo.Cities", "Latiude");
            DropColumn("dbo.Cities", "longitude");
            DropColumn("dbo.Provinces", "PhoneCode");
            DropColumn("dbo.Provinces", "latitude");
            DropColumn("dbo.Provinces", "longitude");
            DropColumn("dbo.Countries", "NickName");
            DropColumn("dbo.Countries", "PhoneCode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Countries", "PhoneCode", c => c.Int());
            AddColumn("dbo.Countries", "NickName", c => c.String(maxLength: 200));
            AddColumn("dbo.Provinces", "longitude", c => c.Single());
            AddColumn("dbo.Provinces", "latitude", c => c.Single());
            AddColumn("dbo.Provinces", "PhoneCode", c => c.Int());
            AddColumn("dbo.Cities", "longitude", c => c.Single());
            AddColumn("dbo.Cities", "Latiude", c => c.Single());
            DropColumn("dbo.Countries", "Description");
            DropColumn("dbo.Countries", "Code");
            DropColumn("dbo.Countries", "GeographicalLocation_Longitude");
            DropColumn("dbo.Countries", "GeographicalLocation_Latiude");
            DropColumn("dbo.Provinces", "GeographicalLocation_Longitude");
            DropColumn("dbo.Provinces", "GeographicalLocation_Latiude");
            DropColumn("dbo.Provinces", "Code");
            DropColumn("dbo.Cities", "GeographicalLocation_Longitude");
            DropColumn("dbo.Cities", "GeographicalLocation_Latiude");
            DropColumn("dbo.Cities", "Code");
        }
    }
}
