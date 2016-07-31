namespace WebReserva.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTipoPagamento : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WrReservas", "TipoPagamento", c => c.Int(nullable: false));
            AddColumn("dbo.WrReservas", "NumeroCartaoCredito", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.WrReservas", "NumeroCartaoCredito");
            DropColumn("dbo.WrReservas", "TipoPagamento");
        }
    }
}
