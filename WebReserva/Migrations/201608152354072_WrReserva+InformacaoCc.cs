namespace WebReserva.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WrReservaInformacaoCc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WrReservas", "CcTipo", c => c.Int(nullable: false));
            AddColumn("dbo.WrReservas", "CcNumero", c => c.String());
            AddColumn("dbo.WrReservas", "CcNomeTitular", c => c.String());
            AddColumn("dbo.WrReservas", "CcValidadeMes", c => c.Int(nullable: false));
            AddColumn("dbo.WrReservas", "CcValidadeAno", c => c.Int(nullable: false));
            AddColumn("dbo.WrReservas", "CcCodigoSeguranca", c => c.Int(nullable: false));
            DropColumn("dbo.WrReservas", "NumeroCartaoCredito");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WrReservas", "NumeroCartaoCredito", c => c.String());
            DropColumn("dbo.WrReservas", "CcCodigoSeguranca");
            DropColumn("dbo.WrReservas", "CcValidadeAno");
            DropColumn("dbo.WrReservas", "CcValidadeMes");
            DropColumn("dbo.WrReservas", "CcNomeTitular");
            DropColumn("dbo.WrReservas", "CcNumero");
            DropColumn("dbo.WrReservas", "CcTipo");
        }
    }
}
