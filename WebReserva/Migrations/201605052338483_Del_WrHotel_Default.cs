namespace WebReserva.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Del_WrHotel_Default : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.WrHotels", "Default");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WrHotels", "Default", c => c.Boolean(nullable: false));
        }
    }
}
