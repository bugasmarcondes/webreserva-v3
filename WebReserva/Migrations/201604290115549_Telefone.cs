namespace WebReserva.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Telefone : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WrHotels", "Telefone", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.WrHotels", "Telefone");
        }
    }
}
