namespace WebReserva.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Titulo_WrBloqueioData : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WrBloqueioDatas", "Titulo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.WrBloqueioDatas", "Titulo");
        }
    }
}
