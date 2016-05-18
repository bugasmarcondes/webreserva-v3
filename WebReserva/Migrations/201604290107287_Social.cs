namespace WebReserva.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Social : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WrHotels", "Facebook", c => c.String());
            AddColumn("dbo.WrHotels", "Twitter", c => c.String());
            AddColumn("dbo.WrHotels", "Instagram", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.WrHotels", "Instagram");
            DropColumn("dbo.WrHotels", "Twitter");
            DropColumn("dbo.WrHotels", "Facebook");
        }
    }
}
