namespace CharterERP.Backend.WebUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CityProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "City", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "Country", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Country");
            DropColumn("dbo.AspNetUsers", "City");
        }
    }
}
