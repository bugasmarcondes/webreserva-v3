namespace WebReserva.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveChegadaSaida : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.WrReservas", "Chegada");
            DropColumn("dbo.WrReservas", "Saida");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WrReservas", "Saida", c => c.DateTime(nullable: false));
            AddColumn("dbo.WrReservas", "Chegada", c => c.DateTime(nullable: false));
        }
    }
}
