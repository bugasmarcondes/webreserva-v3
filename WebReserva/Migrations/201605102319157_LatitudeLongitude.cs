namespace WebReserva.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LatitudeLongitude : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WrHotels", "LatitudeLongitude", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.WrHotels", "LatitudeLongitude");
        }
    }
}
