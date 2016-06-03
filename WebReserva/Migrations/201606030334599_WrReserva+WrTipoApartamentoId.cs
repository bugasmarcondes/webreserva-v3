namespace WebReserva.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WrReservaWrTipoApartamentoId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.WrReservas", "WrTipoApartamento_Id", "dbo.WrTipoApartamentoes");
            DropIndex("dbo.WrReservas", new[] { "WrTipoApartamento_Id" });
            RenameColumn(table: "dbo.WrReservas", name: "WrTipoApartamento_Id", newName: "WrTipoApartamentoId");
            AlterColumn("dbo.WrReservas", "WrTipoApartamentoId", c => c.Int(nullable: false));
            CreateIndex("dbo.WrReservas", "WrTipoApartamentoId");
            AddForeignKey("dbo.WrReservas", "WrTipoApartamentoId", "dbo.WrTipoApartamentoes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WrReservas", "WrTipoApartamentoId", "dbo.WrTipoApartamentoes");
            DropIndex("dbo.WrReservas", new[] { "WrTipoApartamentoId" });
            AlterColumn("dbo.WrReservas", "WrTipoApartamentoId", c => c.Int());
            RenameColumn(table: "dbo.WrReservas", name: "WrTipoApartamentoId", newName: "WrTipoApartamento_Id");
            CreateIndex("dbo.WrReservas", "WrTipoApartamento_Id");
            AddForeignKey("dbo.WrReservas", "WrTipoApartamento_Id", "dbo.WrTipoApartamentoes", "Id");
        }
    }
}
