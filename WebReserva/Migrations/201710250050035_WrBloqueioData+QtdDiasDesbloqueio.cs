namespace WebReserva.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WrBloqueioDataQtdDiasDesbloqueio : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WrBloqueioDatas", "QtdDiasDesbloqueio", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.WrBloqueioDatas", "QtdDiasDesbloqueio");
        }
    }
}
