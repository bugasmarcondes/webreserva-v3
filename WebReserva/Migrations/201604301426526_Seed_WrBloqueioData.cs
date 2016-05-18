namespace WebReserva.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Seed_WrBloqueioData : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WrBloqueioDatas", "Img01", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.WrBloqueioDatas", "Img01");
        }
    }
}
