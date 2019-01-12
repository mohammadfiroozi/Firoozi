namespace Firoozi.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class setare : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Cities", name: "GeographicalLocation_Latiude", newName: "Latiude");
            RenameColumn(table: "dbo.Cities", name: "GeographicalLocation_Longitude", newName: "Longitude");
            RenameColumn(table: "dbo.Provinces", name: "GeographicalLocation_Latiude", newName: "Latiude");
            RenameColumn(table: "dbo.Provinces", name: "GeographicalLocation_Longitude", newName: "Longitude");
            RenameColumn(table: "dbo.Countries", name: "GeographicalLocation_Latiude", newName: "Latiude");
            RenameColumn(table: "dbo.Countries", name: "GeographicalLocation_Longitude", newName: "Longitude");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Countries", name: "Longitude", newName: "GeographicalLocation_Longitude");
            RenameColumn(table: "dbo.Countries", name: "Latiude", newName: "GeographicalLocation_Latiude");
            RenameColumn(table: "dbo.Provinces", name: "Longitude", newName: "GeographicalLocation_Longitude");
            RenameColumn(table: "dbo.Provinces", name: "Latiude", newName: "GeographicalLocation_Latiude");
            RenameColumn(table: "dbo.Cities", name: "Longitude", newName: "GeographicalLocation_Longitude");
            RenameColumn(table: "dbo.Cities", name: "Latiude", newName: "GeographicalLocation_Latiude");
        }
    }
}
