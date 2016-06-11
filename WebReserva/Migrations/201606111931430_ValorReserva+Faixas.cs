namespace WebReserva.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ValorReservaFaixas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WrDisponibilidades", "DiariaCriancaFaixa01", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.WrDisponibilidades", "DiariaCriancaFaixa02", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.WrDisponibilidades", "DiariaCriancaFaixa03", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.WrReservas", "ValorTotal", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.WrDisponibilidades", "DiariaCrianca00");
            DropColumn("dbo.WrDisponibilidades", "DiariaCrianca01");
            DropColumn("dbo.WrDisponibilidades", "DiariaCrianca02");
            DropColumn("dbo.WrDisponibilidades", "DiariaCrianca03");
            DropColumn("dbo.WrDisponibilidades", "DiariaCrianca04");
            DropColumn("dbo.WrDisponibilidades", "DiariaCrianca05");
            DropColumn("dbo.WrDisponibilidades", "DiariaCrianca06");
            DropColumn("dbo.WrDisponibilidades", "DiariaCrianca07");
            DropColumn("dbo.WrDisponibilidades", "DiariaCrianca08");
            DropColumn("dbo.WrDisponibilidades", "DiariaCrianca09");
            DropColumn("dbo.WrDisponibilidades", "DiariaCrianca10");
            DropColumn("dbo.WrDisponibilidades", "DiariaCrianca11");
            DropColumn("dbo.WrDisponibilidades", "DiariaCrianca12");
            DropColumn("dbo.WrDisponibilidades", "DiariaCrianca13");
            DropColumn("dbo.WrDisponibilidades", "DiariaCrianca14");
            DropColumn("dbo.WrDisponibilidades", "DiariaCrianca15");
            DropColumn("dbo.WrDisponibilidades", "DiariaCrianca16");
            DropColumn("dbo.WrDisponibilidades", "DiariaCrianca17");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WrDisponibilidades", "DiariaCrianca17", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.WrDisponibilidades", "DiariaCrianca16", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.WrDisponibilidades", "DiariaCrianca15", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.WrDisponibilidades", "DiariaCrianca14", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.WrDisponibilidades", "DiariaCrianca13", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.WrDisponibilidades", "DiariaCrianca12", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.WrDisponibilidades", "DiariaCrianca11", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.WrDisponibilidades", "DiariaCrianca10", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.WrDisponibilidades", "DiariaCrianca09", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.WrDisponibilidades", "DiariaCrianca08", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.WrDisponibilidades", "DiariaCrianca07", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.WrDisponibilidades", "DiariaCrianca06", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.WrDisponibilidades", "DiariaCrianca05", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.WrDisponibilidades", "DiariaCrianca04", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.WrDisponibilidades", "DiariaCrianca03", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.WrDisponibilidades", "DiariaCrianca02", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.WrDisponibilidades", "DiariaCrianca01", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.WrDisponibilidades", "DiariaCrianca00", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.WrReservas", "ValorTotal");
            DropColumn("dbo.WrDisponibilidades", "DiariaCriancaFaixa03");
            DropColumn("dbo.WrDisponibilidades", "DiariaCriancaFaixa02");
            DropColumn("dbo.WrDisponibilidades", "DiariaCriancaFaixa01");
        }
    }
}
