namespace WebReserva.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Valor_SectionPackages : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WrBloqueioDatas", "Valor", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.WrBloqueioDatas", "Valor");
        }
    }
}
